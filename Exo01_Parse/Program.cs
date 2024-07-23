Console.WriteLine("Veuillez introduire un premier nombre :");
string? reponse = Console.ReadLine();
int nb1 = int.Parse(reponse);
Console.WriteLine("Veuillez introduire un second nombre :");
reponse = Console.ReadLine();
int nb2 = int.Parse(reponse);
Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");