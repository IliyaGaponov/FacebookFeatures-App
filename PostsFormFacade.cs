using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class PostsFormFacade
    {
        private UserWithStatistic m_PostsOwner;

        public PostsFormFacade(UserWithStatistic i_PostsOwner)
        {
            m_PostsOwner = i_PostsOwner;
        }             

        public PostsWithStatistic GetPosts()
        {
            return m_PostsOwner.WallPosts;
        }
    }
}