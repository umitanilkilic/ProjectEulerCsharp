namespace Solutions;
class MultiplesOf3or5
{
  const int _problemID = 1;

  Question _question = new Question() { id = _problemID };


  public Question Solve()
  {
    var numbers = new List<int>() { 3, 5 };
    _question.answer = findSumOfMultipliersBelow(numbers, 1000).ToString();
    return _question;
  }

  static int findSumOfMultipliersBelow(List<int> numbers, int maxNumber)
  {
    var numberCollection = Enumerable.Range(0, maxNumber);

    var multipliers = numberCollection.Where(numberCollection => numbers.Any(number => numberCollection % number == 0));

    return multipliers.Sum();
  }
}