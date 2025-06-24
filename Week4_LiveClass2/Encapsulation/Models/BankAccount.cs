using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class BankAccount
    {

        public string Owner { get; set; }
        public string Password { get; set; }
        //  public decimal OpenningBalance { get; set; } // Hesap Açım Bakiyesi

        // private diye belirtmeye gerek yok çünkü alabileceği en yüksek güvenlik / en düşük erişim zaten privatetır.
        decimal _openningBalance; // kapsül

        public decimal OpenningBalance 
        { get
            {
                return _openningBalance;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hesap açılış tutarı 0 TL 'nin altında olamaz. Hesabınız minimum tutar olan 0 TL ile açılıyor.");
                    _openningBalance = 0;
                }
                else
                    _openningBalance = value;
            }

        }


    }
}
