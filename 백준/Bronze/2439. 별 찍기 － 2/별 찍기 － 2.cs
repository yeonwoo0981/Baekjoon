int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(new string(' ', a - i) + new string('*', i));
}