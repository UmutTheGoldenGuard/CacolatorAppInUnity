using System;

class PE5
{
    public static void Main()
    {
        //Finds the gcm of the numbers from 1 to n
        int n = 20;
        List<int> primes = CreatePrimesList(n);
        UsefullFunctions.ListPrinter(primes);
        int gcm = 1;
        foreach(int prime in primes)
        {
            int primePower = 1;
            //finds the biggest power of a prime less than n
            do{
                primePower *= prime;
            } while (primePower * prime <= n);
            gcm *= primePower;
        }
        Console.WriteLine(gcm);
    }

    //  Generates a list of primes
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