using AssignmentAllianceitsc.Serivces.Assignment1.Interface.ISearchStrategy;

namespace AssignmentAllianceitsc.Serivces.Assignment1;

public class BinarySearchStrategy : ISearchStrategy
{
    public bool CheckNumInArray(int[] array, int size, int n)
    {
        return Array.BinarySearch(array, n) >= 0;
    }
}
