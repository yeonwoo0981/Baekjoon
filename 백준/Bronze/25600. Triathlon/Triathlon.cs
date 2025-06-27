int n = int.Parse(Console.ReadLine());

int score = 0;


for (int i = 1; i <= n; i++)
{
    string[] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int d = int.Parse(str[1]);
    int g = int.Parse(str[2]);
    
    int bestscore = a * (d + g);
    if (a == d + g)
    {
        bestscore *= 2;
    }

    if (bestscore > score)
        score = bestscore;
}

Console.WriteLine(score);
