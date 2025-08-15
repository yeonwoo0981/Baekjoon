char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'M':
                    Console.WriteLine("MatKor");
                    break;
                case 'W':
                    Console.WriteLine("WiCys");
                    break;
                case 'C':
                    Console.WriteLine("CyKor");
                    break;
                case 'A':
                    Console.WriteLine("AlKor");
                    break;
                case '$':
                    Console.WriteLine("$clear");
                    break;
            }