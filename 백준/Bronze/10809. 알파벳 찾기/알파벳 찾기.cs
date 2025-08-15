string s = Console.ReadLine();
int[] abcArr = new int[26];
Array.Fill(abcArr, -1);

for (int i = 0; i < s.Length; i++)
{
    int index = s[i] - 'a';
    if (abcArr[index] == -1)
    {
        abcArr[index] = i;
    }
}

Console.WriteLine(string.Join(" ", abcArr));