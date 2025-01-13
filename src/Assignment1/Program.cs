using AssignmentAllianceitsc.Serivces.Assignment1;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = Enumerable.Range(1, 2147483591).ToArray();
        int searchValue = 20000;

        int[] testSizes = { 0, 100000, 150000, 200000, 300000, 500000, 1000000, 10000000, 2147483591 };
        foreach (int size in testSizes)
        {
            Console.WriteLine($"Running CheckNumInArray for array size: {size}");

            MeasureSearchPerformance(array.Take(size).ToArray(), size, searchValue);
        }
    }
    public static void MeasureSearchPerformance(int[] array, int size, int searchValue)
    {
        Stopwatch stopwatch = new Stopwatch();

        if (size <= 300000)
        {
            var binaryProcessor = new ArrayProcessor(new BinarySearchStrategy());
            var arrayBinary = binaryProcessor.InitializeArray(array);

            stopwatch.Start();
            bool resultBinary = binaryProcessor.CheckNumInArray(arrayBinary, arrayBinary.Length, searchValue);
            stopwatch.Stop();

            Console.WriteLine($"Binary Search: {searchValue} found? {resultBinary}. Time: {stopwatch.Elapsed.TotalMilliseconds:F2} ms");
        }
        else
        {
            var parallelProcessor = new ArrayProcessor(new ParallelSearchStrategy());
            parallelProcessor.CheckNumInArray(array, Math.Min(size, 10), searchValue); // Warm-up to reduce overhead

            stopwatch.Start();
            bool resultParallel = parallelProcessor.CheckNumInArray(array, array.Length, searchValue);
            stopwatch.Stop();

            Console.WriteLine($"Parallel Linear Search: {searchValue} found? {resultParallel}. Time: {stopwatch.Elapsed.TotalMilliseconds:F2} ms");
        }
        Console.WriteLine();
    }
}
