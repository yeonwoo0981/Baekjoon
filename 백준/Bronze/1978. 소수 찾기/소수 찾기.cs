class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input[i]);
            if (IsPrime(num))
            {
                count++;
            }
        }


        Console.WriteLine(count);
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }

        return true;
    }
}