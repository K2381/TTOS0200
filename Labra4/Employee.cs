using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Profession + " " + Salary;
        }
    }

    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {
        }

        public Boss(string firstname, string lastname,string car) : base(firstname,lastname)
          {
            Car = car;
          }

        public override string ToString()
        {
            return base.ToString() + " " + Car + " " + Bonus;
        }
    }
}
