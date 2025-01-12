using AssignmentAllianceitsc.Serivces.Assignment1.Interface.ISearchStrategy;

namespace AssignmentAllianceitsc.Serivces.Assignment1;

public class ParallelSearchStrategy : ISearchStrategy
{
    public bool CheckNumInArray(int[] array, int size, int n)
    {
        return array.AsParallel().Any(x => x == n);
    }
}
