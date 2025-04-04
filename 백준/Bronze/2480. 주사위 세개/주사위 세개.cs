string[] str = Console.ReadLine().Split();
int[] a = Array.ConvertAll(str, int.Parse);
if (a[0] == a[1] && a[1] == a[2])
{
    Console.WriteLine(10000 + a[0] * 1000);
}
else if (a[0] == a[1] || a[1] == a[2] || a[2] == a[0])
{
    if (a[0] == a[1])
    {
        Console.WriteLine(1000 + a[0] * 100);
    }
    if (a[1] == a[2])
    {
        Console.WriteLine(1000 + a[1] * 100);
    }
    if (a[2] == a[0])
    {
        Console.WriteLine(1000 + a[0] * 100);
    }
}
else
{
    int max = a[0];
    if (a[1] > max)
        max = a[1];
    if (a[2] > max)
        max = a[2];
    Console.WriteLine(max * 100);
}