using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Labra3
{
    class Teht1
    {
        public static bool OnkoLuku(string syote)
        {
            bool tulos = false;
            double luku;

            if (syote.Contains("."))
                tulos = false;
            else if (syote.IndexOf(',') != syote.LastIndexOf(','))
                tulos = false;
            else if (syote.Last().ToString().Contains(','))
                tulos = false;
            else if (Double.TryParse(syote, out luku))
                tulos = true;

                return tulos;
            
        }

        public static bool OnkoPvm(string syote)
        {
            DateTime datevalue;
            bool tulos = false;
            CultureInfo culture = new CultureInfo("fi-FI");
            if (syote.Contains(","))
                tulos = false;
            else if (syote.Contains("-"))
                tulos = false;
            else if (syote.Contains("/"))
                tulos = false;
            else if (DateTime.TryParse(syote, culture, DateTimeStyles.None, out datevalue))
                tulos = true;
            return tulos;
        }
     
    }

    class TestiPeti
    {
        public static void TestiLuku()
        {

            string[] testaukset = { "Kissa", "abcABC1", "1234.","1234.5", ",1234", "1234,", "12-34,","123,4214,3","0","123","123,43","+123","-123","+123,45","-123,43"};

            foreach (var test in testaukset)
            {
                Console.WriteLine(Teht1.OnkoLuku(test));
            }
        }

        public static void TestiPvm()
        {
            string[] testaukset = { "1.2.13", "1.10.2017", "12.12.2017", "24.12.2017", "12,12,2017", "12.13.2017", "30.2.2017" ,"23-02-2013","23/3/2383","9.26.2017"};

            foreach (var test in testaukset)
                Console.WriteLine(Teht1.OnkoPvm(test));
        }
    }
}
