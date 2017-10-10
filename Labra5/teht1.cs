using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
   public class Rengas
    {
        string Merkki { get; set; }
        string Tyyppi { get; set; }
        string Koko { get; set; }

        public Rengas()
        {
           
        }

        public Rengas(string merkki,string tyyppi,string koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
            Console.WriteLine("Tyre {0} Added",Merkki);
        }

        public override string ToString()
        {
            return "-Name: " + Merkki + " Model: " + Tyyppi + " Tyresize: " + Koko;
        }
    }

    public class Kulkuneuvo 
    {
        string Nimi { get; set; }
        string Malli { get; set; }

        public Kulkuneuvo()
        {

        }

        public Kulkuneuvo(string nimi,string malli)
        {
            Nimi = nimi;
            Malli = malli;
            Console.WriteLine("Created new Vehicle {0} model {1}",nimi,malli);
        }


        public override string ToString()
        {
            return "Vehicle name: " + Nimi + " Model: " + Malli;
        }
    }

    public class Group
    {
        public List<Rengas> Renkaat;
        public List<Kulkuneuvo> Autot;

        public Group()
        {
            Renkaat = new List<Rengas>();
            Autot = new List<Kulkuneuvo>();
            
        }

        public override string ToString()
        {
            string retval = "";
            foreach (Kulkuneuvo item1 in Autot)
            {
               retval += item1.ToString() + "\nTyres:";
            }
            foreach (Rengas item in Renkaat)
            {
               retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
