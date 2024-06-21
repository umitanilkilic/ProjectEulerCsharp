using Utility;

namespace Solutions;

public class LargestPrimeFactor : ProblemSolverBase
{
    public LargestPrimeFactor()
    {
        ProblemID = 3;
    }

    public override void Solve()
    {
        Answer = Prime.GetLargestPrimeFactor(600851475143).ToString();
    }


}
