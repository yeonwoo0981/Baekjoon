int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
   string OX = Console.ReadLine();
   
   int score = 0;
   
   int currentStreak = 0;   foreach (char c in OX)
   {
       if (c == 'O')
       {
           currentStreak++;
           score += currentStreak;
       }
       else
       {
           currentStreak = 0;
       }
   }
   Console.WriteLine(score);
}