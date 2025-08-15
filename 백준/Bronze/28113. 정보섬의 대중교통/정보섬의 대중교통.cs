string[] str = Console.ReadLine().Split();
int n = int.Parse(str[0]);
int a = int.Parse(str[1]);
int b = int.Parse(str[2]);
if (b > a && b > n)
{
    Console.WriteLine("Bus");
}
else if (b == a)
{
    Console.WriteLine("Anything");
}
else if (a > b && a > n)
{
    Console.WriteLine("Subway");
}