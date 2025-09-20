using System.Text.Json;
using System.Xml.Serialization;
using ConsoleApp_StepIND_FirstLab.Serialization;

namespace ConsoleApp_StepIND_FirstLab.Files
{
    internal class FileStream
    {
        public static void Test()
        {
            string directoryPath = @"C:\Users\User\Desktop";
            string file = "example.txt";
            string numbersFile = "numbers.txt";
            string path = Path.Combine(directoryPath, file);
            string numbersPath = Path.Combine(directoryPath, numbersFile);

            //using (FileStream fs = new FileStream(path, FileMode.Create))
            //{
            //    byte[] data = Encoding.UTF8.GetBytes("Hello World");

            //    fs.Position = 9;
            //    int offset = 0;
            //    int count = data.Length - offset;

            //    await fs.WriteAsync(data, offset, count);
            //}

            //using (FileStream fs = new FileStream(numbersPath, FileMode.Create))
            //{
            //    Random random = new Random();
            //    string numbers = string.Join(" ", Enumerable.Range(0, 20).Select(_ => random.Next(0, 100)));

            //    byte[] data = Encoding.UTF8.GetBytes(numbers);
            //    fs.Write(data, 0, data.Length);
            //}

            ReplaceTextInFile(path, "World", "C#");
            AnalizeNumbersInFile(path,
                     out double max,
                     out double min,
                     out double average,
                     out int positiveCount,
                     out int negativeCount,
                     out int twoDigitCount);

            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"average = {average}");

            //numbers = string.Join(" ", Enumerable.Range(0, 20).Select(_ => random.Next(0, 100)));

            //int length = 20;
            //for (int i = 0; i < length; i++)
            //{
            //    numbers += random.Next(0, 100) + " ";
            //}
        }

        public static void Test1()
        {
            Student student = new Student
            {
                Name = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                University = "Some University",
                Courses =
                [
                    new() { Title = "Mathematics", Credits = 3, Professor = "Dr. Smith" },
        new() { Title = "Physics", Credits = 4, Professor = "Dr. Johnson" }
                ]
            };

            string directory = @"C:\Users\User\Downloads";
            string fileXML = "smthXML.xml";
            string fileJson = "smthJson.json";
            string pathXML = Path.Combine(directory, fileXML);
            string pathJson = Path.Combine(directory, fileJson);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));

            //using (FileStream stream = new FileStream(pathXML, FileMode.Create))
            //{
            //    xmlSerializer.Serialize(stream, student);
            //    Console.WriteLine("Wrote!");
            //}
            //using (FileStream stream = new FileStream(pathXML, FileMode.Open))
            //{
            //    Student student1 = (Student)xmlSerializer.Deserialize(stream);
            //    Console.WriteLine($"Name: {student1.Name}, LastName: {student1.LastName}, BirthDate: {student1.BirthDate}, University: {student1.University}");
            //}

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };


            string jsonString = JsonSerializer.Serialize(student, options);
            Console.WriteLine(jsonString);

            File.WriteAllText(pathJson, jsonString);
            Console.WriteLine("Wrote Json!");

            string jsonStringFromFile = File.ReadAllText(pathJson);
            Student student2 = JsonSerializer.Deserialize<Student>(jsonStringFromFile);

            Console.WriteLine(student2);
        }

        static void AnalizeNumbersInFile(string filePath,
                                 out double max,
                                 out double min,
                                 out double average,
                                 out int positiveCount,
                                 out int negativeCount,
                                 out int twoDigitCount)
        {
            string text = string.Empty;

            using (StreamReader sr = new StreamReader(filePath))
            {
                text = sr.ReadToEnd();
                Console.WriteLine(text);
            }

            string[] numbersAsString = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = numbersAsString.Select(double.Parse).ToArray();

            max = numbers.Max();
            min = numbers.Min();
            average = numbers.Average();

            positiveCount = numbers.Count(n => n > 0);
            negativeCount = numbers.Count(n => n < 0);
            twoDigitCount = numbers.Count(n => n > 9 && n < 100);
        }


        static void ReplaceTextInFile(string filepath, string oldWord, string newWord)
        {
            string fullText = string.Empty;
            string replacedText = string.Empty;

            using (StreamReader sr = new StreamReader(filepath))
            {
                fullText = sr.ReadToEnd();
            }

            replacedText = fullText.Replace(oldWord, newWord);

            using (StreamWriter sw = new StreamWriter(filepath, false))
            {
                sw.Write(replacedText);
            }
        }

    }
}
