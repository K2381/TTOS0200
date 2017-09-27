using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Kulkuneuvo
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
    }

    public class PolkuPyörä
    {

    }
}
