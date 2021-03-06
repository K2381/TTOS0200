﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
   public static class Autotalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 200000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);
            // Toinen auto
            Auto b = new Auto() { Merkki = "Audi", Malli = "A4", VM = 2010, KM = 100000, Hinta = 19000, URL = "AudiA4.png"};
            autot.Add(b);
            // Kolmas auto
            Auto c = new Auto() { Merkki = "Saab", Malli = "99", VM = 2000, KM = 1000000, Hinta = 900, URL = "" };
            autot.Add(c);
            // rellu mukaan
            Auto d = new Auto() { Merkki = "Renault", Malli = "Zoe", VM = 2017, KM = 100, Hinta = 9999, URL = "renu.png" };
            autot.Add(d);
            //palautus
            Auto e = new Auto() { Merkki = "Kebab", Malli = "Ranskalaisilla", VM = 2017, KM = 0, Hinta = 9, URL = "kebu.png" };
            autot.Add(e);
            return autot;
        }
    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }

    }

}
