int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int[] kg = { a, b, c };
Array.Sort(kg);

Console.WriteLine(kg[1]);