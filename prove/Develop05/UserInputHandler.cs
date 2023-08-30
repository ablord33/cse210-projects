void AddNewGoal()
{
    Console.WriteLine("Choose the type of goal:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("0. Cancel");

    int option;
    if (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        return;
    }

    switch (option)
    {
        case 1:
            AddSimpleGoal();
            break;
        case 2:
            AddEternalGoal();
            break;
        case 3:
            AddChecklistGoal();
            break;
        case 0:
            Console.WriteLine("Goal addition canceled.");
            break;
        default:
            Console.WriteLine("Invalid option. Please choose a valid goal type.");
            break;
    }
}

void AddSimpleGoal()
{
    Console.WriteLine("Enter the name of the Simple Goal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the value of the Simple Goal:");
    if (!int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    Goal newGoal = new SimpleGoal(name, value);
    goalManager.AddGoal(newGoal);

    Console.WriteLine($"New Simple Goal '{name}' added!");
}

void AddEternalGoal()
{
    Console.WriteLine("Enter the name of the Eternal Goal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the value of the Eternal Goal:");
    if (!int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    Goal newGoal = new EternalGoal(name, value);
    goalManager.AddGoal(newGoal);

    Console.WriteLine($"New Eternal Goal '{name}' added!");
}

void AddChecklistGoal()
{
    Console.WriteLine("Enter the name of the Checklist Goal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the value of the Checklist Goal:");
    if (!int.TryParse(Console.ReadLine(), out int value))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    Console.WriteLine("Enter the target count for the Checklist Goal:");
    if (!int.TryParse(Console.ReadLine(), out int targetCount))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        return;
    }

    Goal newGoal = new ChecklistGoal(name, value, targetCount);
    goalManager.AddGoal(newGoal);

    Console.WriteLine($"New Checklist Goal '{name}' added!");
}
