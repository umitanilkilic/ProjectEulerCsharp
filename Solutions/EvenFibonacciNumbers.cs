namespace Solutions;

class EvenFibonacciNumbers
{
  const int _problemID = 2;

  Question _question = new Question() { id = _problemID };


  public Question Solve()
  {
    var fibNumbers = GetFibonacciNumbers(1, 2, 4000000).ToList();

    var sum = fibNumbers.Where(x => x % 2 == 0).Sum();
    _question.answer = sum.ToString();
    return _question;
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