using System;

class Program
{
    private List<Word> words;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        // Load the scriptures from a file or any other source
        List<Scripture> scriptures = LoadScriptures();

        // Select a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // Split the scripture text into words
        words = new List<Word>();
        string[] wordStrings = scripture.Text.Split(' ');
        foreach (string wordString in wordStrings)
        {
            words.Add(new Word(wordString));
        }

        // Display the complete scripture
        DisplayScripture(scripture);

        // Prompt the user to press Enter or type "quit"
        while (HasHiddenWords())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            HideRandomWords();
            ClearConsole();
            DisplayScripture(scripture);
        }
    }

    private void ClearConsole()
    {
        Console.Clear();
    }

    private void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.Reference);
        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("***** ");
            else
                Console.Write($"{word.Text} ");
        }
        Console.WriteLine();
    }

    private void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in words)
        {
            if (!word.IsHidden)
            {
                if (random.Next(2) == 0) // Hide 50% of the words
                {
                    word.IsHidden = true;
                }
            }
        }
    }

    private bool HasHiddenWords()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden)
                return true;
        }
        return false;
    }

    // Method to load scriptures from a file or any other source
    private List<Scripture> LoadScriptures()
    {
        // Replace this with your implementation to load scriptures
        // from a file or any other source
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thy own understanding. In all thy ways acknowledge him, and he shall direct thy paths"));

        return scriptures;
    }
}
