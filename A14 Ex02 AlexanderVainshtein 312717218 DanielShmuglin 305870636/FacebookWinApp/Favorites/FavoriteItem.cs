namespace Ex2.FacebookApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FacebookWrapper.ObjectModel;

    public class FavoriteItem : SimpleStorableItem
    {
        public FavoriteItem()
        {
        }

        public FavoriteItem(Post i_Post)
        {
            Id = i_Post.Id;
            Data = DateTime.Now.Ticks.ToString();
            Name = i_Post.From.Name;
        }

        public string Name { get; set; }
    }
}
