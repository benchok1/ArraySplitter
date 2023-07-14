namespace ArraySplitterTests;

public class ArraySplitterTests
{
    [Theory]
    [InlineData(5)]
    [InlineData(1)]
    [InlineData(6)]
    [InlineData(10)]
    [InlineData(0)]
    public void ArraySplitter_ReturnsCorrect_AmountOfSegments(int segments)
    {
        // Arrange
        int[] initialArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var splitter = new ArraySplitter.ArraySplitter(initialArray, segments);
        
        // Act
        splitter.SplitArray();
        
        // Assert
        Assert.Equal(segments, splitter.ResultSegments.Count);
    }
    
    [Fact]
    public void ArraySplitter_ReturnsCorrect_SegmentLength()
    {
        // Arrange
        int[] initialArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var segments = 3;
        var splitter = new ArraySplitter.ArraySplitter(initialArray, segments);
        
        // Act
        splitter.SplitArray();
        
        // Assert
        Assert.Equal(3 , splitter.ResultSegments.Count);
        Assert.Equal(3, splitter.ResultSegments[0].Length);
        Assert.Equal(3, splitter.ResultSegments[1].Length);
        Assert.Equal(4, splitter.ResultSegments[2].Length);
    }
}