 int t = int.Parse(Console.ReadLine());
 for (int i = 0; i < t; i++)
 {
     
     for (int j = 0; j < i; j++)
     {
         Console.Write(" ");
     }
     for (int k = 0; k < t - i; k++)
     {
         Console.Write("*");
     }
     Console.WriteLine();
 }