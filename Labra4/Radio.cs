using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
   public class Radio
    {
        private int VolumeApu;
        private int Volumemin = 0;
        private int Volumemax = 9;
        public bool Päällä { get; set; }
        public int Voimakkuus {
            get { return VolumeApu; }
            set
            {
                if (value < Volumemin)
                    value = Volumemin;
                if (value > Volumemax)
                    value = Volumemax;

                VolumeApu = value;
            }
        }
        private double TaajuusApu = 990;
        private double Taajuusmin = 2000.0;
        public double Taajuusmax = 26000.0;

        public double Taajuus {get { return TaajuusApu; }
        set {
                if (value < Taajuusmin)
                    value = Taajuusmin;
                if (value > Taajuusmax)
                    value = Taajuusmax;

                TaajuusApu = value;
            }
        }


        public Radio()
        {

        }

        public override string ToString()
        {
            return "Päällä: " + Päällä + " Äänenvoimakkuus: " + Voimakkuus + " Taajuus: " + Taajuus;
        }
    }





}
