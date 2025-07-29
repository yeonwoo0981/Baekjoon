string[] str = Console.ReadLine().Split();
long a = long.Parse(str[0]);
long b = long.Parse(str[1]);
long aBig = Math.Max(a, b);
long bBig = Math.Min(a, b);

List<long> betweenStr = new List<long>();
for (long i = bBig + 1; i < aBig; i++)
{
    betweenStr.Add(i);
}

Console.WriteLine(betweenStr.Count);

if (betweenStr.Count > 0)
    Console.WriteLine(string.Join(" ", betweenStr));
else
    Console.WriteLine();