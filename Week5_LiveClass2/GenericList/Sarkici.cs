using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Sarkici 
    {
        public string TamAd { get; set; }
        public string MuzikTurleri { get; set; }
        public string Memleket { get; set; }

        public override string ToString()
        {
            return TamAd;
        }
    }
}
