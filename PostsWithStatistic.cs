using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class PostsWithStatistic
    {
        public FacebookObjectCollection<Post> Posts { get; set; }
        public List<ActiveCommentator> ActiveCommentators { get; set; }
        public List<ActiveLiker> ActiveLikers { get; set; }

        public PostsWithStatistic(FacebookObjectCollection<Post> i_Posts, List<ActiveLiker> i_ActiveLikers, 
            List<ActiveCommentator> i_ActiveCommentators)
        {
            Posts = i_Posts;
            ActiveCommentators = i_ActiveCommentators;
            ActiveLikers = i_ActiveLikers;
        }
    }
}
