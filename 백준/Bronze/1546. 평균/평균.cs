using System.Linq;

 int n = int.Parse(Console.ReadLine());
 double[] scores = Console.ReadLine().Split().Select(double.Parse).ToArray();

 double max = scores.Max();
 double newScore = scores.Select(score => score / max * 100).Average();

 Console.WriteLine(newScore);