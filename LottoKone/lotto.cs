using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoKone
{
    public class Lotto
    {
      public bool[] Numerot { get; set; }
      public int Hits { get; set; }
      public int Lkm { get; set; }
      public int Nro { get; set; }
      public int Määrä { get; set; }
      public int HitsMax { get; set; }
    }

    public class LottoTesti
    {
        public static List<string> DrawLotto(Lotto tyyppi)
        {
            
            List<string> Rivit = new List<string>();
            
            int nro;
            Random rnd;
            string rivi = "";
            rnd = new Random();
            for (int i = 1; i <= tyyppi.Lkm; i++)
            {
                tyyppi.Hits = 0;
                do
                {
                    nro = rnd.Next(0, tyyppi.Nro);
                    if (tyyppi.Numerot[nro] == false)
                    {
                        tyyppi.Numerot[nro] = true;
                        tyyppi.Hits++;
                    }
                } while (tyyppi.Hits < tyyppi.HitsMax);
                rivi = String.Format("\nRivi {0}: ", i);
                for (int j = 0; j < tyyppi.Määrä; j++)
                {
                    
                    if (tyyppi.Numerot[j])
                    {
                        rivi +=  (j + 1).ToString() + " ";
                    }

                   
                }
               
                Rivit.Add(rivi);
              
                tyyppi.Numerot = new bool[tyyppi.Määrä];
            }

            return Rivit;
        }

       
    }
}
