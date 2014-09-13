using System;


class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = n - 2;
        int c = 1;

        string botDot = new string('.',a);
        string stem = botDot+"*"+botDot;

        for (int i = 1; i < n; i++)
        {
            string dots = new string('.', a);
            a--;
            string asters = new string('*',c);
            c += 2;
            string firTree = dots + asters + dots;
            Console.WriteLine(firTree);
        }

        Console.WriteLine(stem);
    }
}
