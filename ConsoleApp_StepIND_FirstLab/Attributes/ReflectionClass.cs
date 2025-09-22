namespace ConsoleApp_StepIND_FirstLab.Attributes
{
    internal class ReflectionClass
    {
        public const string test = "Reflection";

        public void Run()
        {
            Console.WriteLine(test);
        }

        public static void Test()
        {
            ReflectionClass obj = new ReflectionClass();

            Type type = obj.GetType();
            var method = type.GetMethod("Run");

            method?.Invoke(obj, null);
        }
    }
}
