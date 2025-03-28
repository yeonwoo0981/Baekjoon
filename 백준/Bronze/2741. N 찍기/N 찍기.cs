using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Console.ReadLine()의 반환값이 null일 수 있으므로 null 병합 연산자를 사용합니다.
        string? input = Console.ReadLine();
        int N = int.Parse(input ?? "0");
        
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= N; i++)
        {
            sb.AppendLine(i.ToString());
        }

        Console.Write(sb.ToString());
    }
}