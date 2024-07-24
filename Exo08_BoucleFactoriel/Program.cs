int nb;
do
{
    Console.WriteLine("Veuillez introduire un nombre entier : ");
} while (!int.TryParse(Console.ReadLine(), out nb) || nb > 20 || nb < 1);

ulong result = 1;

for (uint count = 2; count <= nb; count++)
{
    result = checked( result * count );
}
Console.WriteLine($"Le factoriel de {nb} est {result}!");