using System;
using System.Collections;
using System.IO;

namespace Uctenka
{

    /// <summary>
    /// Program jednoduché simulace účtenky
    ///
    /// Author: Michal Chamrád
    /// Class:  C4a
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            //ZBOŽÍ
            Zbozi z1 = new Zbozi("Kalhoty", 250);
            Zbozi z2 = new Zbozi("Triko", 500);
            Zbozi z3 = new Zbozi("Šortky", 300);

            //FIRMA
            firma f1 = new firma("Moje Firma", "12345678", "Ječná 30, Praha 2");


            //POLOŽKY NA ÚČTENKU
            PolozkaSeznamu p1 = new PolozkaSeznamu(z1, 3, Dan.základní);
            PolozkaSeznamu p2 = new PolozkaSeznamu(z2, 2, Dan.základní);
            PolozkaSeznamu p3 = new PolozkaSeznamu(z3, 1, Dan.snížená);
            PolozkaSeznamu p4 = new PolozkaSeznamu(z1, 14, Dan.základní);
            PolozkaSeznamu p5 = new PolozkaSeznamu(z2, 2, Dan.základní);
            PolozkaSeznamu p6 = new PolozkaSeznamu(z3, 6, Dan.snížená);


            //ÚČTENKA
            uctenka u1 = new uctenka(1, DateTime.Now, f1);
            u1.addPolozka(p1);
            u1.addPolozka(p2);
            u1.addPolozka(p3);
            u1.addPolozka(p4);
            u1.addPolozka(p5);
            u1.addPolozka(p6);

            //VÝPIS DO KONZOLE
            Console.WriteLine(u1.ToString());

            //ZÁPIS DO SOUBORU
            ulozUctenku(u1);




        }

        /// <summary>
        /// Uloží danou účtenku do souboru
        /// </summary>
        /// <param name="u">Učtneka k uložení</param>
        public static void ulozUctenku(uctenka u)
        {
            string path = @"C:\Users\Public\Uctenka.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(u.ToString());
                }
                Console.WriteLine("Zapsáno do souboru!");
            }
        }
    }
}
