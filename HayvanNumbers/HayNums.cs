using System;
using System.Text.RegularExpressions;


class HayNums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        bool yes = false;

        for (int i = 555; i < 1000; i++)
        {
            int abc = i;
            int def = abc + diff;
            int ghi = def + diff;
            int currentSum = CalSumNum(abc, def, ghi);
            string currentNum = ""+abc+""+def+""+ghi;
            bool numIsOK = CheckNums(currentNum);
            if (currentSum == sum && numIsOK)
            {
                Console.WriteLine(currentNum);
                yes = true;
            }
        }
        if (!yes) Console.WriteLine("No");
    }

    private static bool CheckNums(string number)
    {
        Regex reg = new Regex("0|1|2|3|4");
        if (!reg.IsMatch(number)) return true;
        return false;
    }

    private static int CalSumNum(int first, int second, int third)
    {
        int total = 0;
        for (int i = 100; i > 9; i /= 10)
        {
            int a = first / i;
            first %= i;
            int b = second / i;
            second %= i;
            int c = third / i;
            third %= i;
            total += a + b + c;
        }
        total += first + second + third;
         return total;
    }
}