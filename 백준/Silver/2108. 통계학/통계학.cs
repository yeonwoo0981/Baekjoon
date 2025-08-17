int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine()); 
}

Array.Sort(arr);

Console.WriteLine(arithmeticMean(arr));
Console.WriteLine(median(arr));
Console.WriteLine(lowestPrice(arr));
Console.WriteLine(range(arr));

static int arithmeticMean(int[] arr)
{
    long sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    
    double mean = (double)sum / arr.Length;
    int result = (int)Math.Round(mean, MidpointRounding.AwayFromZero);
    
    if (result == 0) return 0;
    return result;
}

static int median(int[] arr)
{
    return arr[arr.Length / 2];
}

static int lowestPrice(int[] arr)
{
    int[] count = new int[8001];
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] + 4000]++;
    }

    int maxFreq = 0;
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] > maxFreq)
            maxFreq = count[i];
    }
    
    int modeValue = 0;
    int found = 0;
    for (int i = 0; i < count.Length; i++)
    {
        if (count[i] == maxFreq)
        {
            modeValue = i - 4000;
            found++;
            if (found == 2) break;
        }
    }
    return modeValue;
}

static int range(int[] arr)
{
    return arr[arr.Length - 1] - arr[0];
}