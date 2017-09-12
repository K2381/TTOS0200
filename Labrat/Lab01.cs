using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab01
    {
        public static void teht1()
        {
            int number;
            Console.Write("Anna luku: ");
            number = int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                    Console.WriteLine("Annoit luvun yksi");
                    break;
                case 2:
                    Console.WriteLine("Annoit luvun kaksi");
                    break;
                case 3:
                    Console.WriteLine("Annoit luvun kolme");
                    break;

            }

        }
        public static void teht2()
        {
            int pistemaara;
            Console.Write("Anna pistemäärä: ");
            pistemaara = int.Parse(Console.ReadLine());
            if (pistemaara == 0 || pistemaara == 1)
                Console.WriteLine("Koulunumero on: 0");
            else if (pistemaara == 2 || pistemaara == 3)
                Console.WriteLine("Koulunumero on: 1");
            else if (pistemaara == 4 || pistemaara == 5)
                Console.WriteLine("Koulunumero on: 2");
            else if (pistemaara == 6 || pistemaara == 7)
                Console.WriteLine("Koulunumero on: 3");
            else if (pistemaara == 8 || pistemaara == 9)
                Console.WriteLine("Koulunumero on: 4");
            else if (pistemaara == 10 || pistemaara == 12)
                Console.WriteLine("Koulunumero on: 5");
            else
                Console.WriteLine("väärä pistemäärä");
        }

        public static void teht3()
        {
            int[] luvut = new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna 3 lukua: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }

            int summa = luvut.Sum();
            Console.WriteLine("Summa on: " + summa);

            int ka = summa / luvut.Length;
            Console.WriteLine("Keskiarvo on: " + ka);

        }

        public static void teht4()
        {
            int ika;

            Console.Write("Anna ikä: ");
            ika = int.Parse(Console.ReadLine());

            if (ika <= 17)
                Console.WriteLine("Alaikäinen");
            else if (ika >= 18 && ika <= 65)
                Console.WriteLine("Aikuinen");
            else
                Console.WriteLine("Seniori");
        }

        public static void teht5()
        {
            int tunnit;
            int minuutit;        
            int sekunnit;
            int Annettu_aika;
            Console.Write("Anna sekunnit: ");
            Annettu_aika = int.Parse(Console.ReadLine());
            var aika = TimeSpan.FromSeconds(Annettu_aika);

            tunnit = aika.Hours;
            minuutit = aika.Minutes;
            sekunnit = aika.Seconds;

            Console.WriteLine("Tunnit: " + tunnit + " Minuutit: " + minuutit + " Sekuntit: " + sekunnit);
        }

        public static void teht6()
        {
            double matka;
            double hinta = 1.595;
            double kulutus = 7.02 / 100;

            Console.Write("Anna matka kilometreinä: ");
            matka = double.Parse(Console.ReadLine());
            double bensan_kulutus = kulutus * matka;
            double kokonais_hinta = hinta * bensan_kulutus;

            Console.WriteLine("Bensaa kuluu " + bensan_kulutus + " litraa , " + " kustannus " + kokonais_hinta + " euroa ");

        }

        public static void teht7()
        {
            int vuosi;

            Console.Write("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
                Console.WriteLine("Vuosi on karkausvuosi.");
            else
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
        }

        public static void teht8()
        {
            int[] luvut = new int[3];
            int suurin = luvut[0];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna 3 lukua: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }

            foreach (int value in luvut)
            {
                if (value > suurin)
                    suurin = value;
            }

            Console.WriteLine("Suurin luku on: " + suurin);
        }

        public static void teht9()
        {
            int luku;
            int summa = 0;

            while (true) 
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
                if (luku == 0)
                    break;
            }

            Console.WriteLine("Lukujen summa on: " + summa);
        }

        public static void teht10()
        {
            int[] luvut = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < luvut.Length; i++)
            {
                if (luvut[i] % 2 == 0 )
                {
                    Console.WriteLine("HEP!");
                }
            }
        }

        public static void teht11()
        {
            int rivit;
            string tähti = "*";

            Console.Write("Anna luku: ");
            rivit = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rivit; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(tähti);
                }

                Console.Write("\n");
            }
        }

        public static void teht12()
        {
            int[] luvut = new int[5];

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna " + luvut.Length + " lukua: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(luvut);
            Console.Write("Luvut ovat: ");
            for(int i = 0; i < luvut.Length; i++)
            {
                Console.Write(luvut[i]+",");
            }
        }

        public static void teht13()
        {
            int[] luvut = new int[5];
            int summa = 0;
            int suurin = 0;
            int pienin = 0;

            for(int i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna luku: ");
                luvut[i] = int.Parse(Console.ReadLine());
                summa += luvut[i];
            }

            suurin = luvut.Max();
            pienin = luvut.Min();

            summa -= suurin;
            summa -= pienin;
            Console.WriteLine("Kokonaispisteet: " + summa);

        }

        public static void teht14()
        {
            List<int> arvosanat = new List<int>();
            string input = " ";

            while (input != "")
            {
                Console.Write("Anna arvosana: ");
                input = Console.ReadLine();
                int value;
                int.TryParse(input, out value);
                arvosanat.Add(value);
            }

            int nolla = 0;
            int yksi = 0;
            int kaksi = 0;
            int kolme = 0;
            int neljä = 0;
            int viisi = 0;

            foreach (int maara in arvosanat)
            {
                if (maara == 0)
                    nolla += 1;
                if (maara == 1)
                    yksi += 1;
                if (maara == 2)
                    kaksi += 1;
                if (maara == 3)
                    kolme += 1;
                if (maara == 4)
                    neljä += 1;
                if (maara == 5)
                    viisi += 1;
            }
            Console.Write("0: ");
            for (int i = 1; i < nolla; i++)
                Console.Write("*");
            Console.Write("\n");
            Console.Write("1: ");
            for (int i = 0; i < yksi; i++)
                Console.Write("*");
            Console.Write("\n");
            Console.Write("2: ");
            for (int i = 0; i < kaksi; i++)
                Console.Write("*");
            Console.Write("\n");
            Console.Write("3: ");
            for (int i = 0; i < kolme; i++)
                Console.Write("*");
            Console.Write("\n");
            Console.Write("4: ");
            for (int i = 0; i < neljä; i++)
                Console.Write("*");
            Console.Write("\n");
            Console.Write("5: ");
            for (int i = 0; i < viisi; i++)
                Console.Write("*");
            Console.Write("\n");
        }

        public static void teht15()
        {
            int rivit;

            Console.Write("Anna rivien määrä: ");
            rivit = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rivit - 2;i++)
            {
                for (int l = 1; l <= rivit - i; l++)
                    Console.Write(" ");
                for (int j = 1; j <= 2*i-1; j++)
                    Console.Write("*");
                Console.Write("\n");

            }
            for(int i = 1; i <= rivit - 1; i++)
                Console.Write(" ");
            Console.Write("*");
            Console.Write("\n");
            for (int i = 1; i <= rivit - 1; i++)
                Console.Write(" ");
            Console.Write("*");
            Console.Write("\n");

        }

        public static void teht16()
        {
            Random rnd = new Random();
            int yritykset = 0;
            int syöte;
           int tulos = rnd.Next(0, 100);

            while (true)
            {
                Console.Write("Arvaa luku: ");
                syöte = int.Parse(Console.ReadLine());
                yritykset++;
                if (syöte < tulos)
                    Console.WriteLine("Luku on suurempi");
                if (syöte > tulos)
                    Console.WriteLine("Luku on pienenmpi");
                if (syöte == tulos)
                    break;
            }

            Console.WriteLine("Hienoa, arvasit luvun " + yritykset + " kerralla.");
        }

        public static void teht17()
        {
            int[] taulukko1 = new int[] {10,20,30,40,50};
            int[] taulukko2 = new int[] {5,15,25,35,45};
            var yhdistetty = new int[taulukko1.Length + taulukko2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            Console.Write("Luvut taulukossa 1 : ");
            Console.WriteLine(string.Join(",", taulukko1));
            Console.Write("Luvut taulukossa 2 : ");
            Console.WriteLine(string.Join(",", taulukko2));

            while (k < yhdistetty.Length)
            {
                if(j == taulukko2.Length || ((i < taulukko1.Length) && (taulukko1[i] < taulukko2[i])))
                {
                    yhdistetty[k] = taulukko1[i];
                    i++;
                }
                else
                {
                    yhdistetty[k] = taulukko2[j];
                    j++;
                }
                k++;
            }

            Console.Write("Luvut yhdistetyssä taulukossa : ");
            Array.Sort(yhdistetty);
            Console.WriteLine(string.Join(",", yhdistetty));
           

 
        }

        public static void teht18()
        {
            string lause;
            Console.Write("Anna lause: ");
            lause = Console.ReadLine();
            lause = lause.Replace(" ","");

            char[] kääntö = lause.ToCharArray();
            Array.Reverse(kääntö);
            string käännetty =  new string(kääntö);
            käännetty =  käännetty.Replace(" ","");

            if (lause == käännetty)
                Console.WriteLine("Lause on palindromi.");
            else
                Console.WriteLine("Lause EI ole palindromi.");
        }

        public static void teht19()
        {
            string[] sana = new string[] {"k","i","s","s","a" };
            string apu_sana;
            List<string> käytetty = new List<string>(); 
            int arvaukset = 5;
            string[] viivat_taulukko = new string[] {"_","_","_","_","_" };
            string apu_viiva;
            
            Console.WriteLine("Tervetuloa pelaamaan hirsipuuta!");
          
            while(true)
            {
                foreach (string viivat in viivat_taulukko)
                    Console.Write(viivat);
                Console.WriteLine();
                Console.WriteLine("Sinulla on " + arvaukset + " yrityksiä jäljellä");
                Console.Write("Arvaa kirjain: ");
                string kirjain;
                kirjain = Console.ReadLine();
               

                if (käytetty.Contains(kirjain))
                {
                    Console.WriteLine("Olet jo käyttänyt kirjaimen");
                    käytetty.ToString();
                    Console.Write("Käytetyt kirjaimet: ");
                    foreach (string apu_käytetty in käytetty)
                        Console.Write(apu_käytetty+" ");
                    Console.Write("\n");
                    Console.Write("Arvaa kirjain: ");
                   kirjain = Console.ReadLine();
                }
                else
                {
                    käytetty.Add(kirjain);
                    arvaukset -= 1;
                }

                if (arvaukset == 0)
                    break;

                 for(int i = 0; i < sana.Length; i++)
                {
                    if(sana[i].Contains(kirjain))
                        viivat_taulukko[i] = kirjain;
                }

               apu_sana =  String.Join("", sana);
               apu_viiva = String.Join("", viivat_taulukko);

                if (apu_sana == apu_viiva)
                    break;
            }

            if (arvaukset > 0)
                Console.WriteLine("Onneksi Olkoon voitit pelin");
            else
                Console.WriteLine("Parempi onni ensikerralla.");
                
        }
           

    }
}
