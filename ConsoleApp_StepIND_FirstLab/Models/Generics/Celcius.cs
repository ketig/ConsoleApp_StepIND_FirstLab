namespace ConsoleApp_StepIND_FirstLab.Models.Generics
{
    class Celcius
    {
        public int Degree { get; set; }
        public string City { get; set; }

        public static explicit operator int(Celcius temp)
        {
            return temp.Degree;
        }

        public static implicit operator Fahrenheit(Celcius temp)
        {
            return new Fahrenheit { Degree = (int)(temp.Degree * 9.0 / 5.0 + 32) };
        }
    }
}

//Dictionary<string, string> capitals = new Dictionary<string, string>
//{
//    { "USA", "Washington" },
//    { "Canada", "Ottawa" },
//    { "Mexico", "Mexico City" }
//};

//capitals["USA"] = "Washington, D.C."; // update value
//capitals.Add("UK", "London"); // add value


//Celcius temperature = new Celcius { Degree = 25 };
//int x = (int)temperature; // explicit conversion to int
