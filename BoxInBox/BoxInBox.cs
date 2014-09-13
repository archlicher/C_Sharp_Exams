using System;


class BoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());
        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        PrintBox(w1, h1, d1, w2, h2, d2);
        PrintBox(w1, h1, d1, w2, d2, h2);
        PrintBox(w1, h1, d1, h2, w2, d2);
        PrintBox(w1, h1, d1, h2, d2, w2);
        PrintBox(w1, h1, d1, d2, w2, h2);
        PrintBox(w1, h1, d1, d2, h2, w2);

        PrintBox(w2, h2, d2, w1, h1, d1);
        PrintBox(w2, h2, d2, w1, d1, h1);
        PrintBox(w2, h2, d2, h1, w1, d1);
        PrintBox(w2, h2, d2, h1, d1, w1);
        PrintBox(w2, h2, d2, d1, w1, h1);
        PrintBox(w2, h2, d2, d1, h1, w1);

    }

    private static void PrintBox(int wf, int hf, int df, int ws, int hs, int ds)
    {
        if (wf < ws && hf < hs && df < ds) Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", wf, hf, df, ws, hs, ds);
    }
}
