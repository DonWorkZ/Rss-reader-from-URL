using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace pod.projekt
{
    [XmlInclude(typeof(Avsnitt))]

    public abstract class Podcast
    {
        public string namn { get; set; }
        public int frekvens { get; set; }
        //public Kategori kategorier;

        public Podcast(string ettNamn, int enFrekvens) 
        {
            namn = ettNamn;
            frekvens = enFrekvens;
            //kategori = kategori;
        }

        public abstract string Display();



    }
}
