using System;

class PE2
{
    public static void Main2()
    {
        Console.WriteLine(CalculateSum());
    }

    static int CalculateSum()
    {
        int i = 2;
        int sum = 0;
        while (true)
        {
            if (Fibonacci(i) > 4000000) { break; }
            sum += Fibonacci(i);
            i += 3;
        }
        return sum;
    }

    static int Fibonacci(int n)
    {
       if (n > 1)
       {
            return Fibonacci(n-1) + Fibonacci(n-2);
       }
       return 1;
    }
}
