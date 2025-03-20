using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using chevroletClone.Models;

namespace chevroletClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private static List<Car> cars = new List<Car> 
        {
            new Car { Id = 1, Name = "Onix LT", Img = "https://cgi.gm.com/mmgprod-us/dynres/prove/image.gen?i=2025/5B48HS/5B48HS/70gmds1.png&v=deg01&std=true&country=BR" , Mark = "Toyota", Description = "Sedan confortável", Price = 120000 },
            new Car { Id = 2, Name = "Montana LT", Img = "https://cgi.gm.com/mmgprod-us/dynres/prove/image.gen?i=2025/5B43BS/5B43BS/12gmds1.png&v=deg01&std=true&country=BR" , Mark = "Honda", Description = "Esportivo e confiável", Price = 130000 },
            new Car { Id = 3, Name = "Spin LT", Img = "https://cgi.gm.com/mmgprod-us/dynres/prove/image.gen?i=2025/5B752S/5B752S/44gmds1.png&v=deg01&std=true&country=BR" , Mark = "Honda", Description = "Esportivo e confiável", Price = 130000 }
        };

        // GET: api/car
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return Ok(cars);
        }

        // GET: api/car/1
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();
            return Ok(car);
        }

        // POST: api/car
        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            car.Id = cars.Count > 0 ? cars.Max(c => c.Id) + 1 : 1;
            cars.Add(car);
            return CreatedAtAction(nameof(Get), new { id = car.Id }, car);
        }

        // PUT: api/car/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Car carUpdated)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();

            car.Name = carUpdated.Name;
            car.Mark = carUpdated.Mark;
            car.Img = carUpdated.Img;
            car.Description = carUpdated.Description;
            car.Price = carUpdated.Price;

            return NoContent();
        }

        // DELETE: api/car/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NotFound();

            cars.Remove(car); // Corrigido
            return NoContent();
        }
    }
}
