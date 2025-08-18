namespace ConsoleApp_StepIND_FirstLab.Events
{
    //Event
    //მომხმარებელი შემოიყვანს სახელს, შემდეგ კი აპლიკაცია აჩვენებს შეტყობინებას "მოგესალმებით მათ სახელზე".  
    //ჯეკი, სტივენი და მეთიუ აკრძალულია ორგანიზაციისთვის. ასე რომ, 
    //როდესაც რომელიმე მომხმარებელს შეყავს ჯეკ, სტივენ და მეთიუ მომხმარებლის სახელად, 
    //აპლიკაციამ გაფრთხილება დაწეროს, ასევე უგზავნის ელ.წერილს ადმინისტრაციას (უბრალოდ კონსოლში დაბეჭდეთ).

    namespace Events
    {
        static class Program
        {
            public static readonly List<string> NamesNotAllowed = new List<string>() { "Jack", "Steven", "Mathew" };

            public static void Main(string[] args)
            {
                string name;

                Console.Write("Enter name: ");
                name = Console.ReadLine() ?? string.Empty;

                UserSystem userSystem = new UserSystem();
                userSystem.UserEntered += () =>
                {
                    if (VerifyName(name))
                    {
                        Console.WriteLine($"Welcome{name}");
                    }
                    else
                    {
                        Console.WriteLine("You are not allowed!");
                    }
                };
                userSystem.OnUserEntered();
            }

            public static bool VerifyName(string name)
            {
                if (NamesNotAllowed.Contains(name))
                {
                    return false;
                }

                return true;
            }
        }

        class UserSystem
        {
            public event Action UserEntered;

            public void OnUserEntered()
            {
                UserEntered?.Invoke();
            }
        }
    }
}
