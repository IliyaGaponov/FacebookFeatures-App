using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public partial class PictureShower : Form
    {
        public Album Album { get; set; }
        public Image CurrImg { get; set; }
        public int CurrPhotoIdx { get; set; }
        private SoundPlayer m_AudioPlayer;

        public PictureShower()
        {
            m_AudioPlayer = new SoundPlayer();
            m_AudioPlayer.SoundLocation = ApplicationSettings.s_PathToAudioFiles + "\\audio.wav";
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            setPhotoDetails(Album.Photos[CurrPhotoIdx]);
            playButton.BringToFront();
        }

        private void nextPhotoButton_Click(object sender, EventArgs e)
        {
            setNextPhoto();
        }

        private void setNextPhoto()
        {
            if (CurrPhotoIdx + 1 < Album.Photos.Count)
            {
                CurrPhotoIdx++;
            }
            else
            {
                CurrPhotoIdx = 0;
            }

            setPhotoDetails(Album.Photos[CurrPhotoIdx]);
        }

        private void prevPhotoButton_Click(object sender, EventArgs e)
        {
            setPrevPhoto();
        }

        private void setPrevPhoto()
        {
            if (CurrPhotoIdx > 0)
            {
                CurrPhotoIdx--;
            }
            else
            {
                CurrPhotoIdx = Album.Photos.Count - 1;
            }

            setPhotoDetails(Album.Photos[CurrPhotoIdx]);
        }

        private void setPhotoDetails(Photo i_photo)
        {
            clearComponents();
            currPictureBox.Image = i_photo.ImageNormal;
            likedByLabel.Text = "Liked by " + i_photo.LikedBy.Count + " people";
            foreach (Comment comment in i_photo.Comments)
            {
                commentsListBox.Items.Add(comment.From.FirstName + " " + comment.From.LastName + " : " + comment.Message);
                commentsListBox.Height += 15;
            }
        }

        private void clearComponents()
        {
            likedByLabel.Text = null;
            commentsListBox.Items.Clear();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            stopSlideShow();
            this.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            PlaySlideShow();
        }

        public void PlaySlideShow()
        {
            UILogicHelper.MakeControlsVisible(stopButton);
            UILogicHelper.MakeControlsInvisible(playButton);
            timerForSlideShow.Enabled = true;
            m_AudioPlayer.Play();
        }

        private void timerForSlideShow_Tick(object sender, EventArgs e)
        {
            setNextPhoto();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopSlideShow();
        }

        private void stopSlideShow()
        {
            UILogicHelper.MakeControlsVisible(playButton);
            UILogicHelper.MakeControlsInvisible(stopButton);
            timerForSlideShow.Enabled = false;
            m_AudioPlayer.Stop();
        }
    }
}