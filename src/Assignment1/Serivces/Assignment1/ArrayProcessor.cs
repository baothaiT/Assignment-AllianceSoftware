using AssignmentAllianceitsc.Serivces.Assignment1.Interface.ISearchStrategy;

namespace AssignmentAllianceitsc.Serivces.Assignment1;

public class ArrayProcessor
{
    private readonly ISearchStrategy _searchStrategy;

    public ArrayProcessor(ISearchStrategy searchStrategy)
    {
        _searchStrategy = searchStrategy;
    }

    public int[] InitializeArray(int[] array)
    {
        int[] _array = (int[])array.Clone();
        Array.Sort(_array); // Sort for binary search
        return _array;
    }

    public bool CheckNumInArray(int[] A, int size, int n)
    {
        if (A == null)
        {
            throw new InvalidOperationException("Array not initialized. Call InitializeArray first.");
        }
        var isResult = _searchStrategy.CheckNumInArray(A, size, n);

        return isResult;
    }
}
