using System.Text;

int n = int.Parse(Console.ReadLine());

var points = new List<(int x, int y)>();

for (int i = 0; i < n; i++)
{
    string[] xy = Console.ReadLine().Split(' ');
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);
    points.Add((x, y));
}

points.Sort((a, b) =>
{
    if (a.x != b.x) 
        return a.x.CompareTo(b.x);
    return a.y.CompareTo(b.y);
});

var sB = new StringBuilder();
foreach (var p in points)
{
    sB.Append(p.x).Append(' ').Append(p.y).Append('\n');
}

Console.WriteLine(sB.ToString());
