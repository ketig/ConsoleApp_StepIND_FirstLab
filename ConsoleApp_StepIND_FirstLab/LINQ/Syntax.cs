using ConsoleApp_StepIND_FirstLab.Models.University;

namespace ConsoleApp_StepIND_FirstLab.LINQ
{
    internal class Syntax
    {
        public static void Testing()
        {
            //დაბეჭდეთ ყველა რიცხვი, რომელიც 5-ზე მეტია 
            List<int> numbers = new List<int> { 3, 9, 1, 10, 7, 4, 2, 15, 8, 6 };
            IEnumerable<int> greaterThanFive =
                from n in numbers
                where n > 5
                select n;
            Print(greaterThanFive);

            //დაბეჭდეთ ყველა ლუწი რიცხვი, რომელიც 10-ზე ნაკლებია 
            IEnumerable<int> lessThanTenEven =
                from n in numbers
                where n % 2 == 0 && n < 10
                select n;
            Print(lessThanTenEven);

            //დაბეჭდეთ ყველა რიცხვი, ზრდადობით დალაგებული 
            var sortedNumbers =
                from n in numbers
                orderby n ascending
                select n;
            Print(sortedNumbers);

            //გამოთვალეთ მაქსიმალური რიცხვი 
            int maxNumber = numbers.Max();
            Console.WriteLine(maxNumber);

            //გამოთვალეთ ლუწი რიცხვების საშუალო მნიშვნელობა
            double average =
                (from n in numbers
                 where n % 2 == 0
                 select n).Average();
            Console.WriteLine(average);


            List<Student> students = new List<Student>
        {
            new Student(1, "Alice Johnson", new DateTime(2005, 3, 15), "alice.johnson@mail.com", 85, "Computer Science"),
            new Student(2, "Bob Smith", new DateTime(2004, 7, 21), "bob.smith@mail.com", 90, "Mathematics"),
            new Student(3, "Charlie Brown", new DateTime(2006, 1, 5), "charlie.brown@mail.com", 78, "Physics"),
            new Student(4, "Diana Evans", new DateTime(2005, 11, 30), "diana.evans@mail.com", 92, "Chemistry"),
            new Student(5, "Ethan Davis", new DateTime(2004, 5, 10), "ethan.davis@mail.com", 88, "Engineering"),
            new Student(6, "Fiona Clark", new DateTime(2005, 8, 2), "fiona.clark@mail.com", 74, "Biology"),
            new Student(7, "George White", new DateTime(2003, 12, 12), "george.white@mail.com", 81, "Economics"),
            new Student(8, "Hannah Lewis", new DateTime(2006, 2, 18), "hannah.lewis@mail.com", 95, "Computer Science"),
            new Student(9, "Ian Walker", new DateTime(2005, 6, 23), "ian.walker@mail.com", 67, "Mathematics"),
            new Student(10, "Julia Hall", new DateTime(2004, 9, 14), "julia.hall@mail.com", 84, "Psychology"),
            new Student(11, "Kevin Young", new DateTime(2005, 4, 25), "kevin.young@mail.com", 73, "Philosophy"),
            new Student(12, "Laura King", new DateTime(2006, 7, 7), "laura.king@mail.com", 91, "Engineering"),
            new Student(13, "Michael Scott", new DateTime(2003, 10, 19), "michael.scott@mail.com", 89, "Physics"),
            new Student(14, "Nina Adams", new DateTime(2005, 1, 8), "nina.adams@mail.com", 77, "History"),
            new Student(15, "Oliver Baker", new DateTime(2004, 11, 3), "oliver.baker@mail.com", 94, "Computer Science"),
            new Student(16, "Paula Green", new DateTime(2005, 2, 20), "paula.green@mail.com", 70, "Mathematics"),
            new Student(17, "Quentin Carter", new DateTime(2006, 8, 27), "quentin.carter@mail.com", 82, "Economics"),
            new Student(18, "Rachel Miller", new DateTime(2003, 6, 4), "rachel.miller@mail.com", 86, "Chemistry"),
            new Student(19, "Samuel Turner", new DateTime(2004, 12, 1), "samuel.turner@mail.com", 79, "Engineering"),
            new Student(20, "Tina Edwards", new DateTime(2005, 9, 9), "tina.edwards@mail.com", 93, "Biology")
        };

            // Physics
            var physicsStudents =
                from student in students
                where student.Major == "Physics"
                select student;
            Print(physicsStudents);

            IEnumerable<IGrouping<string, Student>> groups =
                from student in students
                group student by student.Major;

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item);
                }
                Console.WriteLine();
            }
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
