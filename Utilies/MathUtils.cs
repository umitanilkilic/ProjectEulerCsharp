namespace Utility;

static class MathUtils
{
    public static int CalculateArithmeticSum(int numberOfTerms, int firstTerm, int stepSize)
    {
        return (numberOfTerms / 2) * (2*firstTerm + (numberOfTerms-1)*stepSize);
    }
    
    public static long GCD(long a, long b)
    {
        if (a == 0)
        {
            return b;
        }
        if (b == 0)
        {
            return a;
        }
        return GCD(b % a, a);
    }
    public static long LCM(long a, long b)
    {
        return (a * b) / GCD(a, b);
    }
}