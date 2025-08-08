int[] inputs = new int[10];

for (int i = 0; i < inputs.Length; i++)
{
    string input = Console.ReadLine();
    int number = int.Parse(input);
    inputs[i] = number % 42;
}

int count = 0;

for (int i = 0; i < inputs.Length; i++)
{
    bool isDuplicate = false;
    
    for (int j = 0; j < i; j++)
    {
        if (inputs[i] == inputs[j])
        {
            isDuplicate = true;
            break;
        }
    }
    
    if (!isDuplicate)
    {
        count++;
    }
}

Console.WriteLine(count);

   