string[] str = Console.ReadLine().Split();
int T = int.Parse(str[0]);
int S = int.Parse(str[1]);
if ((12 <= T && T <= 16) && (S == 0))
{
    Console.WriteLine("320");
}
else
{
    Console.WriteLine("280");
}