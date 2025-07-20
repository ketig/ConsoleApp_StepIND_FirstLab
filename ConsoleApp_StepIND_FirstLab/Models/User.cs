namespace ConsoleApp_StepIND_FirstLab.Models
{
    class User // ობიექტის შექმნა არ უნდა შეგვეძლოს
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

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, " +
                $"Birth Date: {BirthDate.ToShortDateString()}, " +
                $"Mail: {Mail}");
        }
    }
}
