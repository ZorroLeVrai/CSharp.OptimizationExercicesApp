namespace ConsoleApp1;

public static class GenerateBinaryNumbers
{
    static Random random = new Random();

    public static async IAsyncEnumerable<string> GenerateBinaries(int nbNumbers)
    {
        for (int i = 0; i < nbNumbers; ++i) {
            int randomNumber = random.Next(256);
            yield return await GetBinary(randomNumber);
        }

        async Task<string> GetBinary(int number)
        {
            using HttpClient client = new();
            
            client.BaseAddress = new Uri("https://localhost:7109/");
            var url = string.Concat("api/IntToBinary/", number);
            return await client.GetStringAsync(url);
        }
    }
}
