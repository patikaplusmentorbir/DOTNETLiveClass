using Microsoft.AspNetCore.Mvc;

namespace MVC_Hello.Controllers
{
    public class AccountController : Controller
    {
       public string CreateAccount()
        {
            return "Account Controllerdaki CreateAccount actionına bir istek atıldı. Bu sayfada hesap oluşturulacak.";
        }
    }
}
