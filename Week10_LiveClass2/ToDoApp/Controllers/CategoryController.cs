using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    // Categorylerle ilgili CRUD işlemlerini toplayacağım temel çatı.
    // CRUD -> Create, Read, Update, Delete
    public class CategoryController : Controller
    {
        // Veritabanı bağlantım olmadığı için statik bir liste kullancağım. Buna InMemoryDB denebilir.

        public static List<Category> categories = new List<Category>
        {
            new Category{ Id=1, Name = "İş", Description = "İş hayatına dair görevlerin bulunduğu kategori."},
            new Category{ Id=2, Name = "Aile", Description = "Aile hayatına dair görevlerin bulunduğu kategori."}
        };


        [HttpGet] // Link üzerinden tetiklenen.
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // Formdaki buttondan tetikleniyor.
        public IActionResult Add(CategoryAddViewModel formData)
        {
            var newCategory = new Category()
            {
                Id = categories.Max(x => x.Id) + 1,
                Name = formData.Name,
                Description = formData.Description
            };

            categories.Add(newCategory);


            return RedirectToAction("List");
        }


        public IActionResult List()
        {
            var viewModel = categories.Select(x => new CategoryListViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description
            }).OrderBy(x => x.Name).ToList();


            return View(viewModel);
        }
    }
}
