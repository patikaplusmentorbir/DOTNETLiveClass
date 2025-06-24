using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Plant : BaseLivingCreature
    {
        // Override -> Ezmek -> İşleyişine müdahale etmek.
        public override void Breath()
        {
            Console.WriteLine("Fotosentez yapıyor.");
        }
    }
}
