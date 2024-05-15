namespace Utility;

static class MathUtils
{
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