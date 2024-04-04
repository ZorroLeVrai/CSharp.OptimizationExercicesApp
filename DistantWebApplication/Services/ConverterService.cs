namespace DistantWebApplication.Services;

public static class ConverterService
{
    public async static Task<string> IntToBinary(int value)
    {
        await Task.Delay(500);
        return Convert.ToString(value, 2);
    }
}
