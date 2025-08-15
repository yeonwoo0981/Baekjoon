string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);
int[] nums = new int[] { a, b, c };
Array.Sort(nums);
Console.WriteLine($"{nums[0]} {nums[1]} {nums[2]}");