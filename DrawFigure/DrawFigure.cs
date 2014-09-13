using System;


class DrawFigure
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            string dots = new string('.', i);
            string aster = new string('*', n - i * 2);
            Console.WriteLine(dots+aster+dots);
        }
        for (int i = 1, j=1; i < n / 2 + 1; i++,j+=2)
        {
            string dots = new string('.', n/2+1-i);
            string aster = new string('*', j);
            Console.WriteLine(dots + aster + dots);
        }
        Console.WriteLine(new string('*',n));
    }
}
