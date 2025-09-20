namespace ConsoleApp_StepIND_FirstLab.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    internal class Custom : Attribute
    {
        private int _score;

        public Custom() { }

        public Custom(int score)
        {
            _score = score;
        }
    }

}
