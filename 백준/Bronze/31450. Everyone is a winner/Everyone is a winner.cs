string[] str = Console.ReadLine().Split();
        long m = long.Parse(str[0]);
        long k = long.Parse(str[1]);

        if (m % k == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }