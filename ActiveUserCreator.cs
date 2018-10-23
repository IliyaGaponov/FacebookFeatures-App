using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public static class ActiveUserCreator
    {
        public static IActiveUser CreateActiveUser(Type i_Type)
        {
            IActiveUser activeUser = null;

            if(i_Type == typeof(User))
            {
                activeUser = new ActiveLiker();
            }
            else if(i_Type == typeof(Comment))
            {
                activeUser = new ActiveCommentator();
            }

            return activeUser;
        }
    }
}
