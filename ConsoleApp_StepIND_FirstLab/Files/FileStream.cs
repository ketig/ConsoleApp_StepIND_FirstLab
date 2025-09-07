using System.Text;

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
