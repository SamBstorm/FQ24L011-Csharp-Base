Console.WriteLine("Hello! Bonjour! Goeiedag!");
Console.WriteLine(@"Please, choose your language :
Veuillez choisir votre langue :
Kies je taal, aub :");
string? choice = Console.ReadLine();

switch (choice)
{
    case "fr":
    case "français":
    case "french":
        Console.WriteLine("Vous avez choisi le français.");
        break;
    case "en":    
    case "english":
        Console.WriteLine("You choosen English.");
        break;
    case "du":
    case "dutch":
    case "nl":
    case "nederlands":
        Console.WriteLine("Je koos Nederlands.");
        break;
    default:
        Console.WriteLine(@"Sorry, we can't help you.
Désolé, nous ne pouvons vous aider.
Sorry, we kunnen niet helpen.");
        break;
}