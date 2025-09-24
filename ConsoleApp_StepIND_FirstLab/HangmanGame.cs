namespace ConsoleApp_StepIND_FirstLab
{
    internal static class HangmanGame
    {
        private static List<string> words = new List<string>
        {
            "example",
            "hangman",
            "programming",
            "challenge",
            "development"
        };
        private static Random random = new Random();
        private static string fileDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName ?? string.Empty;

        private static void LoadDefaultWords()
        {
            words = new List<string>
            {
                "example",
                "hangman",
                "programming",
                "challenge",
                "development"
            };
        }

        private static void LoadWordsFromFile(string fileDir, string fileName = "words.txt")
        {
            string filePath = Path.Combine(fileDir, fileName);
            try
            {
                if (File.Exists(filePath))
                {
                    string[] fileWords = File.ReadAllLines(fileName);
                    words = fileWords
                        .Where(word => !string.IsNullOrWhiteSpace(word))
                        .Select(word => word.Trim().ToLower())
                        .ToList();

                    if (words.Count == 0)
                    {
                        Console.WriteLine("Warning: No valid words found in file. Using default words.");
                        LoadDefaultWords();
                    }
                    else
                    {
                        Console.WriteLine($"Loaded {words.Count} words from {fileName}");
                    }
                }
                else
                {
                    Console.WriteLine($"Warning: File '{fileName}' not found. Using default words.");
                    LoadDefaultWords();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file '{fileName}': {ex.Message}");
                Console.WriteLine("Using default words.");
                LoadDefaultWords();
            }
        }

        public static void Start()
        {
            LoadWordsFromFile(fileDir);
            int attemptsLeft = 10;
            char input;
            List<char> usedLetters = new List<char>();
            string secretWord = words[random.Next(words.Count)];

            char[] guessedWord = new string('_', secretWord.Length).ToCharArray();

            Console.WriteLine("Welcome to the Hangman! The word guessing game!");
            Console.WriteLine($"Attempts left : {attemptsLeft}.");

            while (attemptsLeft > 0 && new string(guessedWord) != secretWord)
            {
                Console.WriteLine(new string(guessedWord));
                Console.Write("Enter a letter: ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (!char.IsLetter(input))
                {
                    Console.WriteLine("Please enter a valid letter.");
                    continue;
                }

                if (usedLetters.Contains(input))
                {
                    Console.WriteLine("This char was already used!");
                    continue;
                }

                if (secretWord.ToLower().Contains(input.ToString().ToLower()))
                {
                    Console.WriteLine("Correct letter");
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i].ToString().ToLower() == input.ToString().ToLower())
                        {
                            guessedWord[i] = secretWord[i];
                        }
                    }
                }
                else
                {
                    attemptsLeft--;
                    Console.WriteLine("Incorrect letter, try again: ");
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                }

                usedLetters.Add(input);
            }

            if (new string(guessedWord) == secretWord)
            {
                Console.WriteLine("You won!");
            }
            else if (attemptsLeft == 0)
            {
                Console.WriteLine("You lost!");
                Console.WriteLine($"The secret word was: {secretWord}");
            }
        }
    }
}
