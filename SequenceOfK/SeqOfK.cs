using System;


class SeqOfK
{
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        int[] input = new int[num.Length];

        for (int i = 0; i < num.Length; i++)
        {
            input[i] = int.Parse(num[i]);
        }

        int k = int.Parse(Console.ReadLine());
        
        bool yes = false;

        for (int i = 0; i < input.Length - k + 1; i++)
        {
            for (int j = i + k-1; j > i; j--)
            {
                if (input[i] == input[j] && input[i] == input[j-1])
                {
                    input[j] = -1001;
                    yes = true;
                }
                else break;
            }
            if (yes)
            {
                yes = false;
                input[i] = -1001;
            }
        }
        if (k > 1)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > -1001) Console.Write("{0} ", input[i]);
            }
        }
    }
}
