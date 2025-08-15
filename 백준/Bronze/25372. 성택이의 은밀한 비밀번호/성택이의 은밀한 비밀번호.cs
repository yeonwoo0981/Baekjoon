int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    string str = Console.ReadLine();
    if (str.Length >= 6 && str.Length <= 9)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}