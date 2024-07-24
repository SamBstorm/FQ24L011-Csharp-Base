Console.WriteLine("Veuillez introduire un premier nombre entier :");
bool isConverted = int.TryParse(Console.ReadLine(), out int nb1);
if (!isConverted)
{
    Console.WriteLine("Ce n'est pas un nombre entier.");
}
else
{
    Console.WriteLine("Veuillez introduire un second nombre entier :");
    isConverted = int.TryParse(Console.ReadLine(), out int nb2);
    if (!isConverted)
    {
        Console.WriteLine("Ce n'est pas un nombre entier.");
    }
    else
    {
        int divInt = nb1 / nb2;
        int modulo = nb1 % nb2;
        double divClassic = (double) nb1 / nb2;
        Console.WriteLine($"Pour les nombres {nb1} et {nb2}\nLa division entière est : {divInt}\nLe reste de la division est : {modulo}\nLa division classique est : {divClassic}");
    }
}
