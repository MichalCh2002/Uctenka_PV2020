using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    class uctenka
    {
        #region Vlastnosti

        /// <summary>
        /// Číslovaný seznam položek na účtence
        /// </summary>
        Dictionary<int, PolozkaSeznamu> Polozky = new Dictionary<int, PolozkaSeznamu>();

        public firma Firma { get; set; }

        /// <summary>
        /// Datum a čas vystavení účtenky
        /// </summary>
        public DateTime Cas { get; set; }

        /// <summary>
        /// Identifikační číslo účtenky
        /// </summary>
        public int Id { get; set; }

        #endregion

        #region Metody

        /// <summary>
        /// Vloží novou položku na účtenku
        /// </summary>
        /// <param name="polozka">položka se zbožím</param>
        public void addPolozka(PolozkaSeznamu polozka)
        {
            int id = Polozky.Count; // id polozky
            Polozky.Add(id,polozka); //vložení polozky do dictionary
        }

        #endregion

        #region Konstruktory

        public uctenka()
        {
        }

        public uctenka(int id, DateTime cas, firma firma)
        {
            this.Id = id;
            this.Cas = cas;
            this.Firma = firma;
        }   

        #endregion

        #region ToString

        public override string ToString()
        {
            if (Polozky.Count == 0) 
                return "Uctenka bez položek";

            string hlavicka =  "__________________________\n"+Firma.adresa + "\nUctenka č."+ Id +"\n"+ Cas+ "\n__________________________\n";
            string legenda = "\n ID \tNAZEV \tKS\tDPH\tZA_KUS\tS_DPH\tBEZ_DPH\n";
            string zbozi = "";

            double sDPH = 0;
            double bezDPH = 0;

            foreach (var polozka in Polozky)
            {
                zbozi += " "+polozka.Key + "\t" + polozka.Value.Zbozi.nazev + "\t " + polozka.Value.Ks +"x \t"+ (int)polozka.Value.Dan +"%\t "+ polozka.Value.Zbozi.cena +"\t "+ polozka.Value.CenaSDani +"\t "+ polozka.Value.CenaBezDane + "\n";
                sDPH += polozka.Value.CenaSDani;
                bezDPH += polozka.Value.CenaBezDane;
                
            }

            string celkem = "\n \t\t\t     celkem: [" + sDPH + " Kč] ["+ bezDPH + " Kč] ";

            return hlavicka + legenda + zbozi + celkem;
        }

        #endregion
    }
}
