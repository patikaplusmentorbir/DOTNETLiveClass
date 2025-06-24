using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    // Miras alan class -> Türetilmiş class -> Derived Class -> Alt Class
    internal class Student : Person
    {
        public Student()
        {
            Console.WriteLine("Student constructor tetiklendi.");
        }
        // Person içerisideki propertyleri ve metotları kopyalayıp buraya yapıştırmışım gibi düşünebilirsiniz.
        public string StudentNumber { get; set; }
        public string EducationType { get; set; }

        public void CompleteTasks()
        {
            Console.WriteLine(FullName + " cohort tasklarını tamamlıyor.");
        }
       
    }
}
