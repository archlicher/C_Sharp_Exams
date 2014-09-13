using System;
using System.Numerics;

class SimpleLoops
{
    static void Main()
    {
        BigInteger first = int.Parse(Console.ReadLine());
        BigInteger second = int.Parse(Console.ReadLine());
        BigInteger third = int.Parse(Console.ReadLine());
        int lastNumPosition = int.Parse(Console.ReadLine());

        BigInteger outputNum = 0;

        for (int i = 0; i < lastNumPosition-3; i++)
        {
            outputNum = first + second + third;
            first = second;
            second = third;
            third = outputNum;
        }

        if (lastNumPosition == 1) Console.WriteLine(first);
        else if (lastNumPosition == 2) Console.WriteLine(second);
        else if (lastNumPosition == 3) Console.WriteLine(third);
        else Console.WriteLine(outputNum);
    }
}
