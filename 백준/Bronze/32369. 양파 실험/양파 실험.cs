int ching = 1;
int bi = 1;

string[] str = Console.ReadLine().Split();
int n = int.Parse(str[0]);
int a = int.Parse(str[1]);
int b = int.Parse(str[2]);
for (int i = 1; i <= n; i++)
{
    ching += a;
    bi += b;

    if (bi > ching)
    {
        int temp = ching;
        ching = bi;
        bi = temp;
    }
    else if (bi == ching)
    {
        bi -= 1;
    }
}
Console.WriteLine($"{ching} {bi}");