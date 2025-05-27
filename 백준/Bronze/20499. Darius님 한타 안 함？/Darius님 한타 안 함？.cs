string[] str = Console.ReadLine().Split('/');
int k = int.Parse(str[0]);
int d = int.Parse(str[1]);
int a = int.Parse(str[2]);
if (k + a < d || d == 0)
{
    Console.WriteLine("hasu");
}
else
{
    Console.WriteLine("gosu");
}