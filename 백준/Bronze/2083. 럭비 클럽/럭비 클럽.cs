while (true)
{
    string input = Console.ReadLine();
    if (input == null) continue;

    string[] parts = input.Split();
    string name = parts[0];
    int age = int.Parse(parts[1]);
    int weight = int.Parse(parts[2]);

    if (name == "#" && age == 0 && weight == 0)
        break;

    if (age > 17 || weight >= 80)
        Console.WriteLine($"{name} Senior");
    else
        Console.WriteLine($"{name} Junior");
}