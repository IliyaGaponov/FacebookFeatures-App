using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
    public static class UILogicHelper
    {
        public static void MakeControlsVisible(params Control[] io_Controls)
        {
            foreach(Control control in io_Controls)
            {
                control.Visible = true;
            }
        }

        public static void MakeControlsInvisible(params Control[] io_Controls)
        {
            foreach (Control control in io_Controls)
            {
                control.Visible = false;
            }
        }        
    }
}
