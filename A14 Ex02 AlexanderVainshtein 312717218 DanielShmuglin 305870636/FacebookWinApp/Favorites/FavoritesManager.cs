namespace Ex2.FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FacebookWrapper.ObjectModel;

    public class FavoritesManager
    {
        private IDataStorage m_Storage;

        public FavoritesManager()
        {
            initializeStorage();
        }

        private void initializeStorage()
        {
            const string v_StorageFilename = "favorites.xml";
            m_Storage = new XmlFileStorage(v_StorageFilename);
        }

        public void MarkFavorite(Post i_Post)
        {
            m_Storage.PutItem(new FavoriteItem(i_Post));
        }

        public void UnmarkFavorite(Post i_Post)
        {
            m_Storage.DeleteItem(i_Post.Id);
        }

        public IEnumerable<Post> GetFavoritePosts()
        {
            foreach (var item in m_Storage.GetItems())
            {
                var post = FacebookWrapper.FacebookService.GetObject<Post>(item.Id);
                if (post == null)
                {
                    continue;
                }

                yield return post;
            }
        }
    }
}
