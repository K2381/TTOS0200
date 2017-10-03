using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    public class Kulkuneuvo
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public Kulkuneuvo()
        { 
        }

        public Kulkuneuvo(string name,string model,string color,int modelyear)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
            Color = color;
        }

        public override string ToString()
        {
            return Name + " " + Model + " " + ModelYear + " " + Color;
        }
    }

    public class PolkuPyörä :Kulkuneuvo
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        public PolkuPyörä()
        {

        }

        public override string ToString()
        {
            return base.ToString() + GearWheels + " " + GearName;
        }
    }

    public class Boat :Kulkuneuvo
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {

        }

        public override string ToString()
        {
            return base.ToString() +" " + SeatCount + " " + BoatType;
        }
    }
}
