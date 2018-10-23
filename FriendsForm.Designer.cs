using System.Windows.Forms;

namespace DesktopFacebook
{
    partial class FriendsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxUserFriend = new System.Windows.Forms.PictureBox();
            this.buttonMutualFriends = new System.Windows.Forms.Button();
            this.labelFriendInfo = new System.Windows.Forms.Label();
            this.listBoxMutualFriends = new System.Windows.Forms.ListBox();
            this.buttonCommonGroups = new System.Windows.Forms.Button();
            this.listBoxCommonGroups = new System.Windows.Forms.ListBox();
            this.buttonPostToFriend = new System.Windows.Forms.Button();
            this.textBoxPostFriend = new System.Windows.Forms.TextBox();
            this.buttonFriendAlbums = new System.Windows.Forms.Button();
            this.listBoxFriendAlbums = new System.Windows.Forms.ListBox();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.buttonSlideshow = new System.Windows.Forms.Button();
            this.postsButton = new System.Windows.Forms.Button();
            this.forAlbumsListBoxLabel = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabel = new System.Windows.Forms.Label();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumLabel = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUserFriend
            // 
            this.pictureBoxUserFriend.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxUserFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserFriend.Name = "pictureBoxUserFriend";
            this.pictureBoxUserFriend.Size = new System.Drawing.Size(125, 126);
            this.pictureBoxUserFriend.TabIndex = 0;
            this.pictureBoxUserFriend.TabStop = false;
            // 
            // buttonMutualFriends
            // 
            this.buttonMutualFriends.Location = new System.Drawing.Point(12, 167);
            this.buttonMutualFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMutualFriends.Name = "buttonMutualFriends";
            this.buttonMutualFriends.Size = new System.Drawing.Size(125, 48);
            this.buttonMutualFriends.TabIndex = 2;
            this.buttonMutualFriends.Text = "Mutual Friends";
            this.buttonMutualFriends.UseVisualStyleBackColor = true;
            this.buttonMutualFriends.Click += new System.EventHandler(this.buttonMutualFriends_Click);
            // 
            // labelFriendInfo
            // 
            this.labelFriendInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendInfo.Location = new System.Drawing.Point(163, 12);
            this.labelFriendInfo.Name = "labelFriendInfo";
            this.labelFriendInfo.Size = new System.Drawing.Size(139, 153);
            this.labelFriendInfo.TabIndex = 3;
            this.labelFriendInfo.Text = "info";
            // 
            // listBoxMutualFriends
            // 
            this.listBoxMutualFriends.FormattingEnabled = true;
            this.listBoxMutualFriends.ItemHeight = 16;
            this.listBoxMutualFriends.Location = new System.Drawing.Point(147, 167);
            this.listBoxMutualFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxMutualFriends.Name = "listBoxMutualFriends";
            this.listBoxMutualFriends.Size = new System.Drawing.Size(129, 180);
            this.listBoxMutualFriends.TabIndex = 4;
            this.listBoxMutualFriends.Visible = false;
            // 
            // buttonCommonGroups
            // 
            this.buttonCommonGroups.Location = new System.Drawing.Point(12, 231);
            this.buttonCommonGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCommonGroups.Name = "buttonCommonGroups";
            this.buttonCommonGroups.Size = new System.Drawing.Size(125, 48);
            this.buttonCommonGroups.TabIndex = 5;
            this.buttonCommonGroups.Text = "Common Groups";
            this.buttonCommonGroups.UseVisualStyleBackColor = true;
            this.buttonCommonGroups.Click += new System.EventHandler(this.buttonCommonGroups_Click);
            // 
            // listBoxCommonGroups
            // 
            this.listBoxCommonGroups.FormattingEnabled = true;
            this.listBoxCommonGroups.ItemHeight = 16;
            this.listBoxCommonGroups.Location = new System.Drawing.Point(147, 231);
            this.listBoxCommonGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCommonGroups.Name = "listBoxCommonGroups";
            this.listBoxCommonGroups.Size = new System.Drawing.Size(129, 148);
            this.listBoxCommonGroups.TabIndex = 6;
            this.listBoxCommonGroups.Visible = false;
            // 
            // buttonPostToFriend
            // 
            this.buttonPostToFriend.Location = new System.Drawing.Point(12, 295);
            this.buttonPostToFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostToFriend.Name = "buttonPostToFriend";
            this.buttonPostToFriend.Size = new System.Drawing.Size(125, 48);
            this.buttonPostToFriend.TabIndex = 7;
            this.buttonPostToFriend.Text = "Post";
            this.buttonPostToFriend.UseVisualStyleBackColor = true;
            this.buttonPostToFriend.Click += new System.EventHandler(this.buttonPostToFriend_Click);
            // 
            // textBoxPostFriend
            // 
            this.textBoxPostFriend.Location = new System.Drawing.Point(147, 295);
            this.textBoxPostFriend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPostFriend.Multiline = true;
            this.textBoxPostFriend.Name = "textBoxPostFriend";
            this.textBoxPostFriend.Size = new System.Drawing.Size(187, 127);
            this.textBoxPostFriend.TabIndex = 8;
            this.textBoxPostFriend.Text = "Enter Your Post";
            this.textBoxPostFriend.Visible = false;
            this.textBoxPostFriend.Click += new System.EventHandler(this.textBoxPostFriend_Click);
            this.textBoxPostFriend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDownHandler);
            // 
            // buttonFriendAlbums
            // 
            this.buttonFriendAlbums.Location = new System.Drawing.Point(12, 359);
            this.buttonFriendAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriendAlbums.Name = "buttonFriendAlbums";
            this.buttonFriendAlbums.Size = new System.Drawing.Size(125, 48);
            this.buttonFriendAlbums.TabIndex = 9;
            this.buttonFriendAlbums.Text = "Albums";
            this.buttonFriendAlbums.UseVisualStyleBackColor = true;
            this.buttonFriendAlbums.Click += new System.EventHandler(this.buttonFriendAlbums_Click);
            // 
            // listBoxFriendAlbums
            // 
            this.listBoxFriendAlbums.DataSource = this.albumBindingSource;
            this.listBoxFriendAlbums.DisplayMember = "Name";
            this.listBoxFriendAlbums.FormattingEnabled = true;
            this.listBoxFriendAlbums.ItemHeight = 16;
            this.listBoxFriendAlbums.Location = new System.Drawing.Point(147, 359);
            this.listBoxFriendAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriendAlbums.Name = "listBoxFriendAlbums";
            this.listBoxFriendAlbums.Size = new System.Drawing.Size(187, 148);
            this.listBoxFriendAlbums.TabIndex = 10;
            this.listBoxFriendAlbums.Visible = false;
            this.listBoxFriendAlbums.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAlbums_MouseDoubleClick);
            // 
            // panelPhotos
            // 
            this.panelPhotos.AutoScroll = true;
            this.panelPhotos.Location = new System.Drawing.Point(138, 50);
            this.panelPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelPhotos.Size = new System.Drawing.Size(568, 469);
            this.panelPhotos.TabIndex = 19;
            this.panelPhotos.Visible = false;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbumName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAlbumName.Location = new System.Drawing.Point(143, 9);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(461, 47);
            this.labelAlbumName.TabIndex = 20;
            this.labelAlbumName.Text = "Album Name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAlbumName.Visible = false;
            // 
            // buttonSlideshow
            // 
            this.buttonSlideshow.Location = new System.Drawing.Point(611, 14);
            this.buttonSlideshow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSlideshow.Name = "buttonSlideshow";
            this.buttonSlideshow.Size = new System.Drawing.Size(95, 34);
            this.buttonSlideshow.TabIndex = 21;
            this.buttonSlideshow.Text = "Slideshow";
            this.buttonSlideshow.UseVisualStyleBackColor = true;
            this.buttonSlideshow.Visible = false;
            this.buttonSlideshow.Click += new System.EventHandler(this.buttonSlideshow_Click);
            // 
            // postsButton
            // 
            this.postsButton.Location = new System.Drawing.Point(12, 426);
            this.postsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsButton.Name = "postsButton";
            this.postsButton.Size = new System.Drawing.Size(125, 48);
            this.postsButton.TabIndex = 22;
            this.postsButton.Text = "Posts";
            this.postsButton.UseVisualStyleBackColor = true;
            this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
            // 
            // ForAlbumsListBoxLabel
            // 
            this.forAlbumsListBoxLabel.AutoSize = true;
            this.forAlbumsListBoxLabel.Location = new System.Drawing.Point(144, 341);
            this.forAlbumsListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forAlbumsListBoxLabel.Name = "ForAlbumsListBoxLabel";
            this.forAlbumsListBoxLabel.Size = new System.Drawing.Size(531, 17);
            this.forAlbumsListBoxLabel.TabIndex = 25;
            this.forAlbumsListBoxLabel.Text = "Press double click on the album to show it. Single click - to show the album\'s de" +
    "tails";
            this.forAlbumsListBoxLabel.Visible = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeLabel
            // 
            this.createdTimeLabel.AutoSize = true;
            this.createdTimeLabel.Location = new System.Drawing.Point(372, 390);
            this.createdTimeLabel.Name = "createdTimeLabel";
            this.createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            this.createdTimeLabel.TabIndex = 26;
            this.createdTimeLabel.Text = "Created Time:";
            this.createdTimeLabel.Visible = false;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(475, 390);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 27;
            this.createdTimeLabel1.Text = "label1";
            this.createdTimeLabel1.Visible = false;
            // 
            // imageAlbumLabel
            // 
            this.imageAlbumLabel.AutoSize = true;
            this.imageAlbumLabel.Location = new System.Drawing.Point(372, 416);
            this.imageAlbumLabel.Name = "imageAlbumLabel";
            this.imageAlbumLabel.Size = new System.Drawing.Size(93, 17);
            this.imageAlbumLabel.TabIndex = 28;
            this.imageAlbumLabel.Text = "Image Album:";
            this.imageAlbumLabel.Visible = false;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(475, 416);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(100, 50);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 29;
            this.imageAlbumPictureBox.TabStop = false;
            this.imageAlbumPictureBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(372, 469);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(475, 469);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 31;
            this.nameLabel1.Text = "label1";
            this.nameLabel1.Visible = false;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(this.imageAlbumLabel);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.forAlbumsListBoxLabel);
            this.Controls.Add(this.postsButton);
            this.Controls.Add(this.buttonSlideshow);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.panelPhotos);
            this.Controls.Add(this.listBoxFriendAlbums);
            this.Controls.Add(this.buttonFriendAlbums);
            this.Controls.Add(this.textBoxPostFriend);
            this.Controls.Add(this.buttonPostToFriend);
            this.Controls.Add(this.listBoxCommonGroups);
            this.Controls.Add(this.buttonCommonGroups);
            this.Controls.Add(this.listBoxMutualFriends);
            this.Controls.Add(this.labelFriendInfo);
            this.Controls.Add(this.buttonMutualFriends);
            this.Controls.Add(this.pictureBoxUserFriend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FriendsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUserFriend;
        private System.Windows.Forms.Button buttonMutualFriends;
        private System.Windows.Forms.Label labelFriendInfo;
        private System.Windows.Forms.ListBox listBoxMutualFriends;
        private System.Windows.Forms.Button buttonCommonGroups;
        private System.Windows.Forms.ListBox listBoxCommonGroups;
        private System.Windows.Forms.Button buttonPostToFriend;
        private System.Windows.Forms.TextBox textBoxPostFriend;
        private System.Windows.Forms.Button buttonFriendAlbums;
        private System.Windows.Forms.ListBox listBoxFriendAlbums;
        private System.Windows.Forms.Panel panelPhotos;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Button buttonSlideshow;
        private System.Windows.Forms.Button postsButton;
        private Label forAlbumsListBoxLabel;
        private BindingSource albumBindingSource;
        private Label createdTimeLabel;
        private Label createdTimeLabel1;
        private Label imageAlbumLabel;
        private PictureBox imageAlbumPictureBox;
        private Label nameLabel;
        private Label nameLabel1;
    }
}