// virtual
// abstract
Anime anime = new Anime("Naruto", 500, "Action");
Anime anime1 = new Anime();

Console.WriteLine($"How many episodes of '{anime.Title}' have you watched?");
string? input = Console.ReadLine();

if (int.TryParse(input, out int watchedEpisodes))
{
    anime.GetCurrentSeason(watchedEpisodes, out int season);
    if (season == 0)
    {
        Console.WriteLine("You haven't started watching yet.");
    }
    else
    {
        Console.WriteLine($"You're currently on season {season} of {anime.Title}.");
    }
}

public class Anime : Show
{
    public Anime() : base()
    {
        Console.Write("Enter anime name: ");
        Title = Console.ReadLine() ?? "Unknown Anime";
        Console.Write("Enter number of episodes: ");
        string? episodesInput = Console.ReadLine();
        Episodes = int.TryParse(episodesInput, out int episodes) ? episodes : 0;
        Console.Write("Enter genre: ");
        Genre = Console.ReadLine() ?? "Unknown Genre";
    }

    public Anime(string title, int episodes, string genre)
        : base(title)
    {
    }

    public void GetCurrentSeason(int episodesWatched, out int result)
    {
        if (episodesWatched < 0 || episodesWatched > Episodes)
        {
            result = 0;
        }
        else
        {
            result = (episodesWatched / 30) + 1;
        }
    }
}

public class Show
{
    private int _episodes;
    public string Title { get; set; }
    public int Episodes
    {
        get
        {
            return _episodes;
        }
        set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(Episodes), "Episodes must be between 0 and 10000.");
            }
            else
            {
                _episodes = value;
            }
        }
    }
    public string Genre { get; set; } // enum

    public Show()
    {
        Title = string.Empty;
        Episodes = 0;
        Genre = string.Empty;
    }

    public Show(string title)
    {
        Title = title;
    }

    public Show(string title, int episodes, string genre)
    {
        Title = title;
        Episodes = episodes;
        Genre = genre;
    }
}
