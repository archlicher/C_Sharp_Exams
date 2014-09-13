using System;

class BitwiseOperators
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int index = 0;
            for (int k = 31; k > -1; k--)
            {
                int bitwise = (inputNum & (1 << k)) >> k;
                if (bitwise == 1)
                {
                    index = k;
                    break;
                }
            }

            int turnedNum = 0;
            for (int p = 0; p < index+1; p++)
            {
                int sec = (inputNum & (1 << p))>> p;
                if (sec == 0)
                {
                    sec = 1;
                    turnedNum ^= sec << p;
                }
                else
                {
                    sec = 0;
                    turnedNum ^= sec << p;
                }
            }


            int reversedNum = 0;
            for (int h = 0, j = index; h < index + 1; h++, j--)
            {
                reversedNum ^= ((inputNum & (1 << h))>>h) << j;
            }

            int outputNum = 0;
            for (int m = 0; m < 32; m++)
            {
                int a = (inputNum & (1 << m)) >> m;
                int b = (turnedNum & (1 << m)) >> m;
                int c = (reversedNum & (1 << m)) >> m;
                outputNum ^= ((a ^ b) & c) << m;
            }

            Console.WriteLine(outputNum);
        }
    }
}
