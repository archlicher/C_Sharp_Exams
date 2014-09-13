using System;


class Disk
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int R = int.Parse(Console.ReadLine());
        int diameter = R * 2 + 1;

        string dots = new string('.', N);
        for (int i = 0; i < N / 2 - R; i++)
        {
            Console.WriteLine(dots);
        }

        string dotBot = new string('.', N / 2);
        string topBot = dotBot + "*" + dotBot;
        Console.WriteLine(topBot);

        for (int i = 1; i < R; i++)
        {
            int y = R - i;
            int x = 0;
            double a = (Math.Sqrt(Math.Pow(R, 2) - Math.Pow(y, 2)));

            a = Math.Floor(a);
            x = (int)a;

            string asterCircle = new string('*', x * 2 + 1);
            string dotCircle = new string('.', (N - x * 2 - 1) / 2);
            string circle = dotCircle + asterCircle + dotCircle;
            Console.WriteLine(circle);
        }

        string dotMid = new string('.', N / 2 - R);
        string asterMid = new string('*', R * 2 + 1);
        string circleMid = dotMid + asterMid + dotMid;
        Console.WriteLine(circleMid);

        for (int i = R - 1; i > 0; i--)
        {
            int y = R - i;
            int x = 0;
            double a = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(y, 2));

            a = Math.Floor(a);
            x = (int)a;

            string asterCircle = new string('*', x * 2 + 1);
            string dotCircle = new string('.', (N - x * 2 - 1) / 2);
            string circle = dotCircle + asterCircle + dotCircle;
            Console.WriteLine(circle);
        }

        Console.WriteLine(topBot);
        for (int i = 0; i < N / 2 - R; i++)
        {
            Console.WriteLine(dots);
        }
    }
}
