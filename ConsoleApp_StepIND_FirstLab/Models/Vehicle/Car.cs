namespace ConsoleApp_StepIND_FirstLab.Models.Vehicle
{
    internal class Car : IVehicle, IComparable<Car>
    {
        public uint Speed { get; set; }

        public int CompareTo(Car? other)
        {
            if (Speed < other.Speed)
            {
                return -1;
            }
            else if (Speed > other.Speed)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"Car with speed: {Speed}";
        }

        // Operators
        public static bool operator >(Car car1, Car car2)
        {
            return car1.Speed > car2.Speed;
        }

        public static bool operator <(Car car1, Car car2)
        {
            return car1.Speed > car2.Speed;
        }

        public void Start()
        {
            Console.WriteLine("Car has started moving.");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped moving.");
        }
    }
}
