string[] str = Console.ReadLine().Split(' ');
int A = int.Parse(str[0]);
int B = int.Parse(str[1]);
int C = int.Parse(Console.ReadLine());
int FM = B + C;
int FH = A;
if (FM >= 60)
{
    int late = FM / 60;
    FH += late;
    FM %= 60;
}
if (FH >= 24)
{
    FH %= 24;
}
Console.WriteLine($"{FH} {FM}");