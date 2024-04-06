namespace ConsoleApp1;

internal partial class BinaryNumbersDisplayer
{
    private BinaryNumbersCalculator _binaryGenerator;

    public BinaryNumbersDisplayer(BinaryNumbersCalculator binaryGenerator)
    {
        _binaryGenerator = binaryGenerator;
    }

    public async Task DisplayBinariesAsync()
    {
        Console.WriteLine(nameof(DisplayBinariesAsync));
        await foreach (var binaryItem in _binaryGenerator.GenerateBinariesAsync())
            Console.WriteLine(binaryItem);
    }
}
