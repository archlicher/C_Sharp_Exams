using System;


class Poker
{
    static void Main()
    {
        int targetWeight = int.Parse(Console.ReadLine());
        int counter = 0;

        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        char[] suits = { 'C', 'D', 'H', 'S' };

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int h = 0; h < 4; h++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int n = 0; n < 4; n++)
                        {
                            for (int m = 0; m < 4; m++)
                            {
                                int currentNumWeight = nums[i] * 10 + nums[i + 1] * 20 + nums[i + 2] * 30 + nums[i + 3] * 40 + nums[i + 4] * 50;
                                string currentLetters = "" + suits[j]+suits[h]+suits[k]+suits[n]+suits[m];
                                int currentWeightLetter = CalWeightLetters(currentLetters);
                                int currentWeight = currentNumWeight + currentWeightLetter;
                                if (currentWeight == targetWeight) counter++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }

    private static int CalWeightLetters(string str)
    {
        int weight=0;
        foreach (var ch in str)
        {
            switch (ch)
            {
                case 'C': weight += 1; break;
                case 'D': weight += 2; break;
                case 'H': weight += 3; break;
                case 'S': weight += 4; break;
            }
        }
        return weight;
    }
}
