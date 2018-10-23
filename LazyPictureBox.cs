using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public class LazyPictureBox : PictureBox
    {
        public string PictureURL { get; set; }

        public void Load(string i_URLToLoad)
        {
            PictureURL = i_URLToLoad;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (base.ImageLocation == null)
            {
                base.Load(PictureURL);
            }

            base.OnPaint(pe);
        }
    }
}
