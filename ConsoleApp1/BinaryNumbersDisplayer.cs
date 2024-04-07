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

    public async Task DisplayBinariesAsyncV2()
    {
        //Using the System.Linq.Async Package
        Console.WriteLine(nameof(DisplayBinariesAsyncV2));
        await _binaryGenerator.GenerateBinariesAsync()
            .ForEachAsync(Console.WriteLine);
    }
}
