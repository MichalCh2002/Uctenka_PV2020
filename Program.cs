using System;

namespace Uctenka
{
    class Program
    {
        static void Main(string[] args)
        {

            Uctenka u1 = new Uctenka();
            u1.Id = 1;

            Zbozi z1 = new Zbozi();
            z1.nazev = "Kalhoty";
            z1.cena = 250;


            Zbozi z2 = new Zbozi();
            z2.nazev = "Triko";
            z2.cena = 150;


            Firma f1 = new Firma();
            f1.nazev = "Moje Firma";
            f1.ico = 168484654;
            f1.adresa = "Ječná 30, Praha 2";

            u1.addPolozka(z1);
            u1.addPolozka(z2);
            u1.Firma = f1;
            u1.Cas = new DateTime(2020,12,2,15,15,15); 
            
            Console.WriteLine(u1.ToString());


        }
    }
}
