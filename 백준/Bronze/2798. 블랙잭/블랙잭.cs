string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

int[] blackJackCards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int maxSum = 0;

for (int i = 0; i < n - 2; i++)
{
    for (int j = i + 1; j < n - 1; j++)
    {
        for (int k = j + 1; k < n; k++)
        {
            int currentSum = blackJackCards[i] + blackJackCards[j] + blackJackCards[k];
            if (currentSum <= m && currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
    }
}

Console.WriteLine(maxSum);