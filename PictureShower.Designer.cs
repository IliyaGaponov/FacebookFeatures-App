namespace DesktopFacebook
{
    partial class PictureShower
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
            this.currPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.likedByLabel = new System.Windows.Forms.Label();
            this.nextPhotoButton = new System.Windows.Forms.Button();
            this.prevPhotoButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.timerForSlideShow = new System.Windows.Forms.Timer(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currPictureBox
            // 
            this.currPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currPictureBox.Location = new System.Drawing.Point(0, 3);
            this.currPictureBox.Name = "currPictureBox";
            this.currPictureBox.Size = new System.Drawing.Size(493, 479);
            this.currPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.currPictureBox.TabIndex = 0;
            this.currPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.commentsListBox);
            this.panel1.Controls.Add(this.likedByLabel);
            this.panel1.Location = new System.Drawing.Point(493, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 483);
            this.panel1.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Aqua;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Coral;
            this.closeButton.Location = new System.Drawing.Point(239, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(33, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(191, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "____________________________";
            // 
            // commentsListBox
            // 
            this.commentsListBox.BackColor = System.Drawing.Color.Aqua;
            this.commentsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(15, 104);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(240, 52);
            this.commentsListBox.TabIndex = 1;
            // 
            // likedByLabel
            // 
            this.likedByLabel.AutoSize = true;
            this.likedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedByLabel.ForeColor = System.Drawing.Color.Aqua;
            this.likedByLabel.Location = new System.Drawing.Point(13, 27);
            this.likedByLabel.Name = "likedByLabel";
            this.likedByLabel.Size = new System.Drawing.Size(69, 17);
            this.likedByLabel.TabIndex = 0;
            this.likedByLabel.Text = "Liked by";
            // 
            // nextPhotoButton
            // 
            this.nextPhotoButton.BackColor = System.Drawing.Color.LightCoral;
            this.nextPhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextPhotoButton.FlatAppearance.BorderSize = 0;
            this.nextPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPhotoButton.ForeColor = System.Drawing.Color.Turquoise;
            this.nextPhotoButton.Location = new System.Drawing.Point(454, 223);
            this.nextPhotoButton.Name = "nextPhotoButton";
            this.nextPhotoButton.Size = new System.Drawing.Size(33, 23);
            this.nextPhotoButton.TabIndex = 2;
            this.nextPhotoButton.Text = ">";
            this.nextPhotoButton.UseVisualStyleBackColor = false;
            this.nextPhotoButton.Click += new System.EventHandler(this.nextPhotoButton_Click);
            // 
            // prevPhotoButton
            // 
            this.prevPhotoButton.BackColor = System.Drawing.Color.LightCoral;
            this.prevPhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.prevPhotoButton.FlatAppearance.BorderSize = 0;
            this.prevPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevPhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPhotoButton.ForeColor = System.Drawing.Color.Turquoise;
            this.prevPhotoButton.Location = new System.Drawing.Point(12, 223);
            this.prevPhotoButton.Name = "prevPhotoButton";
            this.prevPhotoButton.Size = new System.Drawing.Size(33, 23);
            this.prevPhotoButton.TabIndex = 3;
            this.prevPhotoButton.Text = "<";
            this.prevPhotoButton.UseVisualStyleBackColor = false;
            this.prevPhotoButton.Click += new System.EventHandler(this.prevPhotoButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightCoral;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Turquoise;
            this.playButton.Location = new System.Drawing.Point(231, 10);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 34);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // timerForSlideShow
            // 
            this.timerForSlideShow.Interval = 2000;
            this.timerForSlideShow.Tick += new System.EventHandler(this.timerForSlideShow_Tick);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Turquoise;
            this.stopButton.Location = new System.Drawing.Point(231, 10);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(50, 34);
            this.stopButton.TabIndex = 5;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // PictureShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 480);
            this.ControlBox = false;
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.prevPhotoButton);
            this.Controls.Add(this.nextPhotoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PictureShower";
            ((System.ComponentModel.ISupportInitialize)(this.currPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox currPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextPhotoButton;
        private System.Windows.Forms.Button prevPhotoButton;
        private System.Windows.Forms.Label likedByLabel;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Timer timerForSlideShow;
        private System.Windows.Forms.Button stopButton;
    }
}