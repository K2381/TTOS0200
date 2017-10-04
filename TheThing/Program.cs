using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThing
{
    class Thing
    {
        //Julkinen jäsenmuuttuja != ominaisuus
        // public string Name;
        //Parempi vaihtoehto, ominaisuus AutoImplemented propertyn avulla
        //public string Name { get; set; }
        //ToString() - metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Constuctors

        public Thing()
        {
            name = "nobody here";
        }



        public override string ToString()
        {
           // return "Nimeni on: " + Name;
            //mutta mieluummin jos on sisäinen muuuttuja niin käytetään sitä
            return "Nimeni on:" + name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Se - jostakin testaus
            //Thing t = new Thing();
            //Console.WriteLine(t.ToString());
            //t.Name = "Jotakin";
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.ToString());
            //Student - olion testaus

            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmikangas";
            Student s2 = new Student("Jaska", "Jokunen", "K2323");
            //Luodaan kokoelma student-olio käytetään list
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Arska", "Aaltonen", "k2323"));
            // Näytetään oppilaat
            Console.WriteLine("Luokan oppilaat: ");
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko", "K233"));
            Console.WriteLine(luokka.ToString());

        }
    }
}
