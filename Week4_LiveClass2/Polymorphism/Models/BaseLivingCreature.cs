using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class BaseLivingCreature
    {

        // Metodu esnek (Ezilebilir) bir hale getiriyorum. Böylelikle Virtual olarak tanımlanan metot miras olarak gittiği classta değiştirilebilir ya da geliştirilebilir.
        public virtual void Breath()
        {
            Console.WriteLine("Akciğer solunumu yapıyor.");
        }
    }
}
