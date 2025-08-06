string input = Console.ReadLine();

string[] parts = input.Split(' ');
int[] numbers = new int[8];

for (int i = 0; i < 8; i++)
{
    numbers[i] = int.Parse(parts[i]);
}

bool ohRem = true;
for (int i = 0; i < 7; i++)
{
    if (numbers[i] + 1 != numbers[i + 1])
    {
        ohRem = false;
        break;
    }
}

bool naeRim = true;
for (int i = 0; i < 7; i++)
{
    if (numbers[i] - 1 != numbers[i + 1])
    {
        naeRim = false;
        break;
    }
}

if (ohRem)
{
    Console.WriteLine("ascending");
}
else if (naeRim)
{
    Console.WriteLine("descending");
}
else
{
    Console.WriteLine("mixed");
}