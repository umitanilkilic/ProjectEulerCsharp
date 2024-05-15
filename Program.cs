namespace ProjectEulerCsharp;

using System.Reflection;
using Newtonsoft.Json;

static class Program
{
    static void Main(string[] args)
    {
        ReadJsonFile();
        TestSolutions();
    }

    static void TestSolutions()
    {
        Type[] classesInSolutionsNamespace = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(x => x.Namespace == "Solutions" && x.IsClass)
            .ToArray();

        foreach (Type item in classesInSolutionsNamespace)
        {
            var problemIdField = item.GetProperty("ProblemID");
            var answerField = item.GetProperty("Answer");

            ConstructorInfo? constructorInfo = item.GetConstructor(Type.EmptyTypes);
            if (constructorInfo != null)
            {
                dynamic instance = constructorInfo.Invoke(null);
                MethodInfo? methodInfo = item.GetMethod("Solve");
                if (methodInfo != null)
                {
                    methodInfo.Invoke(instance, null);
                    var problemId = (int)(problemIdField?.GetValue(instance) ?? -1);
                    if (problemId == -1)
                    {
                        continue;
                    }
                    var answer = (string)(answerField?.GetValue(instance) ?? "");
                    var trueAnsw = GetAnswersFromJson(problemId);

                    var isCorrect = CheckAnswer(answer, trueAnsw);

                    Console.WriteLine(
                        "Problem ID: {0}, Result: {1}",
                        problemId,
                        isCorrect ? "Passed" : $"Want: {trueAnsw} Got: {answer}"
                    );
                }
            }
        }
    }

    static AnswerContainer? answers;

    static void ReadJsonFile()
    {
        string jsonFilePath = "answers.json";

        string json = File.ReadAllText(jsonFilePath);

        answers = JsonConvert.DeserializeObject<AnswerContainer>(json);
    }

    static string GetAnswersFromJson(int id)
    {
        return answers?.questions?.FirstOrDefault(x => x.id == id)?.answer ?? "";
    }

    static bool CheckAnswer(string? a, string? b)
    {
        return a != null && b != null && a.Equals(b);
    }
}
