using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    class Uctenka
    {
        Dictionary<int, Zbozi> Polozky = new Dictionary<int, Zbozi>();
        public Firma Firma { get; set; }
        public DateTime Cas { get; set; }
        public int Id { get; set; }


        public void addPolozka(Zbozi z)
        {
            int id = Polozky.Count;
            Polozky.Add(id,z);
        }


        public override string ToString()
        {
            string hlavicka =  Firma.ToString() + "\n Uctenka č."+ Id +"\n"+ Cas;
            string zbozi = "";

            foreach (KeyValuePair<int, Zbozi> kvp in Polozky)
            {
                zbozi += "\t"+string.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value)+"\n";
            }

            return hlavicka + zbozi;
        }
    }
}
