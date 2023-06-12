using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        // Load the scriptures from a file or any other source
        Scripture scripture = LoadRandomScripture();

        // Display the complete scripture
        DisplayScripture(scripture);

        // Prompt the user to press Enter or type "quit"
        while (scripture.HasHiddenWords())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords();
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
        foreach (Word word in scripture.GetWords())
        {
            if (word.IsHidden)
                Console.Write("***** ");
            else
                Console.Write($"{word.GetDisplayText()} ");
        }
        Console.WriteLine();
    }

    private Scripture LoadRandomScripture()
    {
        // Replace this with your implementation to load scriptures
        // from a file or any other source
        Random random = new Random();
        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        scripture.HideRandomWords(random);
        return scripture;
    }
}
