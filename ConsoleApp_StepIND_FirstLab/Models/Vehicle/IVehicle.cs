namespace ConsoleApp_StepIND_FirstLab.Models.Vehicle
{
    internal interface IVehicle
    {
        uint Speed { get; set; }
        void Start();
        void Stop();
    }
}
