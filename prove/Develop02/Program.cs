using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        Journal journal = new Journal();
        while (true)
        {
            Console.WriteLine("Enter 'a' to add an entry, 'v' to view all entries, or 'q' to quit:");
            string userChoice = Console.ReadLine();

            if (userChoice == "q")
            {
                break; // Exit the loop and end the program
            }
            else if (userChoice == "a")
            {
                Console.WriteLine("Enter the filename for the entry:");
                string userFilename = Console.ReadLine();
                journal.AddEntry(userFilename);
            }
            else if (userChoice == "v")
            {
                journal.Display();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
