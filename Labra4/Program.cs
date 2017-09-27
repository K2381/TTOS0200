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
    }
}
