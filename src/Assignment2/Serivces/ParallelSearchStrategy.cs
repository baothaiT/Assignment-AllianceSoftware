using AssignmentAllianceitsc.Serivces.Interface.ISearchStrategy;

namespace AssignmentAllianceitsc.Serivces;

public class ParallelSearchStrategy : ISearchStrategy
{
    public bool CheckNumInArray(int[] array, int size, int n)
    {
        return array.AsParallel().Any(x => x == n);
    }
}
