int n = int.Parse(Console.ReadLine());
int[] count = new int[10001];

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    count[num]++;
}

using (StreamWriter sW = new StreamWriter(Console.OpenStandardOutput()))
{
    for (int i = 1; i <= 10000; i++)
    {
            for (int j = 0; j < count[i]; j++)
            {
                sW.WriteLine(i);
            }
        }
    }