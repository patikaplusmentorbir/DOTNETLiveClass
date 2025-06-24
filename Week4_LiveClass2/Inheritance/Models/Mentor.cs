using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    
    internal class Mentor : Person
    {
        public Mentor() // ctor
        {
            Console.WriteLine("Mentor constructor tetiklendi.");
        }

        public decimal Salary { get; set; }
        public int HoursWork { get; set; }

        public void RecordClassLessons()
        {
            Console.WriteLine(FullName + " ders içeriği kaydediyor.");
        }
    }
}
