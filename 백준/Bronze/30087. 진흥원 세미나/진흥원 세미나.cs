int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    string a = Console.ReadLine();
    switch (a)
    {
        case "Algorithm":
            Console.WriteLine("204");
            break;
        case "DataAnalysis":
            Console.WriteLine("207");
            break;
        case "ArtificialIntelligence":
            Console.WriteLine("302");
            break;
        case "CyberSecurity":
            Console.WriteLine("B101");
            break;
        case "Network":
            Console.WriteLine("303");
            break;
        case "Startup":
            Console.WriteLine("501");
            break;
        case "TestStrategy":
            Console.WriteLine("105");
            break;
    }
}