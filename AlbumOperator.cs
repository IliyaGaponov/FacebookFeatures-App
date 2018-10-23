using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public class AlbumOperator
    {
        public PictureShower PictureShower { get; set; }        

        public void ShowAlbums(IAlbumOperable i_FormToFill, BindingSource io_AlbumBindingSource)
        {
            i_FormToFill.ListBoxAlbums.Invoke(new Action(
                () =>
                {
                    UILogicHelper.MakeControlsVisible(i_FormToFill.ListBoxAlbums);
                    i_FormToFill.ListBoxAlbums.BringToFront();
                    if (i_FormToFill.UsersAlbums.Count > 0)
                    {
                        io_AlbumBindingSource.DataSource = i_FormToFill.UsersAlbums;
                    }                    
                }));            
        }

        // Chosing album in listbox
        public void FillPanel(IAlbumOperable i_FormToFill)
        {
            UILogicHelper.MakeControlsInvisible(i_FormToFill.ListBoxAlbums);
            i_FormToFill.PhotosAlbum = i_FormToFill.UsersAlbums.ElementAt(i_FormToFill.ListBoxAlbums.SelectedIndex);
            fillPanelByPhotos(i_FormToFill);
            UILogicHelper.MakeControlsVisible(i_FormToFill.ButtonSlideshow);
        }

        private void fillPanelByPhotos(IAlbumOperable i_FormToFill)
        {
            int index = 0;
            LazyPictureBox[] albumPictureBoxes = new LazyPictureBox[i_FormToFill.PhotosAlbum.Photos.Count];
            double panelWidth = i_FormToFill.PhotosPanel.Width;
            int pictureWidth = (int)(panelWidth / 3);
            int pictureHeigt = pictureWidth;
            Point currPictureLocation = new Point(i_FormToFill.PhotosPanel.Location.X, i_FormToFill.PhotosPanel.Location.Y);

            i_FormToFill.PhotosPanel.Controls.Clear();
            UILogicHelper.MakeControlsVisible(i_FormToFill.PhotosPanel, i_FormToFill.AlbumNameLabel);            
            i_FormToFill.PhotosPanel.AutoScroll = true;
            i_FormToFill.AlbumNameLabel.Text = i_FormToFill.PhotosAlbum.Name;
            foreach (Photo photo in i_FormToFill.PhotosAlbum.Photos)
            {
                //check with static index: this for delete photoSerialNum  
                albumPictureBoxes[index] = new LazyPictureBox();
                int photoSerialNum = index;
                albumPictureBoxes[index].Click += (sender, e) => RunPictureShower(i_FormToFill.PhotosAlbum,
                    (sender as PictureBox).Image, photoSerialNum); 
                albumPictureBoxes[index].Location = currPictureLocation;
                albumPictureBoxes[index].Size = new Size(pictureWidth, pictureHeigt);
                albumPictureBoxes[index].SizeMode = PictureBoxSizeMode.StretchImage;
                i_FormToFill.PhotosPanel.Controls.Add(albumPictureBoxes[index]);
                currPictureLocation = new Point(currPictureLocation.X + pictureWidth, currPictureLocation.Y);
                index++;
                if ((index) % 3 == 0)
                {
                    currPictureLocation = new Point(i_FormToFill.PhotosPanel.Location.X, currPictureLocation.Y + pictureHeigt);
                }
            }

            index = 0;
            new Thread(() =>
            {
                foreach (Photo photo in i_FormToFill.PhotosAlbum.Photos)
                {
                    albumPictureBoxes[index++].Load(photo.PictureNormalURL);
                }
            }).Start();            
        }        

        // Run PictureShower form
        public void RunPictureShower(Album i_Album, Image i_Image, int i_PhotoIndex)
        {
            PictureShower = new PictureShower();

            PictureShower.Album = i_Album;
            PictureShower.CurrImg = i_Image;
            PictureShower.CurrPhotoIdx = i_PhotoIndex;
            PictureShower.Show();
        }        
    }
}
