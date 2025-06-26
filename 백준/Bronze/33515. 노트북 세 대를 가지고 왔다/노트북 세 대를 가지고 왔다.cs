string[] str = Console.ReadLine().Split(' ');
int t1 = int.Parse(str[0]);
int t2 = int.Parse(str[1]);
if (t1 < t2)
{
    Console.WriteLine(t1);
}
else if (t1 > t2)
{
    Console.WriteLine(t2);
}
else
{
    Console.WriteLine(t1);
}