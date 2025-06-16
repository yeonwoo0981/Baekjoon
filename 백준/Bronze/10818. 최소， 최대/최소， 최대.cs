int n = int.Parse(Console.ReadLine()); 
string[] str = Console.ReadLine().Split(); 
int min = int.MaxValue;
int max = int.MinValue;
for (int i = 0; i < n; i++)
{
    int num = int.Parse(str[i]);
    if (num < min) min = num;
    if (num > max) max = num;
}
Console.WriteLine($"{min} {max}");