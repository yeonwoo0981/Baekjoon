static int choiDae(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static int choiSo(int a, int b)
{
    if (a == 0 || b == 0) return 0;
    return (a / choiDae(a, b)) * b; 
}

string[] inputs = Console.ReadLine().Split(' ');

int a = int.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

Console.WriteLine(choiDae(a, b));
Console.WriteLine(choiSo(a, b));
