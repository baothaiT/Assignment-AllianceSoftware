class Program
{
    static void Main(string[] args)
    {
        int[] dataInput = new int[] { 0, 1, 2, 3, 4, 5 };
        int[] result = DeleteRangeInArray(dataInput, 1, 3);

        Console.WriteLine($"Data Input: {string.Join(", ", dataInput)}");
        Console.WriteLine($"Data Output: {string.Join(", ", result)}");

    }
    static int[] DeleteIndexInArray(int[] A, int index)
    {
        int[] result = new int[A.Length - 1];

        for (int i = 0; i < index; i++)
        {
            result[i] = A[i];
        }

        for (int i = index + 1; i < A.Length; i++)
        {
            result[i - 1] = A[i];
        }
        return result;
    }

    static int[] DeleteRangeInArray(int[] A, int fromIndex, int toIndex)
    {
        if (fromIndex > toIndex || fromIndex < 0 || toIndex >= A.Length)
        {
            throw new ArgumentException("Invalid range");
        }
        for (int i = toIndex; i >= fromIndex; i--)
        {
            A = DeleteIndexInArray(A, i);
        }
        return A;
    }
}
