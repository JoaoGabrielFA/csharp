void ShowWelcomeMessage()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

    ");
    Console.WriteLine("Welcome to Screen Sound!");
}

void ShowTitle(string titulo)
{
    int titleLength = titulo.Length;
    string asteriscos = string.Empty.PadLeft(titleLength, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ShowOptions()
{
    ShowWelcomeMessage();
    Console.WriteLine("\nPress 1 to register a band");
    Console.WriteLine("Press 2 to display all bands");
    Console.WriteLine("Press 3 to rate a band");
    Console.WriteLine("Press 4 to see the average rating of a band");
    Console.WriteLine("Press 0 to exit");

    Console.Write("\nEnter your option: ");
    string chosedOption = Console.ReadLine()!;
    int numericalChosenOption = int.Parse(chosedOption);

    switch (numericalChosenOption)
    {
        case 1: RegisterBand(); break;
        case 2: ShowRegisteredBands(); break;
        case 3: RateBand(); break;
        case 4: ShowAverageRating(); break;
        case 0: Environment.Exit(0); break;
        default: Console.WriteLine("\nInvalid option!"); break;
    }
}

void Continue(string message, Action action)
{
    Console.Write($"{message}, or any other key to return to the main menu! ");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    if (keyInfo.KeyChar == '+')
    {
        action();
    }
    else
    {
        Console.Clear();
        ShowOptions();
    }
}

void BackToMenu()
{
    Console.WriteLine("\nPress any key to return to the main menu");
    Console.ReadKey();
    Console.Clear();
    ShowOptions();
}

Dictionary<string, List<int>> bandList = new Dictionary<string, List<int>>();

void RegisterBand()
{
    Console.Clear();
    ShowTitle("Band Registration");
    Console.Write("Enter the name of the band you want to register: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName, new List<int>()); 
    Console.WriteLine($"\nThe band {bandName} has been successfully registered!");
    Continue($"\nPress (+) to add another band", RegisterBand);
}

void ShowRegisteredBands()
{
    Console.Clear();
    ShowTitle("Displaying all registered bands");
    if(bandList.Count > 0)
    {
        foreach (var band in bandList.Keys)
        {
            Console.WriteLine($"- {band}");
        }
    }
    else
    {
        Console.WriteLine("Any band are registered");
    }
    BackToMenu();
}

void RateBand()
{
    Console.Clear();
    ShowTitle("Rate a band");
    Console.Write("Enter the name of the band you want to rate: ");
    string bandName = Console.ReadLine()!;
    if (bandList.ContainsKey(bandName))
    {
        Console.Write($"\nWhat rating does the band {bandName} deserve: ");
        int rating = int.Parse(Console.ReadLine()!);
        if (rating > 0 && rating < 11){
            bandList[bandName].Add(rating);
            Console.WriteLine($"\nThe rating {rating} has been successfully recorded for the band {bandName}");
        }
        else
        {
            Console.WriteLine("\nThe rating must be between 0 and 10.");
            Continue($"\nPress (+) to try again", RateBand);
        }

    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} was not found!");
    }
    Continue($"\nPress (+) to rate another band", RateBand);
}

void ShowAverageRating()
{
    Console.Clear();
    ShowTitle("Average rate");
    Console.Write($"What band you want to see the rating: ");
    string bandName = Console.ReadLine()!;
    if (bandList.ContainsKey(bandName))
    {
        Console.WriteLine($"\nThe average rating for the band {bandName} is {bandList[bandName].Average()}.");
    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} was not found!");
    }
    Continue($"\nPress (+) to see another band average rating", ShowAverageRating);
}

ShowOptions();  
