// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez indiquer votre nom :");
string username = Console.ReadLine();
Console.Clear();
Console.WriteLine("Bienvenue {0}", username);
Console.WriteLine("En quelle année êtes-vous né?");
//int birthYear = int.Parse(Console.ReadLine());
int birthYear;
bool isConverted = int.TryParse(Console.ReadLine(), out birthYear);
Console.WriteLine($"Vous avez donc {DateTime.Now.Year - birthYear} ans!");