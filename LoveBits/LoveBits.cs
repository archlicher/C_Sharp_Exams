using System;


class LoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            int numCovert = 0;
            int numReverse = 0;

            int index = 0;

            for (int j = 31; j > -1; j--)
            {
                int a = (num & (1 << j)) >> j;
                if (a == 1)
                {
                    index = j;
                    break;
                }
            }

            for (int j = 0; j <= index; j++)
            {
                int a = (num & (1 << j)) >> j;
                if (a == 1)
                {
                    a = 0;
                    numCovert ^= a << j;
                }
                else
                {
                    a = 1;
                    numCovert ^= a << j;
                }
            }

            int indexReverse = index;
            for (int j = 0; j <= index; j++)
            {
                int a = (num & (1 << j)) >> j;
                numReverse ^= a << indexReverse;
                indexReverse--;
            }

            int outputNum = 0;
            for (int j = 0; j <= index; j++)
            {
                int a = (num & (1 << j)) >> j;
                int b = (numCovert & (1 << j)) >> j;
                int c = (numReverse & (1 << j)) >> j;
                outputNum ^= ((a ^ b) & c) << j;
            }

            Console.WriteLine(outputNum);

        }
    }
}
