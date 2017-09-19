using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
   public class Lab02_teht1
    {
       public bool päällä { get; set; }
       public float lämpötila { get; set; }
       public float Kosteus { get; set; }

         public static void pytty_päälle()
        {
            Lab02_teht1 teht1 = new Labrat.Lab02_teht1();

            teht1.päällä = true;
            teht1.lämpötila = 120;
            teht1.Kosteus = 40;


            Console.WriteLine("Onko kiuas päällä: {0}", teht1.päällä);
            Console.WriteLine("Kuinka lämmin: {0}", teht1.lämpötila);
            Console.WriteLine("Kiukaan kosteus: {0}", teht1.Kosteus);
        }


    }
}
