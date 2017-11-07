using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{

    class Kala
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public string Paikka { get; set; }
        public string Järvi { get; set; }


        public Kala(string laji, double pituus, double paino, string paikka,string järvi)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            Paikka = paikka;
            Järvi = järvi;
        }

    }

    class Kalastaja
    {
        public string Nimi { get; set; }
        public string Puhelin { get; set; }
        public List<Kala> Kala { get; set; }


        public Kalastaja(string nimi, string puhelin)
        {
            Nimi = nimi;
            Puhelin = puhelin;
            Kala = new List<Kala>();
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "A new fisherman added to register: \n" + "- Fisherman " + Nimi + "Phone: " + Puhelin + "\n";
        }
    }
}
