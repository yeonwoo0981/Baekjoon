string[] str = Console.ReadLine().Split();
int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);
int d = int.Parse(str[3]);
int e = int.Parse(str[4]);
int verNum = (a * a + b * b + c * c + d * d + e * e) % 10;
Console.WriteLine(verNum);