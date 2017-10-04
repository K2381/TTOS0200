using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThing
{
   public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioID { get; set; }

        public Student()
        {}

        public Student(string fname,string lname,string asio)
        {
            FirstName = fname;
            LastName = lname;
            AsioID = asio;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " Asio: " + AsioID;
        }

        
    }

    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students;
        //Konstruktori

        public Group()
        {
            Students = new List<Student>();
            //Luettaisiin esimerkiksi tietokannasta ne oppilaitten tiedot
            Students.Add(new Student("Pelle", "Peloton", "AnkkaLinna"));
            Students.Add(new Student("Aku", "Ankka", "AnkkaLinna"));
            Students.Add(new Student("Mikki", "Hiiri", "AnkkaLinna"));

            //ylikirjoitetaan ToString
        }
            public override string ToString()
        {
            string retval = "Luokka " + Name + "Sisältää oppilaat\n ";
            foreach (Student item in Students)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
    }
