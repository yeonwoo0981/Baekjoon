int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] it = Console.ReadLine().Split(',');
    int a = int.Parse(it[0]);
    int b = int.Parse(it[1]);
    Console.WriteLine(a + b);
}