using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult AddPassengersToCar(int number)
        {
            try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new Car().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToMotorBike(int number)
        {
            try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new MotorBike().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public IActionResult AddPassengersToCoach(int number)
        {
            try
            {
                var people = new List<Person>();

                for (int i = 0; i < number; i++)
                {
                    people.Add(new Person());
                }

                new Coach().Start(people);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
