int nb;
do
{
    Console.WriteLine("Veuillez introduire le nombre de nombre premier à afficher : ");
} while (!int.TryParse(Console.ReadLine(), out nb) || nb < 0);


for (int count = 0, nbTeste = 2; count < nb; nbTeste++)
{
    bool moreDiv = false;
    for (int diviseur = 2; diviseur <= (nbTeste/2) && !moreDiv; diviseur++)
    {
        if(nbTeste % diviseur == 0) moreDiv = true;
    }
    if(!moreDiv)
    {
        Console.WriteLine(nbTeste);
        count++;
    }
}