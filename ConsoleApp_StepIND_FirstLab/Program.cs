using ConsoleApp_StepIND_FirstLab.Models.Vehicle;

List<Country> countries = new List<Country>
{
    new Country(1, "Georgia", "Tbilisi", 3714000, "Asia"),
    new Country(2, "Germany", "Berlin", 83240000, "Europe"),
    new Country(3, "Japan", "Tokyo", 125700000, "Asia"),
    new Country(4, "Brazil", "Brasília", 215300000, "South America"),
    new Country(5,"Canada", "Ottawa", 38930000, "North America"),
    new Country(6,"Australia", "Canberra", 26000000, "Oceania"),
    new Country(7,"Kenya", "Nairobi", 53770000, "Africa"),
    new Country(8,"India", "New Delhi", 1408000000, "Asia"),
    new Country(9,"France", "Paris", 68000000, "Europe"),
    new Country(10,"Egypt", "Cairo", 109300000, "Africa")
};
List<Car> cars = new List<Car>
        {
            new Car { Speed = 120, CountryId = 1 },
            new Car { Speed = 150, CountryId = 2 },
            new Car { Speed = 180, CountryId = 3 },
            new Car { Speed = 200, CountryId = 4 },
            new Car { Speed = 90,  CountryId = 5 },
            new Car { Speed = 130, CountryId = 6 },
            new Car { Speed = 175, CountryId = 7 },
            new Car { Speed = 110, CountryId = 8 },
            new Car { Speed = 95,  CountryId = 9 },
            new Car { Speed = 220, CountryId = 10 },
            new Car { Speed = 160, CountryId = 11 },
            new Car { Speed = 145, CountryId = 10 },
            new Car { Speed = 170, CountryId = 3 },
            new Car { Speed = 80,  CountryId = 14 },
            new Car { Speed = 140, CountryId = 15 },
            new Car { Speed = 190, CountryId = 6 },
            new Car { Speed = 210, CountryId = 17 },
            new Car { Speed = 100, CountryId = 18 },
        };

// join the two lists
var joinedList =
    from car in cars
    join country in countries on car.CountryId equals country.CountryId
    select new
    {
        car.Speed,
        CountryName = country.Name,
        country.Capital,
    };

foreach (var item in joinedList)
{
    Console.WriteLine($"Speed: {item.Speed}, Country: {item.CountryName}, Capital: {item.Capital}");
}
