

namespace baekjoon1
{   

    internal class Program
    {
        static void Main()
        {
            string color1 = Console.ReadLine(); 
            string color2 = Console.ReadLine(); 
            string color3 = Console.ReadLine(); 

            long num1 = ColorPlus(color1); 
            long num2 = ColorPlus(color2); 
            long multiplier = (long)ColorX(color3); 

            long result = (num1 * 10 + num2) * (long)multiplier;
            Console.WriteLine(result);
        }

        static long ColorPlus(string color)
        {
            if (color == "black") return 0;
            else if (color == "brown") return 1;
            else if (color == "red") return 2;
            else if (color == "orange") return 3;
            else if (color == "yellow") return 4;
            else if (color == "green") return 5;
            else if (color == "blue") return 6;
            else if (color == "violet") return 7;
            else if (color == "grey") return 8;
            else if (color == "white") return 9;
            else return -1;
        }

        static long ColorX(string color)
        {
            if (color == "black") return 1;
            else if (color == "brown") return 10;
            else if (color == "red") return 100;
            else if (color == "orange") return 1000;
            else if (color == "yellow") return 10000;
            else if (color == "green") return 100000;
            else if (color == "blue") return 1000000;
            else if (color == "violet") return 10000000;
            else if (color == "grey") return 100000000;
            else if (color == "white") return 1000000000;
            else return -1;
        }
    }

}

