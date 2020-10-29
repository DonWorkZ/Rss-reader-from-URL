using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL1
{
    public class Kategori
    {
        public string kategorier { get; set; }

        public Kategori(string kategori)
        {
            kategorier = kategori;
        }

        public Kategori()
        {

        }

        public string KTitel
        {
            get => kategorier;
            set => kategorier = value;
        }
    }
    
}
