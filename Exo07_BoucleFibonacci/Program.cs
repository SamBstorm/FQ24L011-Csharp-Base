int temp = 0;
int temp2 = 1;

Console.WriteLine($"F0 : {temp}");
Console.WriteLine($"F1 : {temp2}");

for (int i = 2; i <= 25; i++)
{
    temp += temp2;
    Console.WriteLine($"F{i} : {temp}");
    temp += temp2;
    temp2 = temp - temp2;
    temp -= temp2;
}