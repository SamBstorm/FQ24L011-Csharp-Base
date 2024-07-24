for (short table = 1; table <= 5; table++)
{
    Console.WriteLine($"Table de {table} :");
    Console.WriteLine();
    for (short multi = 1; multi <= 20; multi++)
    {
        Console.WriteLine($"{table} X {multi} = {table * multi}");
    }
    Console.WriteLine();
}