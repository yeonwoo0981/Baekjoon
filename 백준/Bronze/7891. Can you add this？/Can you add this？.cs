int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);
    Console.WriteLine(a + b);
}