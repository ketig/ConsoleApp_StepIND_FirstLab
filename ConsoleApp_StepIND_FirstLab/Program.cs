using ConsoleApp_StepIND_FirstLab;

Song song = new Song();
song.Name = "Song Name";
song.Composer = "Composer Name";
song.Rating = 4.5;

Song song1 = new Song("name", "comp", 4.1);


Song song2 = song + song1;


string name = (string)song;
