namespace ConsoleApp_StepIND_FirstLab.Models.Vehicle
{
    internal class Cars
    {
        private List<Car> cars = new List<Car>();

        public Car this[int index]
        {
            get => cars[index];
            set => cars[index] = value;
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}
