namespace ConsoleApp_StepIND_FirstLab.Serialization
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string University { get; set; }
        public List<Course> Courses { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, LastName: {LastName}, BirthDate: {BirthDate}, University: {University}, Courses: [{string.Join(", ", Courses.Select(c => c.Title))}]";
        }
    }
}
