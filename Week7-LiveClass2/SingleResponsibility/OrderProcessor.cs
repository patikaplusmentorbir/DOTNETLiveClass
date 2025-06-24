using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class OrderProcessor
    {
        // readonly -> değer yalnızca constructorda atanabilir.
        private readonly EmailSender _sender;

        public OrderProcessor(EmailSender sender)
        {
            _sender = sender;
        }

        public void ProcessOrder(string orderDetails)
        {

            // Sipariş işleme kodları...
            Console.WriteLine("Sipariş işlendi, kayıt oluşturuldu.");

            // Sipariş bilgilerini e-posta ile gönderme kodu.
            _sender.SendOrderConfirmationEmail(orderDetails);

        }


    }

    internal class EmailSender
    {
        public void SendOrderConfirmationEmail(string orderDetails)
        {
            // E-posta gönderme kodları.

        }
    }
}
