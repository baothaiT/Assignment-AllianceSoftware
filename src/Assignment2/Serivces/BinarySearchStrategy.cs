using AssignmentAllianceitsc.Serivces.Interface.ISearchStrategy;

namespace AssignmentAllianceitsc.Serivces;

public class BinarySearchStrategy : ISearchStrategy
{
    public bool CheckNumInArray(int[] array, int size, int n)
    {
        return Array.BinarySearch(array, n) >= 0;
    }
}
