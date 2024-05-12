namespace Solutions;

public class LargestPrimeFactor : ProblemSolverBase
{
  public LargestPrimeFactor()
  {
    ProblemID = 3;
  }
  public override void Solve()
  {
    Answer = GetLargestPrimeFactor(600851475143).ToString();
  }

  long GetLargestPrimeFactor(long number)
  {
    long largestPrime = 0;
    long divisor = 2;

    while (number != 1)
    {
      if (number % divisor == 0)
      {
        number = number / divisor;
      }
      else
      {
        divisor++;
      }
      if (divisor > largestPrime){
        largestPrime = divisor;
      }
    }

    return largestPrime;
  }
}