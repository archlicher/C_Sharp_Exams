using System;
using System.Numerics;

class Tribo
{
    static void Main()
    {
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        if (n == 1) Console.WriteLine(first);
        else if (n == 2) Console.WriteLine(second);
        else if (n == 3) Console.WriteLine(third);
        else
        {
            BigInteger outputNum = 0;
            for (int i = 4; i <= n; i++)
            {
                outputNum = first + second + third;
                first = second;
                second = third;
                third = outputNum;
            }
            Console.WriteLine(outputNum);
        }
    }
}
