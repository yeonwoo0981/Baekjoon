int n = int.Parse(Console.ReadLine());

var members = new (int age, string name, int order)[n];

for (int i = 0; i < n; i++)
{
    string[] str = Console.ReadLine().Split();
    members[i] = (int.Parse(str[0]), str[1], i);
}

Array.Sort(members, (x, y) => {
    if (x.age != y.age) return x.age.CompareTo(y.age);
    return x.order.CompareTo(y.order);
});

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{members[i].age} {members[i].name}");
}