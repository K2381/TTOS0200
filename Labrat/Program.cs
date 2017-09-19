using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Labrat.Lab01.teht1();
            //Lab01.teht2();
            // Lab01.teht3();
            //Lab01.teht4();
            //Lab01.teht5();
            // Lab01.teht6();
            //Lab01.teht7();
            //Lab01.teht8();
            // Lab01.teht9();
            //Lab01.teht10();
            //Lab01.teht11();
            //Lab01.teht12();
            //Lab01.teht13();
            //Lab01.teht14();
            //Lab01.teht15();
            //Lab01.teht16();
            //Lab01.teht17();
            //Lab01.teht18();
            // Lab01.teht19();
            //Lab02_teht1.pytty_päälle();
            //pesukone();
            //tv_päälle();
            PrintData();
        }

        static void pesukone()
        {
            Lab02_teht2 pesukone = new Lab02_teht2();

            pesukone.Päällä_teht2 = true;
            pesukone.Linkous = true;
            pesukone.Loppu = false;

            Console.WriteLine("Onko pesukone päällä: {0}", pesukone.Päällä_teht2);
            Console.WriteLine("Linkous? : {0}", pesukone.Linkous);
            Console.WriteLine("Veden lämpötila: {0}", pesukone.veden_lämpötila);
            Console.WriteLine("Valmista? : {0}", pesukone.Loppu);
        }

        static void tv_päälle()
        {
            televisio televisio = new televisio();

            televisio.Päällä = true;
            televisio.Kanava = 4;
            televisio.Volume = 100;

            Console.WriteLine("Onko tv päällä: {0}", televisio.Päällä);
            Console.WriteLine("Kanava: {0}", televisio.Kanava);
            Console.WriteLine("Bassot jytkyy, Äänenvoimakkuus: {0}", televisio.Volume);
        }
       
        static void PrintData()
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Name = "Lamborghini Centenario";
            vehicle.Speed = 300;
            vehicle.Tyres = 21;

            Console.WriteLine("Auton nimi: {0}", vehicle.Name);
            Console.WriteLine("Auton nopeus: {0}", vehicle.Speed);
            Console.WriteLine("Auton renkaitten tuumat: {0}", vehicle.Tyres);

    

            Console.WriteLine(vehicle.tostring());
        }

        static void PrintOpiskelijat()
        {
            Opiskelija opiskelija_1 = new Opiskelija();
            Opiskelija opiskelija_2 = new Opiskelija();
            Opiskelija opiskelija_3 = new Opiskelija();
            Opiskelija opiskelija_4 = new Opiskelija();
            Opiskelija opiskelija_5 = new Opiskelija();

            opiskelija_1.Nimi = "Pete Tötterström";
            opiskelija_2.Nimi = "Jarmo Tötterström";
            opiskelija_3.Nimi = "Pekka Tötterström";
            opiskelija_4.Nimi = "Mikko Tötterström";
            opiskelija_5.Nimi = "Mirva Tötterström";

            opiskelija_1.Keskiarvo = 3;
            opiskelija_2.Keskiarvo = 1;
            opiskelija_3.Keskiarvo = 2;
            opiskelija_4.Keskiarvo = 5;
            opiskelija_5.Keskiarvo = 4;

            opiskelija_1.Opintopisteet = 0;
            opiskelija_2.Opintopisteet = 10;
            opiskelija_3.Opintopisteet = 20;
            opiskelija_4.Opintopisteet = 30;
            opiskelija_5.Opintopisteet = 40;
        }
       
           

            
        
    }
}
