 int T = int.Parse(Console.ReadLine());
 for (int i = 1; i <= T; i++)
 {
     string[] str = Console.ReadLine().Split();
     int A = int.Parse(str[0]);
     int B = int.Parse(str[1]);
     Console.WriteLine(A + B);
 }