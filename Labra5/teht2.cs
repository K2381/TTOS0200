using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Jääkaappi
    {
        public bool Power { get; set; }
        public int Lämpötila { get; set; }

        public Jääkaappi()
        {

        }

        public Jääkaappi(bool power,int lämpötila)
        {
            Power = power;
            Lämpötila = lämpötila;
        }

        public override string ToString()
        {
            return "Virta: " + Power + " Lämpötila: " + Lämpötila + "\n";
        }
    }

    public class Sisältö
    {
        public string Nimi { get; set; }
        public string Määrä { get; set; }
        

        public Sisältö()
        {
            Nimi = "Tyhjä on";
        }
        
        public Sisältö(string nimi,string määrä)
        {
            Nimi = nimi;
            Määrä = määrä;
            Console.WriteLine("Tuote: {0} Määrä: {1} lisätty jääkaappiin",nimi,määrä);
        }

        public override string ToString()
        {
            return "Tuote: " + Nimi + " Määrä: " + Määrä;
        }
    }

    public class Ryhmä
    {
       
        public List<Sisältö> Määrät;

        public Ryhmä()
        {
            Määrät = new List<Sisältö>();
        }


        public override string ToString()
        {
            string retval = "";
            foreach (Sisältö item in Määrät)
            {
                retval += item.ToString() + "\n";
            }
            return "\nJääkaapissa: \n"+ retval;
        }

    }
}
