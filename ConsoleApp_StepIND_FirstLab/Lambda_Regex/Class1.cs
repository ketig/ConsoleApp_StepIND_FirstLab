using System.Text.RegularExpressions;

namespace ConsoleApp_StepIND_FirstLab.Lambda_Regex
{
    static class Class1
    {
        public static void Regex()
        {
            string email = "user@example.com";
            Regex regex = new Regex(@"\w+@\w+\.\w+");
            var result = regex.IsMatch(email);

            Console.WriteLine(result);

            string name = "Csharp";
            bool isCapitalized = name.IsCapitalized();
            Console.WriteLine(isCapitalized); // შედეგი: True​​
        }

        static bool IsCapitalized(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            return char.IsUpper(text[0]);
        }
    }
}
