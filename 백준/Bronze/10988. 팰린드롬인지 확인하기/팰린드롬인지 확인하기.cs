string str = Console.ReadLine();
string reStr = new string(str.Reverse().ToArray());
if (str == reStr)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}