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
                new Car().Start(genPeopleArray(number));

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

                new MotorBike().Start(genPeopleArray(number));

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

                new Coach().Start(genPeopleArray(number));

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Would be incorrect to have this block of code 3 times ( problematic in the moment in which we want to change part of this logic) 
        //encapsulated logic into a different method that has the responsibility of generating a list people)
        private List<Person> genPeopleArray(int number)
        {
            var people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                people.Add(new Person());
            }
            return people;
        }
    }

}
