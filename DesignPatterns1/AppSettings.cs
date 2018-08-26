using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns1
{
    public class AppSettings
    {
        public Point LastWindowLocation{ get; set; }
        public Size LastWindowSize { get; set; }
        public bool RememberUser{ get; set; }
        public string LastAccessToke{ get; set; }


        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;
            if (File.Exists(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"C:\Users\user\Documents\Visual Studio 2015\Projects\DesignPatterns1\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    Object obj = serializer.Deserialize(stream);
                    appSettings = obj as AppSettings;
                }
            }

            return appSettings;
        }

        
    }

}
