int fqx = int.Parse(Console.ReadLine());
int fqy = int.Parse(Console.ReadLine());
if (fqx > 0 && fqy > 0)
{
    Console.WriteLine('1');
}
else if (fqx < 0 && fqy > 0)
{
    Console.WriteLine('2');
}
else if (fqx < 0 && fqy < 0)
{
    Console.WriteLine('3');
}
else
{
    Console.WriteLine('4');
}
