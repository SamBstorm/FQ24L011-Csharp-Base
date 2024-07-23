Console.WriteLine("Veuillez entrer un nombre entier :");
string? reponse = Console.ReadLine();
int nb1;
bool isConverted = int.TryParse(reponse, out nb1);
if (isConverted)
{
    if((nb1 / 2) + (nb1 / 2) == nb1)
    {
        Console.WriteLine($"Le nombre {nb1} est paire.");
    }
    else
    {
        Console.WriteLine($"Le nombre {nb1} est impaire.");
    }
}
else
{
    Console.WriteLine($"\"{reponse}\" n'est pas un nombre.");
}