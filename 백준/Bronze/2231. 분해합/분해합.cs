int n = int.Parse(Console.ReadLine());

int digits = 0;
int tmp = n;

while (tmp > 0)
{
    digits++;
    tmp /= 10;
}

int start = Math.Max(1, n - 9 * digits);
int answer = 0;

for (int m = start; m < n; m++)
{
    int sum = m;
    int t = m;
    while (t > 0)
    {
        sum += t % 10;
        t /= 10;
    }
    if (sum == n)
    {
        answer = m;
        break;
    }
}
Console.WriteLine(answer);

