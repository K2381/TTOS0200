using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaTekijä();
            TestaaKulkuneuvo();
            TestaaRadio();
            TestaaKirjahylly();
        }

        static void TestaaTekijä()
        {
            Employee employee = new Employee();
            employee.FirstName = "Kirsi";
            employee.LastName = "Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;

            Console.WriteLine(employee.ToString());

            Boss boss = new Boss();
            boss.FirstName = "Jussi";
            boss.LastName = "Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;

            Console.WriteLine(boss.ToString());

            employee.Profession = "Principal Teacher";
            employee.Salary = 2200;

            Console.WriteLine(employee.ToString());
        }

        static void TestaaKulkuneuvo()
        {
            PolkuPyörä bike = new PolkuPyörä();
            bike.Name = "Jopo";
            bike.Model = "Street Model";
            bike.ModelYear = 2016;
            bike.Color = "Blue";
            bike.GearWheels = false;
            bike.GearName = "";
            Console.WriteLine(bike.ToString());

            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.ModelYear = 1990;
            boat.Color = "White";
            boat.SeatCount = 3;
            boat.BoatType = "Rowboat";
            Console.WriteLine(boat.ToString());
        }

        static void TestaaRadio()
        {
            Radio radio = new Radio();
            radio.Päällä = true;
            radio.Voimakkuus = 7;
            radio.Taajuus = 12345.6789;
            Console.WriteLine(radio.ToString());
        }

        static void TestaaKirjahylly()
        {
            Kirja kirja = new Kirja();
            kirja.Nimi = "Tintti Amerikassa";
            kirja.TekoVuosi = 1932;
            kirja.SivujenMäärä = 62;
            Console.WriteLine(kirja.ToString());

            Puhelin puhelin = new Puhelin();
            puhelin.Nimi = "Samsung";
            puhelin.TekoVuosi = 2015;
            puhelin.Malli = "Galaxy s6";
            Console.WriteLine(puhelin.ToString());
        }
    }
}
