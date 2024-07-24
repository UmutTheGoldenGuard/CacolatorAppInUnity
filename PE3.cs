using System;

class PE3
{
    public static void Main3()
    {
        Console.WriteLine("Largest is " + CalculatePrimes(580085));
    }

    public static int CalculatePrimes(double n)
    {
        List<int> primes = new List<int>();
        List<int> primeMultiples = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            primes.Add(i);
            foreach (int p in primes)
            {
                if(p*p > i) 
                { 
                    if (n % i == 0)
                    {
                        primeMultiples.Add(i);
                        Console.WriteLine(i + " is a prime multiple");
                        do
                        {
                            n /= i;
                        } while (n % i == 0);
                    }
                    break; 
                }
                if (i % p == 0) { primes.Remove(i); break; }
            }
            //Console.WriteLine(i);
        }
        //ListPrinter(primes); Console.WriteLine("");
        ListPrinter(primeMultiples);
        return primeMultiples[primeMultiples.Count -1];
    }

    public static void ListPrinter(List<int> theList)
    {
        foreach (int num in theList)
        {
            Console.Write(num + " , ");
        }
    }
}
