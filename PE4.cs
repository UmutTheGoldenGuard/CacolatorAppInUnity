using System;
using System.Runtime.InteropServices;

class PE4
{
    public static void Main4()
    {
        CalculateLargest();
        //Console.WriteLine(CheckPalindrom(999));
    }

    static void CalculateLargest()
    {
        int n1 = 995;
        int n2 = 516;
        int n3 = 994;
        List<int> palindroms = new List<int>();
        while (n1 >= 100)
        {
            if (n2 < 100)
            {
                n1 = n3;
                n2 = n3;
                n3--;
            }
            n2 = n2 - 1;
            int n4= n2 * n1;
            if (CheckPalindrom(n4))
            {
                palindroms.Add(n4);
            }
            Console.WriteLine(n4);
        }
        Console.WriteLine(palindroms.Max());
        PE3.CalculatePrimes(n2 * n1);
    }

    static bool CheckPalindrom(int number)
    {
        String ntext = number.ToString();
        Console.WriteLine(ntext);
        char[] charArray = ntext.ToCharArray();
        Array.Reverse(charArray);
        String revText = new String(charArray);
        if (ntext == revText)
        {
            return true; 
        }
        return false;
    }

    public static void ListPrinter(List<int> theList)
    {
        foreach (int num in theList)
        {
            Console.Write(num + " , ");
        }
    }
}
