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

        public static void TestingJoin()
        {
            //შექმენი ორი სია: List<Person> და List<Order> 
            //დაწერე query syntax გამოყენებით join, რომელიც დააბრუნებს ყველა ადამიანს თავისი შეკვეთით. 
            //შედეგი: Name: Giorgi, Product: Laptop
            List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "Alice Johnson", PhoneNumber = "555-1001" },
            new Person { Id = 2, Name = "Bob Smith", PhoneNumber = "555-1002" },
            new Person { Id = 3, Name = "Charlie Brown", PhoneNumber = "555-1003" },
            new Person { Id = 4, Name = "David Miller", PhoneNumber = "555-1004" },
            new Person { Id = 5, Name = "Eve Davis", PhoneNumber = "555-1005" },
            new Person { Id = 6, Name = "Frank Wilson", PhoneNumber = "555-1006" },
            new Person { Id = 7, Name = "Grace Thompson", PhoneNumber = "555-1007" },
            new Person { Id = 8, Name = "Hannah Taylor", PhoneNumber = "555-1008" },
            new Person { Id = 9, Name = "Ian Clark", PhoneNumber = "555-1009" },
            new Person { Id = 10, Name = "Jack White", PhoneNumber = "555-1010" },
            new Person { Id = 11, Name = "Karen Lewis", PhoneNumber = "555-1011" },
            new Person { Id = 12, Name = "Liam Hall", PhoneNumber = "555-1012" },
            new Person { Id = 13, Name = "Mia Allen", PhoneNumber = "555-1013" },
            new Person { Id = 14, Name = "Noah Young", PhoneNumber = "555-1014" },
            new Person { Id = 15, Name = "Olivia King", PhoneNumber = "555-1015" },
            new Person { Id = 16, Name = "Paul Scott", PhoneNumber = "555-1016" },
            new Person { Id = 17, Name = "Quinn Green", PhoneNumber = "555-1017" },
            new Person { Id = 18, Name = "Ryan Adams", PhoneNumber = "555-1018" },
            new Person { Id = 19, Name = "Sophia Baker", PhoneNumber = "555-1019" },
            new Person { Id = 20, Name = "Thomas Nelson", PhoneNumber = "555-1020" }
        };

            List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200.00 },
            new Product { Id = 2, Name = "Smartphone", Price = 800.00 },
            new Product { Id = 3, Name = "Tablet", Price = 400.00 },
            new Product { Id = 4, Name = "Monitor", Price = 300.00 },
            new Product { Id = 5, Name = "Keyboard", Price = 50.00 },
            new Product { Id = 6, Name = "Mouse", Price = 25.00 },
            new Product { Id = 7, Name = "Printer", Price = 150.00 },
            new Product { Id = 8, Name = "Router", Price = 100.00 },
            new Product { Id = 9, Name = "Webcam", Price = 75.00 },
            new Product { Id = 10, Name = "Headphones", Price = 200.00 },
            new Product { Id = 11, Name = "USB Drive", Price = 20.00 },
            new Product { Id = 12, Name = "External HDD", Price = 100.00 },
            new Product { Id = 13, Name = "SSD", Price = 150.00 },
            new Product { Id = 14, Name = "Graphics Card", Price = 500.00 },
            new Product { Id = 15, Name = "Power Bank", Price = 60.00 },
            new Product { Id = 16, Name = "Charger", Price = 30.00 },
            new Product { Id = 17, Name = "Smart Watch", Price = 250.00 },
            new Product { Id = 18, Name = "Drone", Price = 1000.00 },
            new Product { Id = 19, Name = "Camera", Price = 700.00 },
            new Product { Id = 20, Name = "Tripod", Price = 80.00 },
            new Product { Id = 21, Name = "Speaker", Price = 180.00 },
            new Product { Id = 22, Name = "Microphone", Price = 120.00 },
            new Product { Id = 23, Name = "Smart Glasses", Price = 1500.00 },
            new Product { Id = 24, Name = "VR Headset", Price = 900.00 },
            new Product { Id = 25, Name = "Gaming Console", Price = 500.00 }
        };

            List<Order> orders = new List<Order>
        {
            new Order { PersonId = 1, ProductId = 1 },
            new Order { PersonId = 1, ProductId = 5 },
            new Order { PersonId = 2, ProductId = 2 },
            new Order { PersonId = 2, ProductId = 10 },
            new Order { PersonId = 3, ProductId = 3 },
            new Order { PersonId = 3, ProductId = 6 },
            new Order { PersonId = 4, ProductId = 4 },
            new Order { PersonId = 4, ProductId = 7 },
            new Order { PersonId = 5, ProductId = 8 },
            new Order { PersonId = 5, ProductId = 11 },
            new Order { PersonId = 6, ProductId = 12 },
            new Order { PersonId = 6, ProductId = 13 },
            new Order { PersonId = 7, ProductId = 14 },
            new Order { PersonId = 7, ProductId = 16 },
            new Order { PersonId = 8, ProductId = 15 },
            new Order { PersonId = 8, ProductId = 19 },
            new Order { PersonId = 9, ProductId = 18 },
            new Order { PersonId = 9, ProductId = 20 },
            new Order { PersonId = 10, ProductId = 9 },
            new Order { PersonId = 10, ProductId = 21 },
            new Order { PersonId = 11, ProductId = 17 },
            new Order { PersonId = 12, ProductId = 22 },
            new Order { PersonId = 13, ProductId = 24 },
            new Order { PersonId = 14, ProductId = 25 },
            new Order { PersonId = 15, ProductId = 23 },
            new Order { PersonId = 16, ProductId = 2 },
            new Order { PersonId = 17, ProductId = 6 },
            new Order { PersonId = 18, ProductId = 10 },
            new Order { PersonId = 19, ProductId = 3 },
            new Order { PersonId = 20, ProductId = 1 }
        };

            var allOrders = from order in orders
                            join product in products on order.ProductId equals product.Id
                            join person in people on order.PersonId equals person.Id
                            select new
                            {
                                order.PersonId,
                                order.ProductId,
                                PersonName = person.Name,
                                person.PhoneNumber,
                                ProductName = product.Name,
                                product.Price
                            };

            foreach (var item in allOrders)
            {
                Console.WriteLine($"{item.PersonName}\t{item.PhoneNumber}\t{item.ProductName}\t{item.Price}");
            }
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========================");
        }

        public static void Print<T>(IEnumerable<T> collection, string text)
        {
            Console.WriteLine(text);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========================");
        }
    }
}

//using ConsoleApp_StepIND_FirstLab.Models.Vehicle;

//List<Country> countries = new List<Country>
//{
//    new Country(1, "Georgia", "Tbilisi", 3714000, "Asia"),
//    new Country(2, "Germany", "Berlin", 83240000, "Europe"),
//    new Country(3, "Japan", "Tokyo", 125700000, "Asia"),
//    new Country(4, "Brazil", "Brasília", 215300000, "South America"),
//    new Country(5,"Canada", "Ottawa", 38930000, "North America"),
//    new Country(6,"Australia", "Canberra", 26000000, "Oceania"),
//    new Country(7,"Kenya", "Nairobi", 53770000, "Africa"),
//    new Country(8,"India", "New Delhi", 1408000000, "Asia"),
//    new Country(9,"France", "Paris", 68000000, "Europe"),
//    new Country(10,"Egypt", "Cairo", 109300000, "Africa")
//};
//List<Car> cars = new List<Car>
//        {
//            new Car { Speed = 120, CountryId = 1 },
//            new Car { Speed = 150, CountryId = 2 },
//            new Car { Speed = 180, CountryId = 3 },
//            new Car { Speed = 200, CountryId = 4 },
//            new Car { Speed = 90,  CountryId = 5 },
//            new Car { Speed = 130, CountryId = 6 },
//            new Car { Speed = 175, CountryId = 7 },
//            new Car { Speed = 110, CountryId = 8 },
//            new Car { Speed = 95,  CountryId = 9 },
//            new Car { Speed = 220, CountryId = 10 },
//            new Car { Speed = 160, CountryId = 11 },
//            new Car { Speed = 145, CountryId = 10 },
//            new Car { Speed = 170, CountryId = 3 },
//            new Car { Speed = 80,  CountryId = 14 },
//            new Car { Speed = 140, CountryId = 15 },
//            new Car { Speed = 190, CountryId = 6 },
//            new Car { Speed = 210, CountryId = 17 },
//            new Car { Speed = 100, CountryId = 18 },
//        };

//// join the two lists
//var joinedList =
//    from car in cars
//    join country in countries on car.CountryId equals country.CountryId
//    select new
//    {
//        car.Speed,
//        CountryName = country.Name,
//        country.Capital,
//    };

//foreach (var item in joinedList)
//{
//    Console.WriteLine($"Speed: {item.Speed}, Country: {item.CountryName}, Capital: {item.Capital}");
//}
