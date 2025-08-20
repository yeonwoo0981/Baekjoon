int t = int.Parse(Console.ReadLine());

for (int j = 0; j < t; j++)
{
    int k = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    
    int[] prev = new int[n + 1];
    for (int i = 1; i <= n; i++) prev[i] = i;

    for (int floor = 1; floor <= k; floor++)
    {
        int[] curr = new int[n + 1];
        int prefix = 0;
        for (int room = 1; room <= n; room++)
        {
            prefix += prev[room];
            curr[room] = prefix;
        }
        prev = curr;
    }
    Console.WriteLine(prev[n]);
}