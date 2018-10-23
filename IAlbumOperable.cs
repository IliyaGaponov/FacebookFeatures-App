using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public interface IAlbumOperable
    {
        Panel PhotosPanel { get; set; }
        Album PhotosAlbum { get; set; }
        Label AlbumNameLabel { get; set; }
        ListBox ListBoxAlbums { get; set; }
        Button ButtonSlideshow { get; set; }
        FacebookObjectCollection<Album> UsersAlbums { get; set; }
    }
}
