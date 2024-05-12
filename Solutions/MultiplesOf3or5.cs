namespace Solutions;
class MultiplesOf3or5 : ProblemSolverBase
{

  public MultiplesOf3or5()
  {
    ProblemID = 1;
  }

  public override void Solve()
  {
    var numbers = new List<int>() { 3, 5 };
    Answer = findSumOfMultipliersBelow(numbers, 1000).ToString();
  }

  static int findSumOfMultipliersBelow(List<int> numbers, int maxNumber)
  {
    var numberCollection = Enumerable.Range(0, maxNumber);

    var multipliers = numberCollection.Where(numberCollection => numbers.Any(number => numberCollection % number == 0));

    return multipliers.Sum();
  }
}