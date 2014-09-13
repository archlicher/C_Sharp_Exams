using System;


class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string aster = new string('*', 2*n - 2);
        string empty = new string(' ', n - 1);
        string bridge = new string('-', n-1);
        string glass = new string('/', 2*n - 2);

        string glassMid = "*" + glass + "*" + bridge + "*" + glass + "*";
        string topBot = " " + aster + " " + empty + " " + aster + " ";
        string sunglass = "*" + glass + "*" + empty + "*" + glass + "*";

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n) Console.WriteLine(topBot);
            else if (i == (n / 2) + 1) Console.WriteLine(glassMid);
            else Console.WriteLine(sunglass);
        }
    }
}