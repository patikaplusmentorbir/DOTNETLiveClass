using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
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
            var viewModel = tasks.Where(x => x.IsDeleted == false).Select(x => new TaskListViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return View(viewModel);
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

        [HttpPost]
        public IActionResult Add(TaskAddViewModel formData)
        {

            var newTaskItem = new TaskItem()
            {
                Id = tasks.Max(x => x.Id) + 1,
                Name = formData.Name,
                Description = formData.Description,
                CategoryId = formData.CategoryId,
              
            };

            tasks.Add(newTaskItem);

            return RedirectToAction("List");
        }


        // Link üzerinden işlem gerçekleştiğinden HttpGet
        public IActionResult Delete(int id)
        {
            var task = tasks.FirstOrDefault(x => x.Id == id);

            // HARD DELETE - Veriyi tamamen yok eder.
            // tasks.Remove(task);

            // SOFT DELETE - Veriyi yokmuş gibi göster, datayı kaybetmemeyi.
            task.IsDeleted = true;
            task.ModifiedDate = DateTime.Now;

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = categories.Select(x => new TaskAddCategoryViewModel
            {
                Id = x.Id,
                CategoryName = x.Name,
            }).OrderBy(x => x.CategoryName).ToList();
            // Bütün kategori bilgilerini ViewBag içerisinde göndermeliyim ki SelectList'te görüntüleyebileyim.

            var task = tasks.FirstOrDefault(x => x.Id == id);

            var viewModel = new TaskEditViewModel
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                CategoryId = task.CategoryId,
            };

            return View(viewModel);
            
        }


        [HttpPost]
        public IActionResult Edit(TaskEditViewModel formData)
        {
            var task = tasks.FirstOrDefault(x => x.Id == formData.Id);

            task.Name = formData.Name;
            task.Description = formData.Description;
            task.CategoryId = formData.CategoryId;
            task.ModifiedDate = DateTime.Now;

            return RedirectToAction("List");
        }
      
    }
}
