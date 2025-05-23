 string[] str = Console.ReadLine().Split();
 int a = int.Parse(str[0]);
 int b = int.Parse(str[1]);
 int c = int.Parse(Console.ReadLine());
 int r = a + b;
 int co = c * 2;
 if (r >= co)
 {
     Console.WriteLine(r - co);
 }
 else
 {
     Console.WriteLine(r);
 }