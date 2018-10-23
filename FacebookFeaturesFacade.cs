using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections;

namespace DesktopFacebook
{
    public class FacebookFeaturesFacade : IEnumerable<string>
    {
        public User LoggedInUser { get; set; }

        public string GetUserName()
        {
            String username = "";

            if (LoggedInUser != null)
            {
                username = LoggedInUser.Name;
            }

            return username;
        }

        public void SaveSettings(bool i_AutoLogin) 
        {
            ApplicationSettings.Instance.AutoLogin = i_AutoLogin;
            ApplicationSettings.Instance.SaveToFile();
        }

        public void LoadSettings()
        {
            ApplicationSettings.FromFileOrDefault();
        }

        public bool DefaultLogin()
        {
            bool loggedIn = false;

            if (ApplicationSettings.Instance.AutoLogin)
            {
                autoLogin();
                loggedIn = true;
            }

            return loggedIn;
        }

        private void autoLogin()
        {
            LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
            //getting error because of fb access problem
            //if (string.IsNullOrEmpty(result.ErrorMessage))  
            {
                LoggedInUser = result.LoggedInUser;
            }
        }

        public bool Login()
        {
            bool loggedIn = false;
            //Guy's app id: 1450160541956417
            LoginResult result = FacebookService.Login("279928439249477",
                "public_profile",
                "user_birthday",
                "user_friends",
                //"user_groups"  - fb don't allow to get this
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts");
            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                ApplicationSettings.Instance.AccessToken = result.AccessToken;
                ApplicationSettings.Instance.AutoLogin = true;
                loggedIn = true;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

            return loggedIn;
        }

        public string GetUserProfilePicture()
        {
            return LoggedInUser.PictureNormalURL;
        }

        public string GetBigProfilePicture()
        {
            return LoggedInUser.PictureLargeURL;
        }        

        public User GetFriend(int i_Index)
        {
            return LoggedInUser.Friends.ElementAt(i_Index);
        }

        public int GetFriendsNumber()
        {
            return LoggedInUser.Friends.Count;
        }

        public void LogOut()
        {
            FacebookService.Logout(doLogout);
        }

        private void doLogout()
        {
            ApplicationSettings.Instance.AccessToken = null;
            ApplicationSettings.Instance.AutoLogin = false;
            ApplicationSettings.Instance.SaveToFile();
        }

        public void PostStatus(string i_Text)
        {
            LoggedInUser.PostStatus(i_Text);
        }

        public FacebookObjectCollection<Album> GetUsersAlbums()
        {
            return LoggedInUser.Albums;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(User friend in LoggedInUser.Friends)
            {
                yield return friend.Name;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                yield return friend;
            }
        }
    }
}
