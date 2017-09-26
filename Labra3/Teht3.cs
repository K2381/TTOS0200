using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    public class Teht3
    {
        private int voimakkuusApu = 0;
        public int Voimakkuus
        {
            get { return voimakkuusApu; }

            set
            {
                if (value >= 0 && value <= 100)
                   voimakkuusApu = value;
            }
        }
    }

    public class TestaaÄäni
    {
        public static void Amplifier()
        {
            Labra3.Teht3 ääni = new Teht3();

            int UusiVoimakkuus = 0;
            string stop;

            Console.WriteLine("Amplifier volume is set to : {0}", ääni.Voimakkuus);

            while(true)
            {
                Console.Write(" Give a new volume value (0-100) (x to stop) >");
                stop = Console.ReadLine();
                if (stop == "x")
                    break;
                else
                    UusiVoimakkuus = Convert.ToInt32(stop);
                ääni.Voimakkuus = UusiVoimakkuus;

                Console.WriteLine("Amplifier volume is set to : {0}", ääni.Voimakkuus);

                if (UusiVoimakkuus > 100)
                {
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : 100");
                    ääni.Voimakkuus = 100;
                }

                if (UusiVoimakkuus < 0)
                {
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : 0");
                    ääni.Voimakkuus = 0;
                }

            } 
        }
    }
}
