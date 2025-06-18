int aWin = 0;
int bWin = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    if (a > b)
    {
        aWin++;
    }
    else if (b > a)
    {
        bWin++;
    }
}

Console.WriteLine($"{aWin} {bWin}");