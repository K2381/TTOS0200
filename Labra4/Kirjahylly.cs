using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
     public class Kirjahylly
    {
        public string Nimi { get; set; }
        public int TekoVuosi { get; set; }

        public Kirjahylly()
        {
        }

        public override string ToString()
        {
            return "Nimi: " + Nimi + " Tekovuosi: " + TekoVuosi;
        }
    }

    public class Kirja :Kirjahylly
    {
        public int SivujenMäärä { get; set; }

        public Kirja()
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Sivujenmäärä: " + SivujenMäärä;
        }

    }

    public class Puhelin :Kirjahylly
    {
        public string Malli { get; set; }

        public Puhelin()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " Malli: " + Malli;
        }
    }
}
