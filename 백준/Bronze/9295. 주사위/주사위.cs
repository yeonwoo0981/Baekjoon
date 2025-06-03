int t = int.Parse(Console.ReadLine());
for (int x = 1; x <= t; x++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    Console.WriteLine($"Case {x}: {a+b}");
}