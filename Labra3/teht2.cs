using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
   public class Teht2
    {
        private int kerrosApu = 1;
        public int Kerros
        {
            get { return kerrosApu; }
            set
            {
                if (value >= 1 && value <= 5)
                    kerrosApu = value;
            }
        }

    }

    public class HissinTestaus
    {
        public static void TestaaHissi()
        {
            Labra3.Teht2 hissi = new Teht2();
            int UusiKerros = 0;

            Console.WriteLine("Olet kerroksessa: {0}", hissi.Kerros);

            do
            {
                Console.Write("Valitse kerros 1-5 (Lopetus 0): ");
                UusiKerros = int.Parse(Console.ReadLine());
                hissi.Kerros = UusiKerros;

                Console.WriteLine("Olet kerroksessa: {0}", hissi.Kerros);

                if (UusiKerros < 0)
                    Console.WriteLine("Liian pieni kerros.");
                if (UusiKerros > 5)
                    Console.WriteLine("Liian suuri kerros.");
            } while (UusiKerros != 0);
        }


    }
}
