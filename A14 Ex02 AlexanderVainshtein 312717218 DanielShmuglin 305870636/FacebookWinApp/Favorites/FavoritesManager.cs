namespace Ex2.FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FacebookWrapper.ObjectModel;

    public class FavoritesManager
    {
        public delegate void FavoriteChangeEventHandler(object i_Sender, Post i_Post);

        public event FavoriteChangeEventHandler FavoriteAdded;

        public event FavoriteChangeEventHandler FavoriteRemoved;

        private IDataStorage m_Storage;

        private readonly Dictionary<string, Tuple<FavoriteItem, Post>> r_FavoritePosts = new Dictionary<string, Tuple<FavoriteItem, Post>>();

        private Task m_LoadFavoritesTask;

        public FavoritesManager(string i_UserId)
        {
            initializeStorage(i_UserId);
            m_LoadFavoritesTask = new Task(loadFavorites);
            m_LoadFavoritesTask.Start();
        }

        private void initializeStorage(string i_UserId)
        {
            string v_StorageFilename = string.Format("favorites_{0}.xml", i_UserId);
            m_Storage = new XmlFileStorage(v_StorageFilename);
        }

        public void MarkFavorite(Post i_Post)
        {
            m_LoadFavoritesTask.Wait();
            if (r_FavoritePosts.ContainsKey(i_Post.Id))
            {
                r_FavoritePosts.Remove(i_Post.Id);
            }

            r_FavoritePosts.Add(i_Post.Id, new Tuple<FavoriteItem, Post>(new FavoriteItem(i_Post), i_Post));
            m_Storage.PutItem(r_FavoritePosts[i_Post.Id].Item1);
            OnFavoriteAdded(i_Post);
        }

        public void UnmarkFavorite(Post i_Post)
        {
            m_LoadFavoritesTask.Wait();
            if (r_FavoritePosts.ContainsKey(i_Post.Id))
            {
                r_FavoritePosts.Remove(i_Post.Id);
            }

            m_Storage.DeleteItem(i_Post.Id);
            OnFavoriteRemoved(i_Post);
        }

        public IEnumerable<Post> GetFavoritePosts()
        {
            m_LoadFavoritesTask.Wait();
            var postsInfo = r_FavoritePosts.Values.ToList();
            postsInfo.Sort(postsComparison);
            foreach (var postInfo in postsInfo)
            {
                yield return postInfo.Item2;
            }
        }

        private int postsComparison(Tuple<FavoriteItem, Post> i_Tuple1, Tuple<FavoriteItem, Post> i_Tuple2)
        {
            var creationTime1 = i_Tuple1.Item2.CreatedTime.HasValue ? i_Tuple1.Item2.CreatedTime.Value.Ticks : 0;
            var creationTime2 = i_Tuple2.Item2.CreatedTime.HasValue ? i_Tuple2.Item2.CreatedTime.Value.Ticks : 0;

            return creationTime2.CompareTo(creationTime1);
        }

        private void OnFavoriteAdded(Post i_Post)
        {
            if (FavoriteAdded != null)
            {
                FavoriteAdded(this, i_Post);
            }
        }

        private void OnFavoriteRemoved(Post i_Post)
        {
            if (FavoriteRemoved != null)
            {
                FavoriteRemoved(this, i_Post);
            }
        }

        private void loadFavorites()
        {
            foreach (FavoriteItem favoriteItem in m_Storage.GetItems())
            {
                if (!r_FavoritePosts.ContainsKey(favoriteItem.Id))
                {
                    Post post = null;
                    try
                    {
                        post = FacebookWrapper.FacebookService.GetObject<Post>(favoriteItem.Id);
                    }
                    catch (Exception)
                    { 
                        // Log error
                    }
                    
                    if (post == null)
                    {
                        continue;
                    }

                    r_FavoritePosts.Add(favoriteItem.Id, new Tuple<FavoriteItem, Post>(favoriteItem, post));
                }
            }
        }
    }
}