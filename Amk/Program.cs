using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amk
{
    class AMK
    {
        public string Name { get; set; }
        public List<Tutkinto> Tutkinnot {get; set; }
        static void Main(string[] args)
        {
            Opiskelija student1 = new Opiskelija() { Name = "Pete Tötterström", Opiskelijatunnus = "K1111" };
            Opiskelija student2 = new Opiskelija() { Name = "Kirsi Tötterström", Opiskelijatunnus = "K1112" };
            Opiskelija student3 = new Opiskelija() { Name = "Veikko Tötterström", Opiskelijatunnus = "K1113" };

            Opettaja teacher1 = new Opettaja() { Name = "Irma Tötterström" };
            Opettaja teacher2 = new Opettaja() { Name = "Kalevi Tötterström" };

            Tutkinto ttv = new Tutkinto() { Name = "Tieto- ja viestintätekniikka" };
            Tutkinto hkt = new Tutkinto() { Name = "Tietojen käsittely" };
            Tutkinto tko = new Tutkinto() { Name = "Kone- ja tuotantotekniikka" };
 
        }
    }

    class Tutkinto
    {
        public string Name { get; set; }
        public List<Opintojakso> Opintojaksot { get; set; }

        public static void LisääOpintojakso()
        {
           
            Opintojakso mat1 = new Opintojakso() { Name = "Matematiikka 1" };
            Opintojakso fys1 = new Opintojakso() { Name = "Fysiikka 1" };
            Opintojakso vin = new Opintojakso() { Name = "Viininmaistelu" };
            Opintojakso yrit = new Opintojakso() { Name = "Yrittäjyys" };
            
        }

        public static List<Opintojakso> HaeOpintojaksot()
        {
            Tutkinto Lista = new Tutkinto();
            Lista.Opintojaksot = new List<Opintojakso>();
            return Lista.Opintojaksot;
        }


    }

    class Opintojakso
    {
        public string Name { get; set; }
        public int Opintopiste { get; set; }
  
        public List<Opettaja> Opettajat { get; set; }
        public List<Opiskelija> Opiskelijat { get; set; }
        
    }

    class Opettaja
    {
        public string Name { get; set; }
    }

    class Opiskelija
    {
        public string Name { get; set; }
        public string Opiskelijatunnus { get; set; }
       
    }
}
