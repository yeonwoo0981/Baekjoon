int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int result = a * b * c;

int[] count = new int[10];

foreach (int ch in result.ToString())
{
    count[ch - '0']++;
}

for (int i = 0; i < count.Length; i++)
{
    Console.WriteLine(count[i]);
}