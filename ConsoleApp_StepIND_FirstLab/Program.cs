using System.Text.RegularExpressions;

#region Regex
string email = "user@example.com";
Regex regex = new Regex(@"\w+@\w+\.\w+");
var result = regex.IsMatch(email);

Console.WriteLine(result);
#endregion

#region Age
var birthDate = new DateTime(2000, 09, 2);

int age = GetAge(birthDate);
Console.WriteLine(age);

static int GetAge(DateTime birthDate)
{
    var today = DateTime.Now;
    int age = today.Year - birthDate.Year;
    return today.DayOfYear > birthDate.DayOfYear ? age : (age - 1);
}
#endregion

#region Extension Method
string name = "Csharp";
bool isCapitalized = name.IsCapitalized();
Console.WriteLine(isCapitalized); // შედეგი: True​​

static class StringExtensions​
{
    public static  bool IsCapitalized(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        return char.IsUpper(text[0]);
    }
}
#endregion