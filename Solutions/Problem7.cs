using Utility;

namespace Solutions;

public class Problem7 : ProblemSolverBase
{
    /// <summary>
    /// What is the 10001st prime number?
    /// </summary>

    public Problem7()
    {
        ProblemID = 7;
    }

    public override void Solve()
    {
        Answer = Prime.Seek(10000).ToString();
    }
}