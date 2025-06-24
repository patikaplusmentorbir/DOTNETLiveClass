using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Not { get; set; }

        public override string ToString()
        {
            return Ad;
        }

      

    }
}
