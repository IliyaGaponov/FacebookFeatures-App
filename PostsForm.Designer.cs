namespace DesktopFacebook
{
    partial class PostsForm
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
            this.likesStatisticPanel = new System.Windows.Forms.Panel();
            this.likersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commentsStatisticPanel = new System.Windows.Forms.Panel();
            this.commentatorsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.likesStatisticPanel.SuspendLayout();
            this.commentsStatisticPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // likesStatisticPanel
            // 
            this.likesStatisticPanel.AutoScroll = true;
            this.likesStatisticPanel.Controls.Add(this.likersListBox);
            this.likesStatisticPanel.Controls.Add(this.label2);
            this.likesStatisticPanel.Controls.Add(this.label1);
            this.likesStatisticPanel.Location = new System.Drawing.Point(554, 12);
            this.likesStatisticPanel.Name = "likesStatisticPanel";
            this.likesStatisticPanel.Size = new System.Drawing.Size(281, 262);
            this.likesStatisticPanel.TabIndex = 1;
            // 
            // likersListBox
            // 
            this.likersListBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.likersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.likersListBox.FormattingEnabled = true;
            this.likersListBox.Location = new System.Drawing.Point(16, 48);
            this.likersListBox.Name = "likersListBox";
            this.likersListBox.Size = new System.Drawing.Size(262, 208);
            this.likersListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "___________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Likers";
            // 
            // commentsStatisticPanel
            // 
            this.commentsStatisticPanel.AutoScroll = true;
            this.commentsStatisticPanel.Controls.Add(this.commentatorsListBox);
            this.commentsStatisticPanel.Controls.Add(this.label3);
            this.commentsStatisticPanel.Controls.Add(this.label4);
            this.commentsStatisticPanel.Location = new System.Drawing.Point(554, 279);
            this.commentsStatisticPanel.Name = "commentsStatisticPanel";
            this.commentsStatisticPanel.Size = new System.Drawing.Size(281, 262);
            this.commentsStatisticPanel.TabIndex = 2;
            // 
            // commentatorsListBox
            // 
            this.commentatorsListBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.commentatorsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentatorsListBox.FormattingEnabled = true;
            this.commentatorsListBox.Location = new System.Drawing.Point(16, 51);
            this.commentatorsListBox.Name = "commentatorsListBox";
            this.commentatorsListBox.Size = new System.Drawing.Size(262, 208);
            this.commentatorsListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "___________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Top Commentators";
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(252, 224);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(54, 13);
            this.loadingLabel.TabIndex = 3;
            this.loadingLabel.Text = "Loading...";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 538);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.commentsStatisticPanel);
            this.Controls.Add(this.likesStatisticPanel);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.likesStatisticPanel.ResumeLayout(false);
            this.likesStatisticPanel.PerformLayout();
            this.commentsStatisticPanel.ResumeLayout(false);
            this.commentsStatisticPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel likesStatisticPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel commentsStatisticPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox likersListBox;
        private System.Windows.Forms.ListBox commentatorsListBox;
        private System.Windows.Forms.Label loadingLabel;
    }
}