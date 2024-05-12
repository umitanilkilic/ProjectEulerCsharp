namespace Solutions;

public interface IProblemSolver
{
    void Solve();
}

public abstract class ProblemSolverBase : IProblemSolver
{
    public int ProblemID;
    public string? Answer;

    public abstract void Solve();
}