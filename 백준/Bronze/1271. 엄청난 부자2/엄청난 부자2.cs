using System.Numerics;
string[] str = Console.ReadLine().Split();
BigInteger n = BigInteger.Parse(str[0]);
BigInteger m = BigInteger.Parse(str[1]);
Console.WriteLine(n / m);
Console.WriteLine(n % m);