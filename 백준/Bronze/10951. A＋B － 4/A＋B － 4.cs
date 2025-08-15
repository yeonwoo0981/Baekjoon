string input;
while ((input = Console.ReadLine()) != null)
{
    string[] numbers = input.Split();
    int A = int.Parse(numbers[0]);
    int B = int.Parse(numbers[1]);
    Console.WriteLine(A + B);

}