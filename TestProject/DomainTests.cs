using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class DomainTests
    {
        [Fact]
        public void TestsAreWorking()
        {
            Assert.Equal(1, 1);
        }
        //the tests are made with the assumption that the vehicle should start just with a right amount of passengers,
        //improvements : Assert.Throws<Exception>(() => car.Start()); for the various scenarios 
        [Fact]
        public void Car_InputIs1_ReturnTrue()
        {
            var car = new Car();
            car.Start(genPeopleArray(1));

            Assert.True(car.CarRunning);
        }
        [Fact]
        public void Car_InputIs0_ReturnTrue()
        {
            var car = new Car();
            car.Start(genPeopleArray(0));

            Assert.False(car.CarRunning);
        }
        [Fact]
        public void Car_InputIs4_ReturnTrue()
        {
            var car = new Car();
            car.Start(genPeopleArray(4));

            Assert.True(car.CarRunning);
        }
        [Fact]
        public void Car_InputIs5_ReturnFalse()
        {
            var car = new Car();
            car.Start(genPeopleArray(5));

            Assert.False(car.CarRunning);
        }
        [Fact]
        public void Car_InputIsNeg_ReturnFalse()
        {
            var car = new Car();
            car.Start(genPeopleArray(-1));

            Assert.False(car.CarRunning);
        }
        [Fact]
        public void Car_InputIsBig_ReturnFalse()
        {
            var car = new Car();
            car.Start(genPeopleArray(514748005));

            Assert.False(car.CarRunning);
        }
        //Can be improved as it's repeating this code that already exist in the api. This kind of utility code would find a better place in a service. 
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
