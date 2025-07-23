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
                    throw new ArgumentOutOfRangeException(nameof(Grade));
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


        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Grade: {Grade}, Major: {Major}");
        }

        public override int VacationDays()
        {
            return 100;
        }

        public override string ToString()
        {
            return $"Student: {Name}, " +
                   $"Grade: {Grade}, " +
                   $"Major: {Major}, " +
                   $"Birth Date: {BirthDate.ToShortDateString()}, " +
                   $"Mail: {Mail}";
        }
    }
}
