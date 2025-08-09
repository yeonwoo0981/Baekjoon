int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int h = int.Parse(input[0]);
    int w = int.Parse(input[1]);
    int n = int.Parse(input[2]);

    int floor = n % h;
    if (floor == 0)
        floor = h;
    
    int room = (n - 1)  / h + 1;

    Console.WriteLine(floor * 100 + room);
}