namespace Domain
{
    public class Car
    {
        int _maxPassengers = 4;
        public bool CarRunning { get; private set; }

        public void Start(List<Person> passengers)
        {
            if (passengers.Count() > _maxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            CarRunning = true;
        }
    }

    public class MotorBike
    {
        int _maxPassengers = 2;
        public bool MotorBikeRunning { get; private set; }

        public void Start(List<Person> passengers)
        {
            if (passengers.Count() > _maxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            MotorBikeRunning = true;
        }
    }

    public class Coach
    {
        int _maxPassengers = 25;
        public bool CoachRunning { get; private set; }

        public void Start(List<Person> passengers)
        {
            if (passengers.Count() > _maxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            CoachRunning = true;
        }

    }


    public class Person
    {

    }
}