const int MIN = 1;
const int MAX = 10;
Console.WriteLine($"Veuillez introduire un premier nombre (compris entre {MIN} et {MAX}) :");
string? reponse = Console.ReadLine();
int nb1;
bool isConverted = int.TryParse(reponse, out nb1);
if (isConverted && nb1 >= MIN && nb1 <= MAX)
{
    Console.WriteLine($"Veuillez introduire un second nombre (compris entre {MIN} et {MAX}) :");
    reponse = Console.ReadLine();
    if (int.TryParse(reponse, out int nb2) && !(nb2 < MIN || nb2 > MAX))
    {
        Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
    }
    else
    {
        Console.WriteLine("Mauvaise entrée...");
    }
}
else
{
    Console.WriteLine("Mauvaise entrée...");
}