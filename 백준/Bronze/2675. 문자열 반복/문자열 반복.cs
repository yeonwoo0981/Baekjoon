int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] str = Console.ReadLine().Split();
    int r = int.Parse(str[0]);
    string loopStr = str[1];
    string result = "";
    
    foreach (char c in loopStr)
    {
        for (int j = 0; j < r; j++)
        {
            result += c;
        }
    }
    Console.WriteLine(result);
}

