string A = Console.ReadLine();
string B = Console.ReadLine();
string C = Console.ReadLine();

int a = int.Parse(A);
int b = int.Parse(B);
int c = int.Parse(C);
Console.WriteLine(a + b - c);

string concat = A + B;
int result = int.Parse(concat) - int.Parse(C);
Console.WriteLine(result);