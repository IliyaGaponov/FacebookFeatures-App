using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DesktopFacebook
{
    public class ApplicationSettings
    {
        private static ApplicationSettings s_Instance;
        private static readonly string sr_AppSettings;
        public static string s_PathToAudioFiles { get; }
        public Size LastWindowSize { get; set; }
        public FormWindowState LastWindowState { get; set; }
        public Point LastWindowLocation { get; set; }
        public string AccessToken { get; set; }
        public bool AutoLogin { get; set; }

        static ApplicationSettings()
        {
            sr_AppSettings = Application.ExecutablePath + ".settings.xml";
            s_PathToAudioFiles = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Audio";
        }

        private ApplicationSettings()
        {
            AutoLogin = false;
        }

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    FromFileOrDefault();
                }

                return s_Instance;
            }
        }

        public void SaveToFile()
        {
            using (FileStream stream = new FileStream(sr_AppSettings, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static ApplicationSettings FromFileOrDefault()
        {
            if (File.Exists(sr_AppSettings))
            {
                using (FileStream stream = new FileStream(sr_AppSettings, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    s_Instance = (ApplicationSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                s_Instance = new ApplicationSettings()
                {
                    LastWindowSize = new Size(800, 500),
                    LastWindowState = FormWindowState.Normal
                };
            }

            return s_Instance;
        }
    }
}