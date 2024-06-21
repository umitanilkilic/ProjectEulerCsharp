using Utility;

namespace Solutions;

public class SumSquareDifference : ProblemSolverBase
{
    /// <summary>
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public SumSquareDifference()
    {
        ProblemID = 6;
    }
    public override void Solve()
    {
        //If you don't count zero as a natural number, then the correct answer is 25164150.
        int[] range = new int[2] { 0, 100 };
        var totalSquaredSum = Enumerable.Range(range[0], range[1]).Select(x => x * x).Sum();

        var sumOfSquares = MathUtils.CalculateArithmeticSum(100, 0, 1);
        sumOfSquares *= sumOfSquares;

        Answer = (sumOfSquares - totalSquaredSum).ToString();
    }
}