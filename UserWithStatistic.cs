using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class UserWithStatistic : OwnerObject
    {
        public User User { get; set; }
        private StatisticBuilder m_StatisticBuilder;

        public new PostsWithStatistic WallPosts
        {
            get
            {
                PostsWithStatistic postObj;
                FacebookObjectCollection<Post> posts = User.Posts;
                List<ActiveLiker> likers = m_StatisticBuilder.GetActiveLikersList(posts);
                List<ActiveCommentator> commentators = m_StatisticBuilder.GetActiveCommentatorsList(posts);

                likers.Sort(new ComparerByLikes());
                commentators.Sort(new ComparerByComments());
                postObj = new PostsWithStatistic(posts, likers, commentators);

                return postObj;
            }
        }

        public UserWithStatistic()
        {
            m_StatisticBuilder = new StatisticBuilder();
        }
    }
}