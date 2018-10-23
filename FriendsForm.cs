using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public partial class FriendsForm : Form, IAlbumOperable
    {
        private AlbumOperator m_AlbumOperator;
        public FacebookObjectCollection<Album> UsersAlbums { get; set; }
        public FriendFormFacade FriendsFacade { get; set; }
        private readonly string r_NoCommonGroups = "No common groups";
        private readonly string r_NoMutualFriends = "No mutual friends";
        public Panel PhotosPanel { get; set; }
        public Album PhotosAlbum { get; set; }
        public Label AlbumNameLabel { get; set; }
        public ListBox ListBoxAlbums { get; set; }
        public Button ButtonSlideshow { get; set; }

        public FriendsForm(FriendFormFacade i_FriensFacade)
        {
            InitializeComponent();
            FriendsFacade = i_FriensFacade;
            m_AlbumOperator = new AlbumOperator();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            loadInfo();
        }

        private void loadInfo()
        {
            string friendLocationName = "";
            string friendBirthday = FriendsFacade.GetBirthday();
            City location = FriendsFacade.GetLocation();          

            if (location != null)
            {
                friendLocationName = location.Name;
            }

            pictureBoxUserFriend.Load(FriendsFacade.GetPictureNormalURL());
            buttonPostToFriend.Text = "Post on " + FriendsFacade.GetFirstName() + "'s Timeline";
            labelFriendInfo.Text = string.Format(@"{0} {1}
{2}
{3}",
FriendsFacade.GetFirstName(), FriendsFacade.GetLastName(), friendLocationName, friendBirthday);
        }

        private void buttonMutualFriends_Click(object sender, EventArgs e)
        {
            showMutualFriends();
        }

        private void showMutualFriends()
        {
            List<string> commonFriends = null;

            closeAllComponents();
            UILogicHelper.MakeControlsVisible(listBoxMutualFriends);
            new Thread(() =>
            {
                commonFriends = FriendsFacade.FindCommonFriends();
                fillListBox(listBoxMutualFriends, commonFriends, r_NoMutualFriends);
            }).Start();
        }

        // Show Common Groups with Friend
        private void buttonCommonGroups_Click(object sender, EventArgs e)
        {
            showCommonGroups();
        }

        private void showCommonGroups()
        {
            List<string> commonGroups = null;

            closeAllComponents();
            UILogicHelper.MakeControlsVisible(listBoxCommonGroups);
            new Thread(() =>
            {
                commonGroups = FriendsFacade.FindCommonGroups();
                fillListBox(listBoxMutualFriends, commonGroups, r_NoCommonGroups);
            }).Start();
        }

        private void fillListBox(ListBox io_ListBox, List<string> i_StringsList, string i_NoCommonInfoMessage)
        {
            if (i_StringsList != null)
            {
                io_ListBox.Invoke(new Action(() =>
                {
                    if (i_StringsList.Count != 0)
                    {
                        foreach (string item in i_StringsList)
                        {
                            io_ListBox.Items.Add(item);
                        }
                    }
                    else
                    {
                        io_ListBox.Items.Add(i_NoCommonInfoMessage);
                    }
                }));
            }
        }

        // Post on Friend's Timeline
        private void buttonPostToFriend_Click(object sender, EventArgs e)
        {
            closeAllComponents();
            textBoxPostFriend.Text = "Enter your post";
            UILogicHelper.MakeControlsVisible(textBoxPostFriend);
        }

        private void textBoxPostFriend_Click(object sender, EventArgs e)
        {
            textBoxPostFriend.Clear();
        }

        private void onKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FriendsFacade.PostStatus(textBoxPostFriend.Text);
                UILogicHelper.MakeControlsInvisible(textBoxPostFriend);
                MessageBox.Show("Your post was successfully post.");
            }
        }

        private void buttonFriendAlbums_Click(object sender, EventArgs e)
        {
            new Thread(showAlbums).Start();
        }

        private void showAlbums()
        {
            closeAllComponents();
            this.Invoke(new Action(() =>
            {
                UILogicHelper.MakeControlsVisible(forAlbumsListBoxLabel, createdTimeLabel, createdTimeLabel1,
                    imageAlbumLabel, imageAlbumPictureBox, nameLabel, nameLabel1, forAlbumsListBoxLabel);               
            }));
            ListBoxAlbums = listBoxFriendAlbums;
            UsersAlbums = FriendsFacade.GetUserAlbums();
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
                    imageAlbumPictureBox, nameLabel, nameLabel1, forAlbumsListBoxLabel, listBoxCommonGroups,
                    listBoxMutualFriends, listBoxFriendAlbums, textBoxPostFriend, labelAlbumName, panelPhotos,
                    buttonSlideshow, labelFriendInfo);                
            }));
        }

        private void buttonSlideshow_Click(object sender, EventArgs e)
        {
            m_AlbumOperator.RunPictureShower(PhotosAlbum, PhotosAlbum.Photos[0].ImageNormal, 0);
            m_AlbumOperator.PictureShower.PlaySlideShow();
        }

        private void postsButton_Click(object sender, EventArgs e)
        {
            PostsFormFacade postsFacade = new PostsFormFacade(new UserWithStatistic { User = FriendsFacade.Friend });
            PostsForm pf = new PostsForm(postsFacade);
            pf.Show();
        }
    }
}