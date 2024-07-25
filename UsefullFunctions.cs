using System;

public class UsefullFunctions
{
    public static void ListPrinter(List<int> theList)
    {
        foreach (int num in theList)
        {
            Console.Write(num + " , ");
        }
    }

    public static List<int> CreatePrimesList(int n)
    {
        List<int> primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            primes.Add(i);
            foreach (int p in primes)
            {
                if(p*p > i) { break; }
                if (i % p == 0) { primes.Remove(i); break; }
            }
        }

        return primes;
    }
}