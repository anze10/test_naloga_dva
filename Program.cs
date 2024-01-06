using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace blatko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] naselje = { "Banovci", "Vransko", "Trbovlje", "Most na Soči", "Čemšenik"};
            int[] postnaSt = { 9241, 3305, 1420, 5216, 1413};
            double[] povrsina = { 2.64, 3.1, 10.232, 1.57, 2.28 };
            string[] statRegija = { "Pomurska", "Savinjska", "Zasavska", "Goriška", "Zasavska" };
           // int x = Convert.ToInt32(Console.ReadLine());
            //double povrsin = Convert.ToDouble(Console.ReadLine());
            //zamenjaj_pov(x, povrsin,povrsina);
            //int pStevilka = Convert.ToInt32(Console.ReadLine());
            //string kraj = Console.ReadLine();
            //string kratica_kraja = kratica(pStevilka, kraj);
            //Console.WriteLine(kratica_kraja);
            //int filter  = Convert.ToInt32(Console.ReadLine());
            //izborNaselji(filter, postnaSt, naselje);
            string regg = Console.ReadLine();
            velikostRegije(regg, statRegija, povrsina);
        }
        public static void zamenjaj_pov(int x, double povrsin, double[] povrsina) {
            povrsina[x] = povrsin;
        }
        public static string kratica(int pStevilka, string kraj) {
            string krt = Convert.ToString(pStevilka);
            string tri = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                tri += Convert.ToString(kraj[i]);
            
            }//tOLE JE OPCIJA ENA

            tri = kraj.Substring(0, 3);//TOLE JE OPCIJA DVA
            
            
            krt += tri;//Tole mora bit v obeh primerih




            return krt;
        }
        public static void izborNaselji(int filter, int[] postnaST, string[] naselje ) {
            for (int i = 0; i< postnaST.Length; i++) {
                if (postnaST[i] > filter) {
                   Console.WriteLine( kratica(postnaST[i], naselje[i]));
                }
            }
        }
        public static void velikostRegije(string regg, string[] statRegija, double[] povrsina) {
            double skupnaVelikost = 0;
            for (int i = 0; i < statRegija.Length; i++) {
                if (statRegija[i] ==  regg)
                {
                    skupnaVelikost += povrsina[i];
                }
            }
            Console.WriteLine("skupna velikost {0} je {1}",regg, skupnaVelikost);
            Console.ReadLine();
        }
    }

}
