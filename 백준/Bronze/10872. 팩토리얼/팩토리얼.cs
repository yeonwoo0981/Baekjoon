int N = int.Parse(Console.ReadLine());
long result = 1;
for (int i = 1; i <=N; i++)
{
    result *= i;
}
Console.WriteLine(result);