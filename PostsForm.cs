using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public partial class PostsForm : Form
    {
        private readonly int r_PostPanelWidth;
        private int m_PostPanelStartingHeight;
        private int m_CurrPostPanelLocationX;
        private int m_CurrPostPanelLocationY;
        private static readonly int sr_SingleControlDimension = 35;
        private static readonly int sr_PostPictureDimension = 150;
        private static readonly int sr_CommentListBoxHeight = 60;
        public PostsFormFacade PostsFormFacade { get; set; }

        public PostsForm(PostsFormFacade i_PostsFormFacade)
        {
            InitializeComponent();
            PostsFormFacade = i_PostsFormFacade;
            m_PostPanelStartingHeight = 25;
            r_PostPanelWidth = this.likesStatisticPanel.Location.X - 40;
            m_CurrPostPanelLocationX = this.Location.X + 10;
            m_CurrPostPanelLocationY = this.Location.Y + 10;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(() =>
            {
                PostsWithStatistic posts = PostsFormFacade.GetPosts();
                fillPostPanel(posts.Posts);
                fillStatisticPanel(posts.ActiveLikers, posts.ActiveCommentators);
            }).Start();
        }

        private void fillStatisticPanel(List<ActiveLiker> i_ActiveLikerList, List<ActiveCommentator> i_ActiveCommentatorList)
        {
            foreach (ActiveLiker user in i_ActiveLikerList)
            {
                addToListBox(likersListBox, user.NumOfLikes, user.UserName);
            }

            foreach (ActiveCommentator user in i_ActiveCommentatorList)
            {
                addToListBox(commentatorsListBox, user.NumOfComments, user.UserName);
            }
        }

        private void addToListBox(ListBox i_ListBox, int i_NumberOf, string i_UserName)
        {
            if (i_NumberOf > 0)
            {
                string itemToAdd = i_UserName + " - " + i_NumberOf;
                i_ListBox.Invoke(new Action(() => i_ListBox.Items.Add(itemToAdd)));
            }
        }

        private void fillPostPanel(FacebookObjectCollection<Post> i_Posts)
        {
            loadingLabel.Invoke(new Action(() => UILogicHelper.MakeControlsInvisible(loadingLabel)));
            foreach (Post post in i_Posts)
            {
                if (post != null)
                {
                    Panel panel = generatePostPanel();
                    addPostComponentsToPanel(panel, post.Comments, post.CreatedTime, post.From, post.LikedBy, post.Message,
                      post.PictureURL, post.Place, post.TaggedUsers);
                    m_CurrPostPanelLocationY += panel.Height + 15;
                    this.Invoke(new Action(() => this.Controls.Add(panel)));
                }
            }
        }

        private Panel generatePostPanel()
        {
            Panel panel = new Panel();

            panel.Size = new Size(r_PostPanelWidth, m_PostPanelStartingHeight);
            panel.Location = new Point(m_CurrPostPanelLocationX, m_CurrPostPanelLocationY);
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.FixedSingle;

            return panel;
        }

        private void addPostComponentsToPanel(Panel io_Panel, FacebookObjectCollection<Comment> i_Comments, DateTime? i_CreatedTime,
            User i_From, FacebookObjectCollection<User> i_LikedBy, string i_Message, string i_PictureURL, Page i_Place,
            FacebookObjectCollection<User> i_TaggedUsers)
        {
            int currLocationY = io_Panel.Location.Y + 2;

            if (i_From != null)
            {
                //senderPictureBox creation
                PictureBox senderPictureBox = createAndFillPictBox(i_From.PictureSmallURL);
                addControlToPanel(io_Panel, senderPictureBox, sr_SingleControlDimension, sr_SingleControlDimension, io_Panel.Location.X + 2,
                    currLocationY, sr_SingleControlDimension);
                //senderNameLabel creation
                Label senderNameLabel = createLabel(i_From.Name, Color.Black);
                addControlToPanel(io_Panel, senderNameLabel, 60, sr_SingleControlDimension,
                  senderPictureBox.Location.X + senderPictureBox.Width + 5, currLocationY, 0);
                //createdTimeLabel creation
                Label createdTimeLabel = createLabel("Created at " + i_CreatedTime.Value, Color.Black);
                addControlToPanel(io_Panel, createdTimeLabel, 60, sr_SingleControlDimension, io_Panel.Width + io_Panel.Location.X - 80,
                  currLocationY, 0);
                currLocationY += sr_SingleControlDimension + 2;
                //placeText creation
                if (i_TaggedUsers != null && i_TaggedUsers.Count > 0)
                {
                    String placeText = "With " + i_TaggedUsers.ElementAt(0) + "and " + (i_TaggedUsers.Count - 1) + " others";
                    Label tagsLabel = createLabel(placeText, Color.CornflowerBlue);
                    addControlToPanel(io_Panel, tagsLabel, r_PostPanelWidth - 10, sr_SingleControlDimension, io_Panel.Location.X + 2,
                        currLocationY, sr_SingleControlDimension);
                    currLocationY += sr_SingleControlDimension;
                }

                if (i_Place != null)
                {
                    Label placeLabel = createLabel("Here: " + i_Place.Name, Color.Black);
                    addControlToPanel(io_Panel, placeLabel, r_PostPanelWidth - 10, sr_SingleControlDimension, io_Panel.Location.X + 2,
                       currLocationY, sr_SingleControlDimension);
                    currLocationY += sr_SingleControlDimension;
                }

                Label delimiterLabel = createLabel("_____________________________________________", Color.Black);
                delimiterLabel.TextAlign = ContentAlignment.MiddleCenter;
                addControlToPanel(io_Panel, delimiterLabel, r_PostPanelWidth - 10, sr_SingleControlDimension, io_Panel.Location.X + 2,
                    currLocationY, sr_SingleControlDimension);
                currLocationY += sr_SingleControlDimension;
            }

            Label msgLabel = createLabel(i_Message, Color.Black);
            addControlToPanel(io_Panel, msgLabel, r_PostPanelWidth - 10, sr_SingleControlDimension, io_Panel.Location.X + 2,
                currLocationY, sr_SingleControlDimension);
            currLocationY += sr_SingleControlDimension;

            if (i_PictureURL != null)
            {
                PictureBox contentPictBox = createAndFillPictBox(i_PictureURL);
                int contentPictBoxLocX = (int)io_Panel.Location.X + r_PostPanelWidth / 2 - sr_PostPictureDimension / 2;
                addControlToPanel(io_Panel, contentPictBox, sr_PostPictureDimension, sr_PostPictureDimension, contentPictBoxLocX,
                 currLocationY, sr_PostPictureDimension);
                currLocationY += sr_PostPictureDimension + sr_SingleControlDimension;
            }

            if (i_Comments != null)
            {
                ListBox commentsListBox = new ListBox();
                fillCommentsListBox(commentsListBox, i_Comments);
                addControlToPanel(io_Panel, commentsListBox, r_PostPanelWidth - 30, sr_CommentListBoxHeight, io_Panel.Location.X + 15,
                   currLocationY, sr_PostPictureDimension);
                currLocationY += sr_CommentListBoxHeight;
            }

            if (i_LikedBy != null)
            {
                Label likesLabel = createLabel("Likes:" + i_LikedBy.Count, Color.Black);
                likesLabel.TextAlign = ContentAlignment.MiddleCenter;
                int labelLocationY = io_Panel.Location.Y + io_Panel.Height - sr_SingleControlDimension - 10;
                addControlToPanel(io_Panel, likesLabel, r_PostPanelWidth - 10, sr_SingleControlDimension, io_Panel.Location.X + 2,
                  labelLocationY, 0);
            }
        }

        private void fillCommentsListBox(ListBox io_CommentsListBox, FacebookObjectCollection<Comment> i_Comments)
        {
            foreach (Comment comment in i_Comments)
            {
                if (comment.Message != null && comment.From != null)
                {
                    io_CommentsListBox.Items.Add(comment.From.Name + ": " + comment.Message);
                }
            }
        }

        private LazyPictureBox createAndFillPictBox(string i_PictureURL)
        {
            LazyPictureBox pictBox = new LazyPictureBox();

            pictBox.Load(i_PictureURL);
            pictBox.SizeMode = PictureBoxSizeMode.StretchImage;

            return pictBox;
        }

        private Label createLabel(string i_Text, Color i_Color)
        {
            Label label = new Label();

            if (i_Text != null)
            {
                label.Text = i_Text;
            }

            label.ForeColor = i_Color;

            return label;
        }

        private void addControlToPanel(Panel io_Panel, Control i_Control, int i_ControlWidth, int i_ControlHeight,
            int i_ControlLocationX, int i_ControlLocationY, int i_PanelHeightToGrowPx)
        {
            i_Control.Size = new Size(i_ControlWidth, i_ControlHeight);
            i_Control.Location = new Point(i_ControlLocationX, i_ControlLocationY);
            io_Panel.Height += i_PanelHeightToGrowPx;
            this.Invoke(new Action(() =>
            {
                this.Controls.Add(i_Control);
                i_Control.BringToFront();
            }));
        }
    }
}
