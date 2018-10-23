using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ THE-001 (-14) your grade on diagrams document - 86 please see comments inside the document. (40% of your grade).

namespace DesktopFacebook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacebookFeatures());
        }
    }
}
