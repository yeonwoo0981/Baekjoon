var sr = new StreamReader(Console.OpenStandardInput());
var sw = new StreamWriter(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
    arr[i] = int.Parse(sr.ReadLine());

Array.Sort(arr);

for (int i = 0; i < n; i++)
    sw.WriteLine(arr[i]);

sw.Flush();