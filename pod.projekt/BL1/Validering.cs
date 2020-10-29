using System;
using DAL1;

namespace BL
{
    public class Validering
    {
        public bool rattKategori(string korrekt)
        {
            if (string.IsNullOrEmpty(korrekt))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}