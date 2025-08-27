namespace ConsoleApp_StepIND_FirstLab.LINQ
{
    internal class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }
}
