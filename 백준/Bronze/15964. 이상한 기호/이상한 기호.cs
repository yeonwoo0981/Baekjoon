string[] input = Console.ReadLine().Split();
long A = long.Parse(input[0]);
long B = long.Parse(input[1]);
long R = (A + B) * (A - B);
Console.WriteLine(R);