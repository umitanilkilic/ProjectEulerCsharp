namespace Solutions;

public interface IProblemSolver
{
    void Solve();
}

public abstract class ProblemSolverBase : IProblemSolver
{
    public int ProblemID { get; set; }
    public string? Answer { get; set; }

    public abstract void Solve();
}
