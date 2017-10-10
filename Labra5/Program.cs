using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
     public class Program
    {
        static void Main(string[] args)
        {
            // Teht1_Testi();
            Teht2_Testi();
        }

         public static void Teht1_Testi()
        {

            Group autot = new Group();
            Group renkaat = new Group();
            autot.Autot.Add(new Kulkuneuvo("Porsche", "911"));
            renkaat.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
            renkaat.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
            renkaat.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
            renkaat.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
            
            Console.WriteLine(autot.ToString());
            Console.WriteLine(renkaat.ToString());

            autot.Autot.Clear();
            renkaat.Renkaat.Clear();

            autot.Autot.Add(new Kulkuneuvo("Ducati", "Diavel"));
            renkaat.Renkaat.Add(new Rengas("Mic", "Pilot", "160R17"));
            renkaat.Renkaat.Add(new Rengas("Mic", "Pilot", "140R16"));

            Console.WriteLine(autot.ToString());
            Console.WriteLine(renkaat.ToString());

        }

        public static void Teht2_Testi()
        {
            Jääkaappi kaappi = new Jääkaappi(true,7);
            Console.WriteLine(kaappi.ToString());

            Ryhmä tavarat = new Ryhmä();
            tavarat.Määrät.Add(new Sisältö("Maito", "1L"));
            tavarat.Määrät.Add(new Sisältö("Voi", "200g"));
            Console.WriteLine(tavarat.ToString());
        }
    }
}

