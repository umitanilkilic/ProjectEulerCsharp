using Utility;

namespace Solutions;

class SmallestMultiple : ProblemSolverBase
{
    /// <summary>
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public SmallestMultiple()
    {
        ProblemID = 5;
    }
    public override void Solve()
    {
        long tmp = 1;
        for (int i = 2; i < 20; i++)
        {
            tmp = MathUtils.LCM(tmp,i);
        }

        Answer = tmp.ToString();
    }
}