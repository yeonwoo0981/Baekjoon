static long factorial(long n)
{
    if (n <= 1)
        return 1;
    return n * factorial(n - 1);
}

long number = long.Parse(Console.ReadLine());
long factorialResult = factorial(number);
Console.WriteLine(factorialResult);