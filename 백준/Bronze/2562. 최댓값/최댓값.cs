int max = 0;
int Index = 0;

for (int i = 1; i <= 9; i++)
{
    int num = int.Parse(Console.ReadLine());
    if (num > max)
    {
        max = num;
        Index = i;
    }
}

Console.WriteLine(max);
Console.WriteLine(Index);
