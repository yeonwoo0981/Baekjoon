int n = int.Parse(Console.ReadLine());
bool[] sG = new bool[1001];


sG[1] = true;
sG[2] = false;
sG[3] = true;


for (int i = 4; i <= n; i++)
{
    sG[i] = !sG[i - 1] || !sG[i - 3];
}

Console.WriteLine(sG[n] ? "SK" : "CY");