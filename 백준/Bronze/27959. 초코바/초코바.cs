string[] str = Console.ReadLine().Split();

int N = int.Parse(str[0]);
int M = int.Parse(str[1]);
if (N * 100 >= M)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
} 