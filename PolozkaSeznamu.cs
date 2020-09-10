using System;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    /// <summary>
    /// Položka seznamu zboží na účtence
    /// </summary>
    class PolozkaSeznamu
    {

        #region vlastnosti

        /// <summary>
        /// Zboží na položce
        /// </summary>
        public Zbozi Zbozi { get; set; }

        /// <summary>
        /// Počet kusů daného zboží
        /// </summary>
        public double Ks { get; set; }

        /// <summary>
        /// Daň daného zboží
        /// </summary>
        public Dan Dan { get; set; }


        /// <summary>
        /// Cena zboží s daní
        /// </summary>
        public double CenaSDani
        {
            get
            {   //vypocet ceny s daní
                return (Zbozi.cena * Ks * ((double) Dan / 100)) + Zbozi.cena * Ks;
            }
        }
        

        /// <summary>
        /// Cena zboží bez daně
        /// </summary>
        public double CenaBezDane
        {
            get
            {   //vypocet ceny s daní
                return Zbozi.cena * Ks;
            }
        }

        #endregion

        #region Konstruktry

        public PolozkaSeznamu()
        {
        }

        public PolozkaSeznamu(Zbozi zbozi, double ks, Dan dan)
        {
            this.Zbozi = zbozi;
            this.Ks = ks;
            this.Dan = dan;
        }

        #endregion

    }
}
