using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
   public class Kauppalista
    {

        public static List<Tuote> HaeTuotteet()
        {
            List<Tuote> tuotteet = new List<Tuote>();
            return tuotteet;
        }

    }

   public class Tuote
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " ";
        }

    }
}
