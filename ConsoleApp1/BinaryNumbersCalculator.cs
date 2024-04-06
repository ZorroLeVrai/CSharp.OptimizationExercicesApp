namespace ConsoleApp1;

internal partial class BinaryNumbersCalculator
{
    const string SERVICE_BASE_URL = "https://localhost:7109/";
    const string BINARY_CONVERTER_URL = "api/IntToBinary/";
    private int[] _digitalNumbers;

    public BinaryNumbersCalculator(int[] digitNumbers)
    {
        _digitalNumbers = digitNumbers;
    }

    public async IAsyncEnumerable<BinaryData> GenerateBinariesAsync()
    {
        foreach (var number in _digitalNumbers)
            yield return await GetBinaryAsync(number);
    }

    async Task<BinaryData> GetBinaryAsync(int number)
    {
        using HttpClient client = new();
        client.BaseAddress = new Uri(SERVICE_BASE_URL);
        var url = string.Concat(BINARY_CONVERTER_URL, number);
        try
        {
            var binary = await client.GetStringAsync(url);
            return new BinaryData(number, binary);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP request failed: {ex.Message}");
            return new BinaryData(number, string.Empty);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return new BinaryData(number, string.Empty);
        }
    }
}

public record BinaryData(int DigitalNumber, string Binary)
{
    public override string ToString() => $"{DigitalNumber} => {Binary}";
}