int total = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                int price = int.Parse(input[0]);
                int quantity = int.Parse(input[1]);
                sum += price * quantity;
            }

            if (sum == total)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");