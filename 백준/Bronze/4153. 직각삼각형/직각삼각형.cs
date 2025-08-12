while (true)
{
    string[] str = Console.ReadLine().Split();
    int[] nums = new int[3];
    
    for (int i = 0; i < 3; i++)
        nums[i] = int.Parse(str[i]);
    
    int a = nums[0], b = nums[1], c = nums[2];
    
    if (a == 0 && b == 0 && c == 0)
        break;
    
    Array.Sort(nums);
    int bigNum = nums[2], secNum = nums[1], smallNum = nums[0];
    
    int smallAngle = secNum * secNum + smallNum * smallNum;
    int bigAngle = bigNum * bigNum;
    
    if (smallAngle == bigAngle)
        Console.WriteLine("right");
    else
        Console.WriteLine("wrong");
}