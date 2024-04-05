namespace DistantWebApplication.Services;

public class ConverterAsyncVersionService
{
    public async static Task<string> IntToBinaryAsync(int value)
    {
        await WaitInMsAsync(500);
        return Convert.ToString(value, 2);
    }

    private async static Task WaitInMsAsync(int ms)
    {
        await Task.Delay(500);
    }
}
