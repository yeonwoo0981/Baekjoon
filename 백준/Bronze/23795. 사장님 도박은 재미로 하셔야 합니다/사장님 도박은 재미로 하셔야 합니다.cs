

namespace baekjoon1
{   

    internal class Program
    {
        static void Main()
        {
            int result = 0;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == -1)
                    break;
                result += n;
            }
            Console.WriteLine(result);
        }
    }

}

