using System;

class PE1
{
    public static void Main1()
    {
        Console.WriteLine(Count3515(1000000000));
    }

    static int Count3515(int n)
    {
        int num3 = (n-1) / 3;
        int num5 = (n-1) / 5;
        int num15 = (n-1) / 15;
        int sum = 3 * (num3 * (num3 + 1)) / 2 + 5 * (num5 * (num5 + 1)) / 2 - 15*(num15 * (num15 + 1)) / 2;
        return sum;
    }
}
