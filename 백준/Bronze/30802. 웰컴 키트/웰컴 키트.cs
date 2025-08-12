long n = long.Parse(Console.ReadLine());

long[] size = Console.ReadLine().Split().Select(long.Parse).ToArray();
long[] tp = Console.ReadLine().Split().Select(long.Parse).ToArray();

long t = tp[0];
long p = tp[1];

long tBundle = 0;

foreach (long count in size)
{
    tBundle += (count + t - 1) / t;
}

long penBundle = n / p;
long penSize = n % p;

Console.WriteLine(tBundle);
Console.WriteLine($"{penBundle} {penSize}");