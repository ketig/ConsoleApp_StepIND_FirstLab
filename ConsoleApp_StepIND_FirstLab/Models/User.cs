namespace ConsoleApp_StepIND_FirstLab.Models
{
    class User
    {
        private int _grade;

        public string Name { get; set; }
        public DateTime BirthDate { get; init; }
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100!");
                }
                else
                {
                    _grade = value;
                }
            }
        }

        // constructor
        //public User() { }
        public User(string name, DateTime birthDate, int grade)
        {
            Name = name;
            BirthDate = birthDate;
            Grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"Birth Date: {BirthDate.ToShortDateString()}, " +
                $"Grade: {Grade}");
        }
    }
}
