using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Uctenka
{
    /// <summary>
    /// Informace o provozovateli
    /// </summary>
    class firma
    {
        #region Vlastnosti

        /// <summary>
        /// Název společnosti
        /// </summary>
        public string nazev { get; set; }

        /// <summary>
        /// Identifikační číslo společnosti (datový typ string zvolen páč s číslem není třeba počítat a je třeba délka řetězce)
        /// </summary>
        private string _ICO;
        public string ICO
        {
            get
            {
                return _ICO;
            }
            set
            {
                if (value.Length == 8)
                {
                    _ICO = value;
                }
                else
                {
                    Console.WriteLine("IČO musí obsahovat osm číslic!!!");
                }
            }
        }

        /// <summary>
        /// Adresa sídla společnosti
        /// </summary>
        public string adresa { get; set; }

        #endregion

        #region ToString

        public string Vypis()
        {
            return "nazev: " + nazev + "\nICO: " + "" + "\nadresa: " + adresa;
        }

        #endregion

        #region Konstruktory

        /// <summary>
        /// Prázdný konstruktor
        /// </summary>
        public firma()
        {
        }

        /// <summary>
        /// Plný konstruktor
        /// </summary>
        /// <param name="nazev">Název společnosti</param>
        /// <param name="ico">Identifikační číslo společnosti</param>
        /// <param name="adresa">Adresa sídla společnosti</param>
        public firma(string nazev, string ico, string adresa)
        {
            this.nazev = nazev;
            this.ICO = ico;
            this.adresa = adresa;
        }

        #endregion
    }
}

