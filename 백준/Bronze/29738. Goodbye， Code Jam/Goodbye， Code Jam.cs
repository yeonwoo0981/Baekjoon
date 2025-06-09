int t = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= t; i++)
        {
            int n = int.Parse(Console.ReadLine()!);
            string result;

            if (n <= 25)
                result = "World Finals";
            else if (n <= 1000)
                result = "Round 3";
            else if (n <= 4500)
                result = "Round 2";
            else
                result = "Round 1";

            Console.WriteLine($"Case #{i}: {result}");
        }