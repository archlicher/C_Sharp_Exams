using System;
using System.Text.RegularExpressions;


class NestedLoops
{
    static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        int countBulls = 0;
        int countCows = 0;

        bool yes = false;

        int[] num = new int[4];
        num[0] = (secretNum / 1000) % 10;
        int one = num[0];
        num[1] = (secretNum / 100) % 10;
        int two = num[1];
        num[2] = (secretNum / 10) % 10;
        int three = num[2];
        num[3] = secretNum % 10;
        int four = num[3];

        int[] outNum = new int[4];

        for (int i = 1111; i < 10000; i++)
        {
            int outputNum = i;
            outNum[0] = (outputNum / 1000) % 10;
            outNum[1] = (outputNum / 100) % 10;
            outNum[2] = (outputNum / 10) % 10;
            outNum[3] = outputNum % 10;
            Regex reg = new Regex("0");
            string a = outputNum.ToString();
            if (!reg.IsMatch(a))
            {
                for (int j = 0; j < 4; j++)
                {
                    if (outNum[j] == num[j])
                    {
                        countBulls++;
                        outNum[j] = -1;
                        num[j] = -2;
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    for (int h = 0; h < 4; h++)
                    {
                        if (outNum[j] == num[h])
                        {
                            countCows++;
                            outNum[j] = -1;
                            num[h] = -2;
                        }
                    }
                }

                if (countBulls == bulls && countCows == cows)
                {
                    Console.Write("{0} ", outputNum);
                    yes = true;
                }

                num[0] = one;
                num[1] = two;
                num[2] = three;
                num[3] = four;
                countBulls = 0;
                countCows = 0;
            }

        }
        if (!yes) Console.WriteLine("No");
    }
}
