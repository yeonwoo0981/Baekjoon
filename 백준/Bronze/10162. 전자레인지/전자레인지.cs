int t = int.Parse(Console.ReadLine());
int a = 300;
int b = 60;
int c = 10;

if (t % 10 != 0)
{
    Console.WriteLine("-1");
    return;
}
int aCount = t / a;
t %= a;

int bCount = t / b;
t %= b;

int cCount = t / c;

Console.WriteLine($"{aCount} {bCount} {cCount}");