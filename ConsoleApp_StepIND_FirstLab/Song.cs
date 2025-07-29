namespace ConsoleApp_StepIND_FirstLab
{
    internal class Song
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public double Rating { get; set; } // 0 - 5

        public Song()
        {
            Name = "Unknown";
            Composer = "Unknown";
        }

        public Song(string name, string composer, double rating)
        {
            Name = name;
            Composer = composer;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} by {Composer}, rating: {Rating}";
        }

        public static Song operator +(Song song1, Song song2)
        {
            return new Song(song1.Name + song2.Name,
                song1.Composer + ", " + song2.Composer,
                (song1.Rating + song2.Rating) / 2);
        }

        public static bool operator <(Song song1, Song song2)
        {
            return song1.Rating < song2.Rating;
        }

        public static bool operator >(Song song1, Song song2)
        {
            return song1.Rating > song2.Rating;
        }

        public static bool operator ==(Song song1, Song song2)
        {
            return song1.Rating == song2.Rating && song1.Name == song2.Name && song1.Composer == song2.Composer;
        }

        public static bool operator !=(Song song1, Song song2)
        {
            return song1.Rating != song2.Rating || song1.Name != song2.Name || song1.Composer != song2.Composer;
        }

        public static explicit operator string(Song song)
        {
            return song.Name;
        }
    }
}
