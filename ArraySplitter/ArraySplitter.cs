namespace ArraySplitter;

public class ArraySplitter
{
    private int[] Data { get; }
    private int Segments { get; }
    public List<int[]> ResultSegments { get; }

    public ArraySplitter(int[] data, int segments)
    {
        Data = data;
        Segments = segments;
        ResultSegments = new List<int[]>();
    }
    
    public void SplitArray()
    {
        if (Segments == 0)
        {
            return;
        }
        
        var division = Math.DivRem(Data.Length, Segments);
        
        for (var i = 0; i < Segments; i++)
        {
            if (i == Segments - 1 && division.Remainder > 0) // If on last segment and division has remainder, add remainder onto to last array
            {
                ResultSegments.Add(Data.Skip(i * division.Quotient).Take(division.Quotient + division.Remainder).ToArray());
                continue;
            }
                
            ResultSegments.Add(Data.Skip(i * division.Quotient).Take(division.Quotient).ToArray());
        }
        
        PrintResults();
    }

    private void PrintResults()
    {
        foreach (var segment in ResultSegments)
        {
            Console.WriteLine("[{0}]", string.Join(", ", segment));
        }

    }
}