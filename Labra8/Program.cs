using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Noppa
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Noppa();
                //TestaaProduct();
              TestaaKala();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        static void Noppa()
        {
            try
            {
                int heittonumero;
                Random rnd = new Random();
                int Yksi = 0;
                int Kaksi = 0;
                int Kolme = 0;
                int Neljä = 0;
                int Viisi = 0;
                int Kuusi = 0;

                Console.Write("Kuinka monta kertaa noppaa heitetään: ");
                int heittomäärä = int.Parse(Console.ReadLine());

                for (heittonumero = 0; heittonumero <= heittomäärä; heittonumero++)
                {
                    int luku = rnd.Next(1, 7);
                    if (luku == 1)
                        Yksi++;
                    if (luku == 2)
                        Kaksi++;
                    if (luku == 3)
                        Kolme++;
                    if (luku == 4)
                        Neljä++;
                    if (luku == 5)
                        Viisi++;
                    if (luku == 6)
                        Kuusi++;
                    Console.WriteLine("{0} heitit: {1}", heittonumero, luku);
                }


                Console.WriteLine("Ykkösiä: {0} \nKakkosia: {1} \nKolmosia: {2} \nNelosia: {3} \nVitosia: {4} \nKutosia: {5}", Yksi, Kaksi, Kolme, Neljä, Viisi, Kuusi);
                float keskiarvo = (Yksi + (Kaksi*2) + (Kolme*3) + (Neljä*4) + (Viisi*5) + (Kuusi*6)) / heittomäärä;
                Console.WriteLine("Heittojen keskiarvo: {0}", keskiarvo);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void TestaaProduct()
        {
            try
            {
                List<Product> ostoskärry = new List<Product>();

                ostoskärry.Add(new Product { Name = "Milk", Price = "1.4e" });
                ostoskärry.Add(new Product { Name = "Cheese", Price = "4.2e" });
                ostoskärry.Add(new Product { Name = "Beer", Price = "2.2e" });
                ostoskärry.Add(new Product { Name = "Butter", Price = "3.2e" });

                foreach (var o in ostoskärry)
                {
                    Console.WriteLine("- product : {0}", o.ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void TestaaKala()
        {
            try
            {



                List<Kalastaja> Rekisteri = new List<Kalastaja>();
                Rekisteri.Add(new Kalastaja("Kirsi Kernel", "020-12345678"));
                Rekisteri[0].Kala.Add(new Kala("Pike", 120, 50, "Jyväskylä", "The lake of jyväskylä"));
                Rekisteri[0].Kala.Add(new Kala("Salmon", 190, 1123.2, "The Northren edge of Finland", "River Teno"));

                foreach (Kalastaja x in Rekisteri)
                {
                    foreach (Kala i in x.Kala)
                    {
                        Console.WriteLine("Fisher: {0} got a new fish\n", x.Nimi);
                        Console.WriteLine("-specie: {0}\n-length: {1} cm\n-weight: {2} kg\n-location: {3} \n-Lake: {4}\n", i.Laji, i.Pituus, i.Paino, i.Paikka, i.Järvi);
                    }
                }

                Console.WriteLine("\nSorted register (Painavammasta kevyempään)\n");
                Rekisteri[0].Kala.Sort((x, y) => y.Paino.CompareTo(x.Paino));

                foreach (Kalastaja x in Rekisteri)
                {
                    Console.WriteLine("Fisherman: {0} has got following fishes: \n", x.Nimi);
                    foreach (Kala i in x.Kala)
                    {

                        Console.WriteLine("-specie: {0}\n-length: {1} cm\n-weight: {2} kg\n-location: {3} \n-Lake: {4}\n", i.Laji, i.Pituus, i.Paino, i.Paikka, i.Järvi);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
       
    }

   
    

}
