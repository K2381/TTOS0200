using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{

     public class Lab02_teht2
    {
        //Properties
        public bool Päällä_teht2 { get; set; }
        public bool Linkous { get; set; }
        public float veden_lämpötila { get;}
        public bool Loppu { get; set; }

        // Constructors 
        public Lab02_teht2()
        {
            this.veden_lämpötila = 90;
        }

        public Lab02_teht2(bool päällä_teht2,bool linkous)
        {
            this.Päällä_teht2 = päällä_teht2;
            this.Linkous = linkous;
        }

        public Lab02_teht2(bool loppu)
        {
            this.Loppu = loppu;
        }
    }
}
