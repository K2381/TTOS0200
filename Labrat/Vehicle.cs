using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int speed,int tyres,string name)
        {
            this.Name = name;
            this.Speed = speed;
            this.Tyres = tyres;
        }

        public string tostring()
        {
            return Name.ToString() +" "+ Speed.ToString() +" " +Tyres.ToString();
        }
    }
}
