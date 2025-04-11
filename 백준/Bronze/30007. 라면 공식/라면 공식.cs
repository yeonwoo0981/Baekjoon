int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    string[] input = Console.ReadLine().Split();
    int A = int.Parse(input[0]);
    int B = int.Parse(input[1]);
    int X = int.Parse(input[2]);
    int W = A * (X - 1) + B;
    Console.WriteLine(W);
}