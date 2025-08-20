namespace ConsoleApp_StepIND_FirstLab.Models.Vehicle
{
    internal class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public long Population { get; set; }
        public string Continent { get; set; }

        public Country(int countryId, string name, string capital, long population, string continent)
        {
            this.CountryId = countryId;
            Name = name;
            Capital = capital;
            Population = population;
            Continent = continent;
        }

        public override string ToString()
        {
            return $"{Name} - Capital: {Capital}, Population: {Population}, Continent: {Continent}";
        }
    }
}
