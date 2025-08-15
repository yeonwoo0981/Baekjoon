int n = int.Parse(Console.ReadLine());
string[] str = Console.ReadLine().Split();
int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);

int result = Math.Min(n, a) + Math.Min(n, b) + Math.Min(n, c);
Console.WriteLine(result); 