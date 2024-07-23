Console.WriteLine("Veuillez introduire un premier nombre :");
string? reponse = Console.ReadLine();
int nb1;
bool isConverted = int.TryParse(reponse, out nb1);
Console.WriteLine("Veuillez introduire un second nombre :");
reponse = Console.ReadLine();
isConverted = int.TryParse(reponse, out int nb2);
Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");