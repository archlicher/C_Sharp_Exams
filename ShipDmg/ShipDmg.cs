using System;


class ShipDmg
{
    static void Main()
    {
        int sx1 = Math.Abs(int.Parse(Console.ReadLine()));
        int sy1 = Math.Abs(int.Parse(Console.ReadLine()));
        int sx2 = Math.Abs(int.Parse(Console.ReadLine()));
        int sy2 = Math.Abs(int.Parse(Console.ReadLine()));
        int h = Math.Abs(int.Parse(Console.ReadLine()));
        int cx1 = Math.Abs(int.Parse(Console.ReadLine()));
        int cy1 = Math.Abs(int.Parse(Console.ReadLine()));
        int cx2 = Math.Abs(int.Parse(Console.ReadLine()));
        int cy2 = Math.Abs(int.Parse(Console.ReadLine()));
        int cx3 = Math.Abs(int.Parse(Console.ReadLine()));
        int cy3 = Math.Abs(int.Parse(Console.ReadLine()));

        if (sx1 < sx2)
        {
            int a = sx1;
            sx1 = sx2;
            sx2 = a;
        }
        if (sy1 < sy2)
        {
            int a = sy1;
            sy1 = sy2;
            sy2 = a;
        }

        sy1 -= h;
        sy2 -= h;
        cy1 += h;
        cy2 += h;
        cy3 += h;

        int sumC1 = CalcTwentyFive(cx1, cy1, sx1, sy1, sx2, sy2);
        if (sumC1==0)sumC1 = CalcFifty(cx1, cy1, sx1, sy1, sx2, sy2);
        if (sumC1==0)sumC1 = CalcHundred(cx1, cy1, sx1, sy1, sx2, sy2);

        int sumC2 = CalcTwentyFive(cx2, cy2, sx1, sy1, sx2, sy2);
        if (sumC2 == 0) sumC2 = CalcFifty(cx2, cy2, sx1, sy1, sx2, sy2);
        if (sumC2 == 0) sumC2 = CalcHundred(cx2, cy2, sx1, sy1, sx2, sy2);

        int sumC3 = CalcTwentyFive(cx3, cy3, sx1, sy1, sx2, sy2);
        if (sumC3 == 0) sumC3 = CalcFifty(cx3, cy3, sx1, sy1, sx2, sy2);
        if (sumC3 == 0) sumC3 = CalcHundred(cx3, cy3, sx1, sy1, sx2, sy2);

        int totalSum = sumC1 + sumC2 + sumC3;
        Console.WriteLine("{0}%",totalSum);
    }

    private static int CalcFifty(int x, int y, int a, int b, int c, int d)
    {
        int fifty = 0;
        if ((x == a && y < b && y > d) ||
            (x == c && y < b && y > d) ||
            (y == b && x < a && x > c) ||
            (y == d && x < a && x > c)) fifty = 50;
        return fifty;
    }

    private static int CalcHundred(int x, int y, int a, int b, int c, int d)
    {
        int hundred = 0;
        if (x < a && x > c && y < b && y > d) hundred = 100;
        return hundred;

    }

    private static int CalcTwentyFive(int x, int y, int a, int b, int c, int d)
    {   
        int twentyFive = 0;
        if ((x == a && y == b) ||
            (x == c && y == d) ||
            (x == a && y == d) ||
            (x == c && y == b)) twentyFive = 25;
        return twentyFive;
    }
}
