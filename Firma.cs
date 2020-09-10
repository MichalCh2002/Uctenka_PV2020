using System;
using System.Collections.Generic;
using System.Text;

namespace Uctenka
{
    class Firma
    {
        public string nazev { get; set; }
        public int ico { get; set; }
        public string adresa { get; set; }

        public override string ToString()
        {
            return "nazev: " + nazev + "\n ICO: " + ico + "\n adresa: " + adresa;
        }
    }
}

