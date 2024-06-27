using Utility;

namespace Solutions;

public class SummationOfPrimes : ProblemSolverBase
{
    /// <summary>
    /// Find the sum of all the primes below two million.
    /// </summary>
    public SummationOfPrimes()
    {
        ProblemID = 10;
    }
    public override void Solve()
    {

        Answer = calculateSumOfPrimes().ToString();
    }

    private long calculateSumOfPrimes()
    {
        long sum = 0;
        for (int i = 2; i < 2000000; i++)
        {
            if (checkPrime(i) == true)
            {
                sum += i;
            }
        }
        return sum;
    }

    private bool checkPrime(int n)
    {
        int range = n;
        for (int i = 2; i < range; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
            range = n / i;
        }
        return true;
    }

}