using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DAL1
{
    [XmlInclude(typeof(Avsnitt))]

    public class Podcast
    {
        private string URL { get; set; }
        public int antalAvsnitt { get; set; }
        public string namn { get; set; }
        public int frekvens { get; set; }

        public string kategori { get; set; }

        public Podcast(string enURL, int antAvsnitt, string ettNamn, int enFrekvens, string enKategori) 
        {
            URL = enURL;
            antalAvsnitt = antAvsnitt;
            namn = ettNamn;
            frekvens = enFrekvens;
            kategori = enKategori;
        }

        public Podcast()
        {

        }

        public string URLn
        {
            get => URL;
            set => URL = value;
        }

        public int Avsnitt
        {
            get => antalAvsnitt;
            set => antalAvsnitt = value;
        }
        public string PodcastNamn
        {
            get => namn;
            set => namn = value;
        }

        public int Frekvensen 
        {
            get => frekvens;
            set => frekvens = value;
        }

        public string Kategorier
        {
            get => kategori;
            set => kategori = value;
        }


    }
}
