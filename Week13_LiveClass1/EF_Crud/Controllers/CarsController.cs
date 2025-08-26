using EF_Crud.Context;
using EF_Crud.Entities;
using EF_Crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // CRUD işlemleri yapacağım.
        // Demek ki DB'ye erişmem gerekiyor.
        // O halde CarsController'a atılan her istekte elimde bir Db örneği hazır olsun.

        private readonly PatikaGaleriContext _db;

        public CarsController(PatikaGaleriContext db)
        {
            _db = db;

        }


        [HttpPost]
        public IActionResult Add(CarAddRequest request)
        {

            var newCar = new CarEntity
            {
                Marka = request.Marka,
                Model = request.Model,
            };

            _db.Cars.Add(newCar); // işlem kopya DB'de
            _db.SaveChanges(); // İşlem gerçek Db'ye kaydedildi.

            return Ok();

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _db.Cars.Select(x => new CarListResponse
            {
                Id = x.Id,
                Marka = x.Marka,
                Model = x.Model
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {


            var carEntity = _db.Cars.Find(id);

            if (carEntity is null)
                return NotFound();

            var response = new CarListResponse
            {
                Id = carEntity.Id,
                Marka = carEntity.Marka,
                Model = carEntity.Model
            };


            return Ok(response);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, CarUpdateRequest request)
        {

            var carEntity = _db.Cars.Find(id);

            if (carEntity is null)
                return NotFound();

            carEntity.Marka = request.Marka;
            carEntity.Model = request.Model;
            carEntity.ModifiedDate = DateTime.Now;

            _db.Cars.Update(carEntity);
            _db.SaveChanges();


            return Ok(carEntity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var carEntity = _db.Cars.Find(id);

            if (carEntity is null)
                return NotFound();

            carEntity.IsDeleted = true;
            carEntity.ModifiedDate = DateTime.Now; // Tercihen.

            _db.Cars.Update(carEntity);
            _db.SaveChanges();

            return Ok("Deleted");
        }
    }
}
