using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public float Keskiarvo { get; set; }
        public int Opintopisteet { get; set; }
        public string Suuntautuminen { get; set; }

        public Opiskelija()
        {

        }

        public Opiskelija(string nimi,float keskiarvo,int opintopisteet,string suuntautuminen)
        {
            this.Nimi = nimi;
            this.Keskiarvo = keskiarvo;
            this.Opintopisteet = opintopisteet;
            this.Suuntautuminen = suuntautuminen;
        }


    }
}
