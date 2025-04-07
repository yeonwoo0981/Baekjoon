 int T = int.Parse(Console.ReadLine());
 for (int x = 1; x <= T; x++)
 {
     string[] str = Console.ReadLine().Split();
     int A = int.Parse(str[0]);
     int B = int.Parse(str[1]);
     Console.WriteLine($"Case #{x}: {A + B}");
 }