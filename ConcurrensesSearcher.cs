using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public static class СoncurrencesSearcher
    {
        public static List<string> FindCommonsFriends(User i_User, User i_UserFriend)
        {
            List<string> commonFriends = new List<string>();

            foreach (User friend in i_User.Friends)
            {
                if (i_UserFriend.Friends.Contains(friend))
                {
                    commonFriends.Add(friend.Name);
                }
            }

            return commonFriends;
        }

        public static List<string> FindCommonsGroups(User i_User, User i_UserFriend)
        {
            List<string> commonGroups = new List<string>();

            foreach (Group group in i_User.Groups)
            {
                if (i_UserFriend.Groups.Contains(group))
                {
                    commonGroups.Add(group.Name);
                }
            }

            return commonGroups;
        }
    }
}
