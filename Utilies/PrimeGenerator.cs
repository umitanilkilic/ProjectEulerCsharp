using System.Runtime.Intrinsics.Arm;

namespace Utility;

static class Prime
{
    static List<long> _primes = new List<long>() { 2, 3, 5, 7, 11 };

    private static int _lastIndex;

    public static long Next()
    {
        if (_primes.Count - 1 > _lastIndex)
        {
            _lastIndex++;
            return _primes[_lastIndex - 1];
        }

        return CalculateNext();
    }

    public static long CalculateNext()
    {
        long currentPrimeNumber = CalculatePrimeNumber(_primes[_primes.Count - 1]);
        _primes.Add(currentPrimeNumber);
        _lastIndex++;

        return _primes[_lastIndex];
    }

    public static long Seek(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative.");
        }

        while (_primes.Count <= index)
        {
            Next();
        }

        return _primes[index];
    }

    private static long CalculatePrimeNumber(long lastPrimeNumber)
    {
        lastPrimeNumber++;

        for (long i = 2; i <= Math.Sqrt(lastPrimeNumber); i ++)
        {
            if (lastPrimeNumber % i == 0)
            {
                return CalculatePrimeNumber(lastPrimeNumber);
            }
        }

        return lastPrimeNumber;
    }

    public static bool IsPrime(long number)
    {
        if (_primes.Contains(number))
        {
            return true;
        }

        if (_primes[_primes.Count - 1] > number)
        {
            return false;
        }

        if (number <= 1)
            return false;
        if (number == 2 || number == 3)
            return true;
        if (number % 2 == 0 || number % 3 == 0)
            return false;

        // Check for primes only up to the square root of the number
        long limit = (long)Math.Sqrt(number);
        for (long i = 5; i <= limit; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        CalculateNext();
        return IsPrime(number);
    }

    public static long GetLargestPrimeFactor(long number)
    {
        long prime = Seek(0);

        while (number != 1)
        {
            if (number % prime == 0)
            {
                number /= prime;
            }
            else
            {
                prime = Next();
            }
        }

        return prime;
    }
}
