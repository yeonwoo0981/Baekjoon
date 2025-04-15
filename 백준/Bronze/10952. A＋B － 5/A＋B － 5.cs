while (true)
{
    string[] str = Console.ReadLine().Split();
    int[] a = Array.ConvertAll(str, int.Parse);
    int A = a[0];
    int B = a[1];
    if (A == 0 && B == 0)
        break;
    Console.WriteLine(A + B);
}