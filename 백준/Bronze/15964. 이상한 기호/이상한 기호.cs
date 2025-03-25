string[] input = Console.ReadLine().Split();
int A = int.Parse(input[0]);
int B = int.Parse(input[1]);
int R = (A + B) * (A - B);
Console.WriteLine(R);