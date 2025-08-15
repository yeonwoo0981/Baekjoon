using System.Text;
using System.IO;

using var reader = new StreamReader(Console.OpenStandardInput());
        using var writer = new StreamWriter(Console.OpenStandardOutput());

        int t = int.Parse(reader.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < t; i++)
        {
            string[] input = reader.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            sb.AppendLine((a + b).ToString());
        }

        writer.Write(sb.ToString());