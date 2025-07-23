namespace ConsoleApp_StepIND_FirstLab.Models
{
    abstract class User // ობიექტის შექმნა არ უნდა შეგვეძლოს
    {
        public uint Id { get; init; }
        public string Name { get; set; }
        public DateTime BirthDate { get; init; }
        public string Mail { get; set; }


        // constructor
        public User(uint id, string name, DateTime birthDate, string mail)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Mail = mail;
        }

        // ყველა derived class თავისი ლოგიკა უნდა ქონდეს
        public abstract int VacationDays();

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"Birth Date: {BirthDate.ToShortDateString()}, " +
                $"Mail: {Mail}");
        }
    }
}
