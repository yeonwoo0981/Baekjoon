string[] a = Console.ReadLine().Split();
int S = int.Parse(a[0]);
int K = int.Parse(a[1]);
int H = int.Parse(a[2]);
if ((S + K + H < 100) && (S < K && S < H))
{
    Console.WriteLine("Soongsil");
}
else if ((S + K + H < 100) && (K < S && K < H))
{
    Console.WriteLine("Korea");
}
else if ((S + K + H < 100) && (H < S && H < K))
{
    Console.WriteLine("Hanyang");
}
else if (S + K + H >= 100)
{
    Console.WriteLine("OK");
}