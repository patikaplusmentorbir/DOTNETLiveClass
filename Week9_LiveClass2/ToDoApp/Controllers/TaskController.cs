using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        public static List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Name = "Ailenle Sinemaya git" , Description = "Son çıkan popüler filmlerden bir tanesine gidip kendine zaman ayır.", CategoryId = 2}
        };

        public static List<Category> categories = new List<Category>
        {
            new Category{ Id=1, Name = "İş", Description = "İş hayatına dair görevlerin bulunduğu kategori."},
            new Category{ Id=2, Name = "Aile", Description = "Aile hayatına dair görevlerin bulunduğu kategori."}
        };

        // Db bağlantısı olduğunda veriler Db'den çekileceğinden yukarıdaki statik listeler kullanılmayacak.


        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = categories.Select(x => new TaskAddCategoryViewModel
            {
                Id = x.Id,
                CategoryName = x.Name,
            }).OrderBy(x => x.CategoryName).ToList();
        
            return View();
        }


      
    }
}
