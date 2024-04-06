namespace ConsoleApp1;

internal partial class BinaryNumbersCalculator
{
    public IEnumerable<Task<BinaryData>> GenerateBinaries()
    {
        foreach (var number in _digitalNumbers)
            yield return GetBinaryAsync(number);
    }

    public Task<BinaryData>[] GenerateBinariesUsingTaskArray()
    {
        var tasks = new Task<BinaryData>[_digitalNumbers.Length];
        for (var i = 0; i < _digitalNumbers.Length; ++i)
            tasks[i] = GetBinaryAsync(_digitalNumbers[i]);
        return tasks;
    }
}
