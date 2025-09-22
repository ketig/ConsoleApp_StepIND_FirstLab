// Github ??
// File
// Comments

Console.WriteLine();

class Example
{
    private static List<string> words = new List<string>();

    /// <summary>
    /// Open file and read all lines
    /// </summary>
    static Example()
    {
        using (StreamReader sr = new StreamReader("words.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                words.Add(line);
            }
        }
    }
}
