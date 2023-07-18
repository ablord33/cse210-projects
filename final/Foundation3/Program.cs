class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St, City A, Country A");
        Address address2 = new Address("456 Elm St, City B, Country B");
        Address address3 = new Address("789 Oak St, City C, Country C");

        Lecture lecture = new Lecture("Python Programming", "Introduction to Python programming language", "2023-07-20", "10:00 AM", address1, "John Doe", 100);
        Reception reception = new Reception("Networking Event", "Networking event for professionals", "2023-07-21", "6:00 PM", address2, "info@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "Family-friendly picnic in the park", "2023-07-22", "12:00 PM", address3);

        // Generating marketing messages
        Console.WriteLine("Lecture - Standard Details:");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Lecture - Full Details:");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Lecture - Short Description:");
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception - Standard Details:");
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Reception - Full Details:");
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Reception - Short Description:");
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering - Standard Details:");
        Console.WriteLine(outdoorGathering.GenerateStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering - Full Details:");
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering - Short Description:");
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}
