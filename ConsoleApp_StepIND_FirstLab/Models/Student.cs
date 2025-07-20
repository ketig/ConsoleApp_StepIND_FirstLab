namespace ConsoleApp_StepIND_FirstLab.Models
{
    internal class Student : User
    {
        protected int _grade;
        public string Major { get; set; }
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
        public Student(uint id,
            string name,
            DateTime birthDate,
            string mail,
            int grade,
            string major)
            : base(id, name, birthDate, mail)
        {
            Grade = grade;
            Major = major;
        }

        public void PrintStudent()
        {
            base.Print();
            Console.WriteLine($"Grade: {Grade}, Major: {Major}");
        }
    }
}
