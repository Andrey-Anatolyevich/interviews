namespace QLibTests;

public class BubbleSortTests
{
    private BubbleSort _bubbleSort = new();

    [Fact]
    public void Sort_OnNull_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => _bubbleSort.Sort(null!));
    }

    [Fact]
    public void Sort_OnEmptyArray_ReturnEmptyArray()
    {
        var source = new int[0];
        var expected = new int[0];
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Sort_OnOneNumber_ReturnSortedArray()
    {
        var source = new[] { 4 };
        var expected = new[] { 4 };
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Sort_OnAlreadySorted_ReturnSameResults()
    {
        var source = new[] { 1, 2, 3, 4, 5 };
        var expected = new[] { 1, 2, 3, 4, 5 };
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Sort_OnRandomNumbers_ReturnSortedArray()
    {
        var source = new[] { 4, 2, 9, 0 };
        var expected = new[] { 0, 2, 4, 9 };
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Sort_OnSameNumbers_ReturnSortedArray()
    {
        var source = new[] { 4, 4, 4, 4, 4 };
        var expected = new[] { 4, 4, 4, 4, 4 };
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void Sort_OnTwoSetsOfSameNumbers_ReturnSortedArray()
    {
        var source = new[] { 4, 4, 2, 2, 2 };
        var expected = new[] { 2, 2, 2, 4, 4 };
        var sorted = _bubbleSort.Sort(source);
        Assert.Equal(expected, sorted);
    }
}