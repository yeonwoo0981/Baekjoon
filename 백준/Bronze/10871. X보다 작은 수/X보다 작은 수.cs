using System;


class Program
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        int N = int.Parse(firstInput[0]);
        int X = int.Parse(firstInput[1]);

        
        string[] secondInput = Console.ReadLine().Split();

        
        for (int i = 0; i < N; i++)
        {
            int num = int.Parse(secondInput[i]);
            if (num < X)
            {
                Console.Write(num + " "); 
            }
        }
    }
}