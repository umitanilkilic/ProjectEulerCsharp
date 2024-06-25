namespace Solutions;

public class SpecialPythagoreanTriplet : ProblemSolverBase
{
    /// <summary>
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.
    /// </summary>
    public SpecialPythagoreanTriplet()
    {
        ProblemID = 9;
    }

    public override void Solve()
    {
        Answer = FindSpecialPythagoreanTripletProduct(1000).ToString();
    }

    /// <summary>
    /// From Euclid's formula:
    /// if m, n is integer and m > n then
    /// a = m² - n²
    /// b = 2mn
    /// c = m² + n²
    /// Hence
    /// 2(m^2) + 2mn = 1000
    /// m(m+n) = 500
    /// </summary>
    long FindSpecialPythagoreanTripletProduct(int sum)
    {
        for (int m = 2; m * m < sum/2; m++)
        {
            for (int n = 1; n < m; n++)
            {
                int a = m * m - n * n;
                int b = 2 * m * n;
                int c = m * m + n * n;

                if (a + b + c == sum)
                {
                    return a * b * c; // Found the solution, so exit
                }
            }
        }

        return 0;
    }

}