string[] str = Console.ReadLine().Split();
int A = int.Parse(str[0]);
int B = int.Parse(str[1]);
int C = int.Parse(str[2]);
if (A + B == C)
{
    Console.WriteLine("correct!");
}
else
{
    Console.WriteLine("wrong!");
}