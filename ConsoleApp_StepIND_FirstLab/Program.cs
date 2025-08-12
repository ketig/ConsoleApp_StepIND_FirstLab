//MyDelegate myDelegate = Print;
//myDelegate("Hello, World!");
Action<string> action = Print;
action += Test;

action("Hello, World!");

action -= Print;
action("Hello, World!");

TestDelegate("Hello", 4, action);

//MyStringDelegate myStringDelegate = GetAge;
Func<bool, string> func = GetAge;
//MyBoolDelegate myBoolDelegate = IsAdult;
Predicate<int> predicate = IsAdult;

static string GetAge(bool isAdult)
{
    return isAdult ? "Adult." : "Minor";
}

static bool IsAdult(int age)
{
    return age < 18 ? false : true;
}

static void Print(string x)
{
    Console.WriteLine(x);
    Console.WriteLine("Print");
}

static void Test(string str)
{
    Console.WriteLine(str);
    Console.WriteLine("Test");
}

static void TestDelegate(string x, int a, Action<string> myDelegate)
{
    Console.WriteLine(x);
    myDelegate("This is a message from the delegate.");
}

//public delegate void MyDelegate(string message);
//public delegate string MyStringDelegate(bool isAdult);
//public delegate bool MyBoolDelegate(int age);
