string[] str = Console.ReadLine().Split();
long N = long.Parse(str[0]);
long M = long.Parse(str[1]);
long result = Math.Abs(N - M);

Console.WriteLine(result);
