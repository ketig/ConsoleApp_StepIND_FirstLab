var birthDate = new DateTime(2000, 09, 2);

int age = GetAge(birthDate);
Console.WriteLine(age);


static int GetAge(DateTime birthDate)
{
    var today = DateTime.Now;
    int age = today.Year - birthDate.Year;
    return today.DayOfYear > birthDate.DayOfYear ? age : (age - 1);
}
