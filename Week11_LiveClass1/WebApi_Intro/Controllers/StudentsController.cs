using Microsoft.AspNetCore.Mvc;
using WebApi_Intro.Models;

namespace WebApi_Intro.Controllers
{
    // Çoğul isimle açmak -> ApiController isimlendirme *geleneği* - zorunlu değil.
    [ApiController]
    [Route("api/[controller]")] // www.localhost:7710.com/api/students şeklinde istek atılır.
    public class StudentsController : ControllerBase // ApiController ise mirası buradan al.
    {

        public static List<Student> students = new List<Student>
        {
            new Student{ Id = 1, Name = "Ajda", Age = 70, Department = "Müzik" , IsActive = true},
            new Student{ Id = 2, Name = "Serdar", Age = 50, Department = "Şans Oyunları", IsActive = true},
            new Student{ Id = 3, Name = "Acun", Age = 55, Department = "Kutu açma/kapama", IsActive = false}
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students.Where(x => x.IsDeleted == false));
        }

        [HttpGet("{id}")] // RequestURL'i etkiler.
        public IActionResult Get(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student is null)
                return NotFound();
         

            return Ok(student);
        }

        [HttpGet("byname/{name}")]
        public IActionResult GetByName(string name)
        {
            var response = students.Where(x => x.Name.Contains(name));

            if (!response.Any()) // response.Any() Boş değil ise |!response.Any() -> boş ise
                return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            students.Add(student);

            
            return CreatedAtAction("Get", new { id = student.Id} , student);

            
        }

        [HttpPatch]
        public IActionResult ChangeActivity(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student is null)
                return NotFound();

            student.IsActive = !student.IsActive;
            return Ok();

            
        }

        [HttpPut("{id}")]
        public IActionResult ChangeStudent(int id, Student student)
        {
            var currentStudent = students.FirstOrDefault(x => x.Id == id);

            if (currentStudent is null)
                return NotFound();

            currentStudent.Id = student.Id;
            currentStudent.Name = student.Name;
            currentStudent.Age = student.Age;
            currentStudent.Department = student.Department;
            currentStudent.IsActive = student.IsActive;

            return Ok(currentStudent);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);

            if (student is null)
                return NotFound();

            // HARD DELETE
            //   students.Remove(student);

            // SOFT DELETE
            student.IsDeleted = true;
            return Ok();
        }
    }
}


// Verile Okuma --> HttpGet
// Veri Ekleme --> HttpPost
// Veri Güncelleme --> HttpPatch
// Veriyi Komple Değiştirme --> HttpPut
// Veriyi Silme  --> HttpDelete


// StatusCode geriye dönülür.

