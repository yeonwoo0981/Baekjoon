string str = Console.ReadLine();
string reStr = new string(str.Reverse().ToArray());
Console.WriteLine(str == reStr ? 1 : 0);