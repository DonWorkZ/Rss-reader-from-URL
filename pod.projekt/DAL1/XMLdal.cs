using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DAL1
{
    public class XMLdal
    {
        public static void sparaListaKategorier()
        { 

                if (File.Exists("kategori"))
                {
                    File.Delete("kategori");
                }
                using (Stream fil = File.OpenWrite(Environment.CurrentDirectory + "\\kategori"))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Kategori>));
                    ser.Serialize(fil, ListaKategorier.hamtaKategoriLista());
                    fil.Close();
                }

        }

        public static List<Kategori> getListaCategorier()
        {
            List<Kategori> category_list = new List<Kategori>();

            if(!File.Exists("Kategori"))
            {
                return category_list;
            }

            using (Stream fil = File.OpenRead(Environment.CurrentDirectory + "\\Kategori"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Kategori>));
                category_list = (List<Kategori>)ser.Deserialize(fil);
            }
            return category_list;
        }

        public static void savepodcast()
        {
            if(File.Exists("podcast"))
            {
                File.Delete("podcast");
            }

            using (Stream file = File.OpenWrite(Environment.CurrentDirectory + "\\podcast"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Podcast>));
                ser.Serialize(file, ListaPodcasts.returaPodcastLista());
            }
        }

        public static List<Podcast> getpodcast()
        {
            List<Podcast> podcastlist = new List<Podcast>();

            if(!File.Exists("podcast"))
            {
                return podcastlist;
            }

            using (Stream file = File.OpenRead(Environment.CurrentDirectory + "//podcast"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Podcast>));
                podcastlist = (List<Podcast>)ser.Deserialize(file);
            }

            return podcastlist;
        }
    }
}

