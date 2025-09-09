using System.Numerics;


namespace baekjoon1
{   

    internal class Program
    {
        static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            a %= 5;
            Console.WriteLine(a == 0 || a == 2 ? "CY" : "SK");
        }
    }

}

