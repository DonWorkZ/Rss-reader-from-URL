using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Model
{
    [XmlInclude(typeof(Avsnitt))]

    public abstract class Podcast
    {
        public string namn { get; set; }
        public int frekvens { get; set; }
        //public Kategori kategorier;
        public DateTime nastaUppdatering { get; set; }
        public double uppdateringsintervall { get; set; }

        public Podcast(string ettNamn, int enFrekvens, double uppdatering) 
        {
            namn = ettNamn;
            frekvens = enFrekvens;
            //kategori = kategori;
            uppdateringsintervall = uppdatering;
            uppdateringen();
        }

        public bool skaUppdateras()
        {
            return nastaUppdatering <= DateTime.Now;
        }

        public void uppdateringen()
        {
            nastaUppdatering = DateTime.Now.AddMinutes(uppdateringsintervall);
        }

        public abstract string Display();



    }
}
