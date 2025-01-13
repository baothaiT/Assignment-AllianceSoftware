using AssignmentAllianceitsc.Serivces;
using System.Buffers;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        UseCheckNumInArray();
    }

    public static void UseCheckNumInArray()
    {
        int[] array = Enumerable.Range(1, 1000000).ToArray();
        Stopwatch overallStopwatch = new Stopwatch();
        overallStopwatch.Start();
        int total = 0;
        object consoleLock = new object();

        Parallel.For(0, 1000000, i =>
        {
            MeasureSearchPerformance(array, array.Length, i, consoleLock);
            Interlocked.Increment(ref total);
        });

        overallStopwatch.Stop();
        Console.WriteLine($"Total ran: {total}");
        Console.WriteLine($"Total Time: {overallStopwatch.Elapsed.TotalMilliseconds:F2} ms");
    }

    public static void MeasureSearchPerformance(int[] array, int size, int searchValue, object consoleLock)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        bool result = false;

        if (size <= 300000)
        {
            var binaryProcessor = new ArrayProcessor(new BinarySearchStrategy());
            var arrayBinary = binaryProcessor.InitializeArray(array);

            result = binaryProcessor.CheckNumInArray(arrayBinary, arrayBinary.Length, searchValue);
        }
        else
        {
            var parallelProcessor = new ArrayProcessor(new ParallelSearchStrategy());
            parallelProcessor.CheckNumInArray(array, Math.Min(size, 10), searchValue); // Warm-up
            result = parallelProcessor.CheckNumInArray(array, array.Length, searchValue);
        }
        stopwatch.Stop();

        lock (consoleLock)
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.ManagedThreadId}, SearchValue: {searchValue}, Found: {result}, Time: {stopwatch.Elapsed.TotalMilliseconds:F2} ms");
        }
    }
}
