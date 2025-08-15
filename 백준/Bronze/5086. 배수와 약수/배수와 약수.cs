while (true)
{
    string[] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);
    
    if (a == 0 && b == 0)
        break;
    
    if (b % a == 0)
    {
        Console.WriteLine("factor");
    }
    else if (a % b == 0)
    {
        Console.WriteLine("multiple");
    }
    else
    {
        Console.WriteLine("neither");
    }
}