using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

for (int i = n; i >= 1; i--)
{
    sb.AppendLine(i.ToString());
}

Console.Write(sb.ToString());
