int n = int.Parse(Console.ReadLine() ?? string.Empty);

HashSet<string> set = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    string? s = Console.ReadLine();
    if (s != null && s.Length == 0)
    {
        continue;
    }

    if (s != null) set.Add(s);
}

List<string> words = new List<string>(set);

words.Sort(new WordComparer());

for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}

class WordComparer : IComparer<string>
{
    public int Compare(string? a, string? b)
    {
        if (a != null && b != null && a.Length < b.Length) return -1;
        if (a != null && b != null && a.Length > b.Length) return 1;
        return string.CompareOrdinal(a, b);
    }
}