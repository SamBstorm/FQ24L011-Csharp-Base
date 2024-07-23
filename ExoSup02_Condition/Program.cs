Console.WriteLine("Veuillez indiquer la taille du premier côté :");
string? reponse = Console.ReadLine();
bool isConverted = int.TryParse(reponse, out int coteA);
if (!isConverted || coteA == 0)
{
    Console.WriteLine("Opération impossible");
}
else
{
    if(coteA < 0)
    {
        coteA = 0 - coteA;
        //coteA = coteA * -1;
        //coteA = Math.Abs(coteA);
    }
    Console.WriteLine("Veuillez indiquer la taille du second côté :");
    reponse = Console.ReadLine();
    isConverted = int.TryParse(reponse, out int coteB);
    if (!isConverted || coteB == 0)
    {
        Console.WriteLine("Opération impossible");
    }
    else
    {
        if (coteB < 0)
        {
            coteB = 0 - coteB;
        }
        if (coteA < coteB)
        {
            coteA = coteA + coteB;
            coteB = coteA - coteB;
            coteA = coteA - coteB;
        }
    }
    Console.WriteLine("Veuillez indiquer la taille du dernier côté :");
    reponse = Console.ReadLine();
    isConverted = int.TryParse(reponse, out int coteC);
    if (!isConverted || coteC == 0)
    {
        Console.WriteLine("Opération impossible");
    }
    else
    {
        if (coteC < 0)
        {
            coteC = 0 - coteC;
        }
        if (coteA < coteC)
        {
            coteA = coteA + coteC;
            coteC = coteA - coteC;
            coteA = coteA - coteC;
        }
        if (coteA >= coteB + coteC)
        {
            Console.WriteLine("Triangle impossible");
        }
        else
        {
            if (coteA == coteB && coteA == coteC)
            {
                Console.WriteLine("Triangle équilatérale acutangle");
            }
            else
            {
                if (coteA == coteB || coteA == coteC || coteB == coteC)
                {
                    Console.Write("Triangle isocèle ");
                }
                else
                {
                    Console.Write("Triangle scalène ");
                }
                //if(Math.Pow(coteA, 2) == Math.Pow(coteB, 2) + Math.Pow(coteC, 2))
                if ((coteA * coteA) == (coteB * coteB) + (coteC * coteC))
                {
                    Console.WriteLine("rectangle");
                }
                else if ((coteA * coteA) > (coteB * coteB) + (coteC * coteC))
                {
                    Console.WriteLine("obtusangle");
                }
                else
                {
                    Console.WriteLine("acutangle");
                }
            }
        }
    }
}