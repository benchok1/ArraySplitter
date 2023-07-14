namespace ArraySplitter;

public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var segments = new Random().Next(0, 10);
        Console.WriteLine($"Segments : {segments}");
        var splitter = new ArraySplitter(array, segments);
        splitter.SplitArray();
    }
}
