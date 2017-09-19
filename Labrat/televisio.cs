using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class televisio
    {
        public bool Päällä { get; set; }
        public int Kanava { get; set; }
        public int Volume { get; set; }


        public televisio()
        {

        }
        public televisio(bool päällä) 
        {
            this.Päällä = päällä;
        }

        public televisio(int kanava,int volume)
        {
            this.Kanava = kanava;
            this.Volume = volume;
        }
    }
}
