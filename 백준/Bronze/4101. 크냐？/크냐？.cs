while (true)
{
    string input = Console.ReadLine();
    string[] numbers = input.Split();

    int a = int.Parse(numbers[0]);
    int b = int.Parse(numbers[1]);

    if (a == 0 && b == 0)
        break;

    Console.WriteLine(a > b ? "Yes" : "No");
}