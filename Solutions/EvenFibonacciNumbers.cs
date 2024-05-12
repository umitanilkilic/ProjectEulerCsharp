namespace Solutions;

public class EvenFibonacciNumbers : ProblemSolverBase
{
  public EvenFibonacciNumbers()
  {
    ProblemID = 2;
  }
  public override void Solve()
  {
    var fibNumbers = GetFibonacciNumbers(1, 2, 4000000).ToList();
    var sum = fibNumbers.Where(x => x % 2 == 0).Sum();
    Answer = sum.ToString();
  }


  static IEnumerable<int> GetFibonacciNumbers(int first, int second, int max)
  {
    while (true)
    {
      if (first > max)
      {
        yield break;
      }
      yield return first;
      var tmp = first;
      first = second;
      second = second + tmp;
    }
  }
}