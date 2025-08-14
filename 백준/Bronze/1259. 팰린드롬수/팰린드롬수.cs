while (true)
{
    int palindromNum = int.Parse(Console.ReadLine());
    
    if (palindromNum == 0)
        break;
    
    int reversedNum = new string(palindromNum.ToString().Reverse().ToArray())
        .Select(c => int.Parse(c.ToString()))
        .Aggregate(0, (acc, digit) => acc * 10 + digit);

    Console.WriteLine(palindromNum == reversedNum ? "yes" : "no");
}