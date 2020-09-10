using System;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    class PolozkaSeznamu
    {
        public Zbozi Zbozi { get; set; }
        public int Ks { get; set; }
        public double Dan { get; set; }

        public double CenaSDani
        {
            get
            {   //vypocet ceny s daní
                return Zbozi.cena * (Dan / 100);
            }
        }
        
        public double CenaBezDane
        {
            get
            {   //vypocet ceny s daní
                return Zbozi.cena;
            }
        }



    }
}
