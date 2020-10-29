using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    public class ListaKategorier
    {
            private static List<Kategori> kategoriLista { get; set; }

            public ListaKategorier()
            {
                kategoriLista = XMLdal.getListaCategorier();
            }

            public static void laggTillKategori(Kategori kategori)
            {
                kategoriLista.Add(kategori);
            }

            public static List<Kategori> hamtaKategoriLista()
            {
                return kategoriLista;
            }

            public static void remoteKategori(int index)
            {
                kategoriLista.RemoveAt(index);
            }
    }
    
}
