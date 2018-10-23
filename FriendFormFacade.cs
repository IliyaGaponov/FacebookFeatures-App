using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class FriendFormFacade
    {        
        public User LoggedInUser { get; set; }
        public User Friend { get; set; }        

        public FriendFormFacade(User i_SelectedFriend, User i_LoggedInUser)
        {
            Friend = i_SelectedFriend;
            LoggedInUser = i_LoggedInUser;
        }

        public City GetLocation()
        {
            return Friend.Location;
        }

        public string GetBirthday()
        {
            return Friend.Birthday;
        }

        public string GetPictureNormalURL()
        {
            return Friend.PictureNormalURL;
        }

        public string GetFirstName()
        {
            return Friend.FirstName;
        }

        public string GetLastName()
        {
            return Friend.LastName;
        }

        public List<string> FindCommonFriends()
        {
            return СoncurrencesSearcher.FindCommonsFriends(LoggedInUser, Friend);
        }

        public List<string> FindCommonGroups()
        {
            return СoncurrencesSearcher.FindCommonsGroups(LoggedInUser, Friend);
        }

        public void PostStatus(string i_Status)
        {
            Friend.PostStatus(i_Status);
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return Friend.Albums;
        }
    }
}
