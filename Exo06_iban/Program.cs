Console.WriteLine("Veuillez introduire un numéro BBAN :");
string bban = Console.ReadLine();

//if (!(bban.Length == 12 && long.TryParse(bban, out _)))
if (bban.Length != 12 || !long.TryParse(bban, out _))
{
    Console.WriteLine("BBAN invalide...");
}
else
{
    string tenFirst = bban.Substring(0, 10);
    //string twoLast = bban.Substring(10, 2);
    string twoLast = bban.Substring(10);

    long tenFirstNb = long.Parse(tenFirst);
    short twoLastNb = short.Parse(twoLast);

    short modulo = (short)(tenFirstNb % 97);
    if (modulo == twoLastNb || (modulo == 0 && twoLastNb == 97))
    {
        Console.WriteLine("OK");
        string ibanControl = $"{twoLast}{twoLast}111400";
        long ibanControlNb = long.Parse(ibanControl);
        short codeIban = (short)(98 - (ibanControlNb % 97));
        Console.WriteLine($"BE{((codeIban<10)?"0":"")}{codeIban}{bban}");
    }
    else
    {
        Console.WriteLine("KO");
    }
}