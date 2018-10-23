using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Drawing.Imaging;
using System.Threading;

namespace DesktopFacebook
{
    public partial class FacebookFeatures : Form, IAlbumOperable
    {
        private FacebookFeaturesFacade m_Facade;
        private AlbumOperator m_AlbumOperator;
        private readonly string r_NoFriendsMessage = "You don't have friends";
        public FacebookObjectCollection<Album> UsersAlbums { get; set; }
        public Panel PhotosPanel { get; set; }
        public Album PhotosAlbum { get; set; }
        public Label AlbumNameLabel { get; set; }
        public ListBox ListBoxAlbums { get; set; }
        public Button ButtonSlideshow { get; set; }
        public Button ButtonShowAllAlbums { get; set; }

        public FacebookFeatures()
        {
            InitializeComponent();
            m_Facade = new FacebookFeaturesFacade();
            m_AlbumOperator = new AlbumOperator();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            bool btnLogoutVisible = buttonLogout.Visible ? true : false;

            base.OnClosing(e);
            ApplicationSettings.Instance.LastWindowState = this.WindowState;
            ApplicationSettings.Instance.LastWindowSize = this.Size;
            ApplicationSettings.Instance.LastWindowLocation = this.Location;
            m_Facade.SaveSettings(btnLogoutVisible);            
        }       

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            new Thread(() =>
            {
                bool loggedIn = m_Facade.DefaultLogin();

                if (loggedIn)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.Size = ApplicationSettings.Instance.LastWindowSize;
                        this.WindowState = ApplicationSettings.Instance.LastWindowState;
                        this.Location = ApplicationSettings.Instance.LastWindowLocation;
                    }));
                    makeLocalComponentsVisible();
                    uploadInfo();
                }
            }).Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool loggedIn = m_Facade.Login();

            if (loggedIn)
            {
                makeLocalComponentsVisible();
                uploadInfo();
            }
        }

        private void makeLocalComponentsVisible()
        {
            this.Invoke(new Action(() =>
            {
                UILogicHelper.MakeControlsInvisible(buttonLogin);
                UILogicHelper.MakeControlsVisible(labelHelloUser, buttonLogout, pictureBoxUser, buttonShowFriends,
                    buttonMyPosts, buttonMakePost, buttonAlbums);
            }));
        }

        private void uploadInfo()
        {
            if (!String.IsNullOrEmpty(m_Facade.GetUserName()))
            {
                labelHelloUser.Invoke(new Action(() => labelHelloUser.Text = "Hello, " + m_Facade.GetUserName()));
                pictureBoxUser.Load(m_Facade.GetUserProfilePicture());
            }
        }

        // Show user friends
        private void buttonShowFriends_Click(object sender, EventArgs e)
        {
            new Thread(showFriends).Start();
        }

        private void showFriends()
        {
            closeAllComponents();
            listBoxFriends.Invoke(new Action(
                () =>
                {
                    listBoxFriends.Items.Clear();
                    UILogicHelper.MakeControlsVisible(listBoxFriends, forFriendsListBoxLabel);
                    if (m_Facade.GetFriendsNumber() > 0)
                    {                       
                        foreach(String friend in m_Facade)
                        {
                            listBoxFriends.Items.Add(friend);
                        }
                    }
                    else
                    {
                        listBoxFriends.Items.Add(r_NoFriendsMessage);
                    }
                }));
        }

        private void listBoxFriends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxFriends.GetItemText(listBoxFriends.SelectedItem) != r_NoFriendsMessage)
            {
                User selectedFriend = m_Facade.GetFriend(listBoxFriends.SelectedIndex);
                FriendFormFacade friendsFacade = new FriendFormFacade(selectedFriend, m_Facade.LoggedInUser);
                FriendsForm friendsForm = new FriendsForm(friendsFacade);
                friendsForm.Show();
            }
        }

        // Showing Posts of User
        private void buttonMyPosts_Click(object sender, EventArgs e)
        {
            PostsFormFacade postsFacade = new PostsFormFacade(new UserWithStatistic { User = m_Facade.LoggedInUser });
            PostsForm pf = new PostsForm(postsFacade);
            pf.Show();
        }

        // Profile Picture Clicking
        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            closeAllComponents();
            pictureBoxLargeFoto.LoadAsync(m_Facade.GetBigProfilePicture());
            UILogicHelper.MakeControlsVisible(buttonClosePicture, pictureBoxLargeFoto);
        }

        // Big Profile Picture Clicking
        private void pictureBoxLargeFoto_Click(object sender, EventArgs e)
        {
            closeAllComponents();
        }

        //Closing large picture
        private void buttonClosePicture_Click(object sender, EventArgs e)
        {
            closeAllComponents();
        }

        // Logout From Account
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Calling method doLogout
            m_Facade.LogOut();
            closeAllComponents();
            UILogicHelper.MakeControlsVisible(buttonLogin);
            UILogicHelper.MakeControlsInvisible(buttonLogout, pictureBoxUser, buttonShowFriends,
                labelHelloUser, buttonMyPosts, buttonMakePost, textBoxPost, buttonAlbums);
        }

        // Making Post on Timeline
        private void buttonMakePost_Click(object sender, EventArgs e)
        {
            closeAllComponents();
            textBoxPost.Text = "Enter your post";
            UILogicHelper.MakeControlsVisible(textBoxPost);
        }

        private void textBoxPost_Click(object sender, EventArgs e)
        {
            textBoxPost.Clear();
        }

        //sending post to the wall on 'enter' click
        private void onKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_Facade.PostStatus(textBoxPost.Text);
                UILogicHelper.MakeControlsVisible(textBoxPost);
                MessageBox.Show("Your post was successfully post.");
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            new Thread(showAlbums).Start();
        }

        private void showAlbums()
        {
            closeAllComponents();
            this.Invoke(new Action(() =>
            {
                UILogicHelper.MakeControlsVisible(forAlbumsListBoxLabel, createdTimeLabel, createdTimeLabel1,
                  imageAlbumLabel, imageAlbumPictureBox, nameLabel, nameLabel1);
            }));
            ListBoxAlbums = listBoxAlbums;
            UsersAlbums = m_Facade.GetUsersAlbums();
            m_AlbumOperator.ShowAlbums(this, albumBindingSource);
        }

        // Load photos from album
        private void listBoxAlbums_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            closeAllComponents();
            PhotosPanel = panelPhotos;
            AlbumNameLabel = labelAlbumName;
            ButtonSlideshow = buttonSlideshow;
            m_AlbumOperator.FillPanel(this);
        }

        private void closeAllComponents()
        {
            this.Invoke(new Action(() =>
            {
                UILogicHelper.MakeControlsInvisible(createdTimeLabel, createdTimeLabel1, imageAlbumLabel,
                imageAlbumPictureBox, nameLabel, nameLabel1, forFriendsListBoxLabel, forAlbumsListBoxLabel,
                pictureBoxLargeFoto, buttonClosePicture, textBoxPost, listBoxAlbums, listBoxFriends,
                panelPhotos, labelAlbumName, buttonSlideshow);
            }));
        }

        private void buttonSlideshow_Click(object sender, EventArgs e)
        {
            m_AlbumOperator.RunPictureShower(PhotosAlbum, PhotosAlbum.Photos[0].ImageNormal, 0);
            m_AlbumOperator.PictureShower.PlaySlideShow();
        }
    }
}