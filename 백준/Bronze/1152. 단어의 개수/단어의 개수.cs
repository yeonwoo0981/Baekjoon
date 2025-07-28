int word = 0;
string str = Console.ReadLine();
string[] wordSplit = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
word = wordSplit.Length;
Console.WriteLine(word);