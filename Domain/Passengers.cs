namespace Domain
{

    //use of an abstract vehicle class to implement the behavior 
    //kept encapsulation of _running with a different access property for every different kind of vehicle ( not necessary but neither anything wrong with it) 
    public class Car : Vehicle
    {
        public bool CarRunning { get { return base._running; } }
        public Car()
        {
            base._maxPassengers = 4;
        }

    }

    public class MotorBike : Vehicle
    {
        public bool MotorBikeRunning { get { return base._running; } }
        public MotorBike()
        {
            base._maxPassengers = 2;
        }

    }

    public class Coach : Vehicle
    {
        public bool CoachRunning { get { return base._running; } }
        public Coach()
        {
            base._maxPassengers = 25;
        }

    }

    public abstract class Vehicle
    {
        protected int _maxPassengers { get; set; }
        public bool _running { get; private set; }
        public void Start(List<Person> passengers)
        {
            if (passengers.Count() > _maxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            _running = true;
        }

    }
    public class Person
    {

    }
}