using System.Windows.Forms;

namespace DesktopFacebook
{
    partial class FacebookFeatures
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
            this.createdTimeLabel = new System.Windows.Forms.Label();
            this.imageAlbumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelHelloUser = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonShowFriends = new System.Windows.Forms.Button();
            this.listBoxMyPosts = new System.Windows.Forms.ListBox();
            this.buttonMyPosts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonMakePost = new System.Windows.Forms.Button();
            this.pictureBoxLargeFoto = new System.Windows.Forms.PictureBox();
            this.buttonClosePicture = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePost = new System.Windows.Forms.TextBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.buttonSlideshow = new System.Windows.Forms.Button();
            this.forAlbumsListBoxLabel = new System.Windows.Forms.Label();
            this.forFriendsListBoxLabel = new System.Windows.Forms.Label();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargeFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            this.createdTimeLabel.AutoSize = true;
            this.createdTimeLabel.Location = new System.Drawing.Point(625, 367);
            this.createdTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdTimeLabel.Name = "createdTimeLabel";
            this.createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            this.createdTimeLabel.TabIndex = 26;
            this.createdTimeLabel.Text = "Created Time:";
            this.createdTimeLabel.Visible = false;
            // 
            // imageAlbumLabel
            // 
            this.imageAlbumLabel.AutoSize = true;
            this.imageAlbumLabel.Location = new System.Drawing.Point(625, 399);
            this.imageAlbumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageAlbumLabel.Name = "imageAlbumLabel";
            this.imageAlbumLabel.Size = new System.Drawing.Size(71, 13);
            this.imageAlbumLabel.TabIndex = 28;
            this.imageAlbumLabel.Text = "Image Album:";
            this.imageAlbumLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(625, 492);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gold;
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonLogin.Location = new System.Drawing.Point(40, 13);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(133, 48);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Location = new System.Drawing.Point(40, 108);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(133, 122);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Visible = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // labelHelloUser
            // 
            this.labelHelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHelloUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHelloUser.Location = new System.Drawing.Point(3, 52);
            this.labelHelloUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHelloUser.Name = "labelHelloUser";
            this.labelHelloUser.Size = new System.Drawing.Size(200, 52);
            this.labelHelloUser.TabIndex = 3;
            this.labelHelloUser.Text = "Hello";
            this.labelHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHelloUser.Visible = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gold;
            this.buttonLogout.Location = new System.Drawing.Point(40, 13);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(133, 48);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(212, 306);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(256, 212);
            this.listBoxFriends.TabIndex = 5;
            this.listBoxFriends.Visible = false;
            this.listBoxFriends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFriends_MouseDoubleClick);
            // 
            // buttonShowFriends
            // 
            this.buttonShowFriends.Location = new System.Drawing.Point(7, 308);
            this.buttonShowFriends.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowFriends.Name = "buttonShowFriends";
            this.buttonShowFriends.Size = new System.Drawing.Size(193, 53);
            this.buttonShowFriends.TabIndex = 6;
            this.buttonShowFriends.Text = "Friends";
            this.buttonShowFriends.UseVisualStyleBackColor = true;
            this.buttonShowFriends.Visible = false;
            this.buttonShowFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxMyPosts
            // 
            this.listBoxMyPosts.FormattingEnabled = true;
            this.listBoxMyPosts.Location = new System.Drawing.Point(212, 244);
            this.listBoxMyPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMyPosts.Name = "listBoxMyPosts";
            this.listBoxMyPosts.Size = new System.Drawing.Size(308, 264);
            this.listBoxMyPosts.TabIndex = 7;
            this.listBoxMyPosts.Visible = false;
            // 
            // buttonMyPosts
            // 
            this.buttonMyPosts.Location = new System.Drawing.Point(7, 245);
            this.buttonMyPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMyPosts.Name = "buttonMyPosts";
            this.buttonMyPosts.Size = new System.Drawing.Size(193, 55);
            this.buttonMyPosts.TabIndex = 8;
            this.buttonMyPosts.Text = "Posts";
            this.buttonMyPosts.UseVisualStyleBackColor = true;
            this.buttonMyPosts.Visible = false;
            this.buttonMyPosts.Click += new System.EventHandler(this.buttonMyPosts_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.buttonAlbums);
            this.panel1.Controls.Add(this.buttonMakePost);
            this.panel1.Controls.Add(this.buttonShowFriends);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.buttonMyPosts);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.labelHelloUser);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 615);
            this.panel1.TabIndex = 11;
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Location = new System.Drawing.Point(7, 368);
            this.buttonAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(193, 54);
            this.buttonAlbums.TabIndex = 10;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Visible = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonMakePost
            // 
            this.buttonMakePost.Location = new System.Drawing.Point(7, 429);
            this.buttonMakePost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMakePost.Name = "buttonMakePost";
            this.buttonMakePost.Size = new System.Drawing.Size(193, 54);
            this.buttonMakePost.TabIndex = 9;
            this.buttonMakePost.Text = "Make a Post On My Timeline";
            this.buttonMakePost.UseVisualStyleBackColor = true;
            this.buttonMakePost.Visible = false;
            this.buttonMakePost.Click += new System.EventHandler(this.buttonMakePost_Click);
            // 
            // pictureBoxLargeFoto
            // 
            this.pictureBoxLargeFoto.Location = new System.Drawing.Point(205, 62);
            this.pictureBoxLargeFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLargeFoto.Name = "pictureBoxLargeFoto";
            this.pictureBoxLargeFoto.Size = new System.Drawing.Size(263, 223);
            this.pictureBoxLargeFoto.TabIndex = 12;
            this.pictureBoxLargeFoto.TabStop = false;
            this.pictureBoxLargeFoto.Visible = false;
            this.pictureBoxLargeFoto.Click += new System.EventHandler(this.pictureBoxLargeFoto_Click);
            // 
            // buttonClosePicture
            // 
            this.buttonClosePicture.BackColor = System.Drawing.Color.Red;
            this.buttonClosePicture.Location = new System.Drawing.Point(433, -1);
            this.buttonClosePicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClosePicture.Name = "buttonClosePicture";
            this.buttonClosePicture.Size = new System.Drawing.Size(35, 28);
            this.buttonClosePicture.TabIndex = 13;
            this.buttonClosePicture.Text = "X";
            this.buttonClosePicture.UseVisualStyleBackColor = false;
            this.buttonClosePicture.Visible = false;
            this.buttonClosePicture.Click += new System.EventHandler(this.buttonClosePicture_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPost.Location = new System.Drawing.Point(208, 245);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(293, 150);
            this.textBoxPost.TabIndex = 14;
            this.textBoxPost.Text = "Enter your post";
            this.textBoxPost.Visible = false;
            this.textBoxPost.Click += new System.EventHandler(this.textBoxPost_Click);
            this.textBoxPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDownHandler);
            // 
            // textBoxUpdatePost
            // 
            this.textBoxUpdatePost.Location = new System.Drawing.Point(205, 351);
            this.textBoxUpdatePost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUpdatePost.Multiline = true;
            this.textBoxUpdatePost.Name = "textBoxUpdatePost";
            this.textBoxUpdatePost.Size = new System.Drawing.Size(315, 192);
            this.textBoxUpdatePost.TabIndex = 15;
            this.textBoxUpdatePost.Visible = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(213, 334);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(220, 173);
            this.listBoxAlbums.TabIndex = 16;
            this.listBoxAlbums.Visible = false;
            this.listBoxAlbums.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAlbums_MouseDoubleClick);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // panelPhotos
            // 
            this.panelPhotos.AutoScroll = true;
            this.panelPhotos.Location = new System.Drawing.Point(205, 81);
            this.panelPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelPhotos.Size = new System.Drawing.Size(668, 603);
            this.panelPhotos.TabIndex = 18;
            this.panelPhotos.Visible = false;
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbumName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlbumName.Location = new System.Drawing.Point(212, 31);
            this.labelAlbumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(126, 22);
            this.labelAlbumName.TabIndex = 19;
            this.labelAlbumName.Text = "Album Name";
            this.labelAlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAlbumName.Visible = false;
            // 
            // buttonSlideshow
            // 
            this.buttonSlideshow.Location = new System.Drawing.Point(737, 31);
            this.buttonSlideshow.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSlideshow.Name = "buttonSlideshow";
            this.buttonSlideshow.Size = new System.Drawing.Size(127, 43);
            this.buttonSlideshow.TabIndex = 22;
            this.buttonSlideshow.Text = "Slideshow";
            this.buttonSlideshow.UseVisualStyleBackColor = true;
            this.buttonSlideshow.Visible = false;
            this.buttonSlideshow.Click += new System.EventHandler(this.buttonSlideshow_Click);
            // 
            // forAlbumsListBoxLabel
            // 
            this.forAlbumsListBoxLabel.AutoSize = true;
            this.forAlbumsListBoxLabel.Location = new System.Drawing.Point(213, 317);
            this.forAlbumsListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forAlbumsListBoxLabel.Name = "forAlbumsListBoxLabel";
            this.forAlbumsListBoxLabel.Size = new System.Drawing.Size(400, 13);
            this.forAlbumsListBoxLabel.TabIndex = 23;
            this.forAlbumsListBoxLabel.Text = "Press double click on the album to show it. Single click - to show the album\'s de" +
    "tails";
            this.forAlbumsListBoxLabel.Visible = false;
            // 
            // forFriendsListBoxLabel
            // 
            this.forFriendsListBoxLabel.AutoSize = true;
            this.forFriendsListBoxLabel.Location = new System.Drawing.Point(213, 228);
            this.forFriendsListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forFriendsListBoxLabel.Name = "forFriendsListBoxLabel";
            this.forFriendsListBoxLabel.Size = new System.Drawing.Size(241, 13);
            this.forFriendsListBoxLabel.TabIndex = 24;
            this.forFriendsListBoxLabel.Text = "Press double click on the friend to show his page.";
            this.forFriendsListBoxLabel.Visible = false;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(731, 367);
            this.createdTimeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(133, 28);
            this.createdTimeLabel1.TabIndex = 27;
            this.createdTimeLabel1.Visible = false;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.BackColor = System.Drawing.Color.LightCoral;
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(731, 399);
            this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(133, 89);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 29;
            this.imageAlbumPictureBox.TabStop = false;
            this.imageAlbumPictureBox.Visible = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(731, 492);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(133, 28);
            this.nameLabel1.TabIndex = 31;
            this.nameLabel1.Visible = false;
            // 
            // FacebookFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(876, 611);
            this.Controls.Add(this.pictureBoxLargeFoto);
            this.Controls.Add(this.createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(this.imageAlbumLabel);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.panelPhotos);
            this.Controls.Add(this.forFriendsListBoxLabel);
            this.Controls.Add(this.forAlbumsListBoxLabel);
            this.Controls.Add(this.buttonSlideshow);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.textBoxUpdatePost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.buttonClosePicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxMyPosts);
            this.Controls.Add(this.listBoxFriends);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookFeatures";
            this.Text = "FacebookFeatures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLargeFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelHelloUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonShowFriends;
        private System.Windows.Forms.ListBox listBoxMyPosts;
        private System.Windows.Forms.Button buttonMyPosts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLargeFoto;
        private System.Windows.Forms.Button buttonClosePicture;
        private Button buttonMakePost;
        private TextBox textBoxPost;
        private TextBox textBoxUpdatePost;
        private Button buttonAlbums;
        private ListBox listBoxAlbums;
        private Panel panelPhotos;
        private Label labelAlbumName;
        private Button buttonSlideshow;
        private Label forAlbumsListBoxLabel;
        private Label forFriendsListBoxLabel;
        private BindingSource albumBindingSource;
        private Label createdTimeLabel1;
        private PictureBox imageAlbumPictureBox;
        private Label nameLabel1;
        private Label createdTimeLabel;
        private Label imageAlbumLabel;
        private Label nameLabel;
    }
}