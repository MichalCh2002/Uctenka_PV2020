using System;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    /// <summary>
    /// Instance této třídy představují jednotlivé produkty
    /// </summary>
    class Zbozi
    {
        #region Vlastnosti

        /// <summary>
        /// Název zboží
        /// </summary>
        public string nazev { get; set; }

        /// <summary>
        /// Cena zboží bez DPH
        /// </summary>
        public double cena { get; set; }

        #endregion


        #region Konstruktory

        public Zbozi()
        {
            
        }

        public Zbozi(string nazev, double cena)
        {
            this.nazev = nazev;
            this.cena = cena;
        }

        #endregion
    }
}
