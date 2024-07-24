//Console.WriteLine("Veuillez introduire votre année de naissance :");
//int birthYear = int.Parse(Console.ReadLine());
//int age = DateTime.Now.Year - birthYear;
//Console.WriteLine($"Vous avez donc {age} an{((age > 1) ? "s" : "")}.");

//Console.WriteLine($"Il est actuellement {DateTime.Now.Hour} : {((DateTime.Now.Minute < 10)? "0" : "")}{DateTime.Now.Minute}");

Console.WriteLine("Veuillez indiquer votre langue :");
string choix = Console.ReadLine() ?? "";
string salutation = choix switch
{
    "fr" => "Bonjour",
    "en" => "Hello",
    "nl" => "Goeiedag",
    _ => "Not found..."
};

Console.WriteLine(salutation);
