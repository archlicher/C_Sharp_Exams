using System;
using System.Collections.Generic;


class BitFriends
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        
        long[] inputNum = new long[32];
        long one = 1L;

        for (int i = 0; i < 32; i++)
        {
            inputNum[i] = (n & (one << i)) >> i;
        }
        Array.Reverse(inputNum);

        int k = 1;

        List <string> friends = new List<string>();
        List<string> alone = new List<string>();
        long a = 0;

        if (inputNum[0] == inputNum[1])
        {
            a = inputNum[0];
            friends.Add(a.ToString());
        }
        else
        {
            a = inputNum[0];
            alone.Add(a.ToString());
        }

        for (int i = 0; i < 31; i += k)
        {
            k = 1;
            for (int j = i + 1; j < 31; j++)
            {
                if (inputNum[i] == inputNum[j])
                {
                    a = inputNum[j];
                    friends.Add(a.ToString());
                    k++;
                }
                else if (inputNum[i] != inputNum[j] && inputNum[j] == inputNum[j + 1])
                {
                    a = inputNum[j];
                    friends.Add(a.ToString());
                    break;
                }
                else if (inputNum[i] != inputNum[j] && inputNum[j] != inputNum[j + 1])
                {
                    a = inputNum[j];
                    alone.Add(a.ToString());
                    break;
                }
            }
        }

        if (inputNum[31] == inputNum[30])
        {
            friends.Add(inputNum[31].ToString());
            
        }
        else
        {
            alone.Add(inputNum[31].ToString());
            
        }

        int indexFriends = friends.Count - 1;
        int indexAlone = alone.Count - 1;

        uint friendsNum = 0;
        uint aloneNum = 0;
        int bit = 0;

        for (int i = indexFriends; i > -1; i--)
        {
            uint b = uint.Parse(friends[i]);
            friendsNum ^= b << bit;
            bit++;
        }

        bit = 0;

        for (int i = indexAlone; i > -1; i--)
        {
            uint b = uint.Parse(alone[i]);
            aloneNum ^= b << bit;
            bit++;
        }
        Console.WriteLine("{0}\n{1}",friendsNum,aloneNum);
    }
}
