using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    // Miras veren class -> Üst Class -> Base Class
    internal class Person
    {
        public Person()
        {
            Console.WriteLine("Person constructor tetiklendi.");
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAdress { get; set; }
        public string Cohort { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public void CodeIt()
        {
            Console.WriteLine(FullName + " kodlama yapıyor.");
        }

    }
}
