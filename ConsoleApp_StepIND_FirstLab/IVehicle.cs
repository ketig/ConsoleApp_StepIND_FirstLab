namespace ConsoleApp_StepIND_FirstLab
{
    internal interface IVehicle
    {
        uint Speed { get; set; }
        void Start();
        void Stop();
    }
}
