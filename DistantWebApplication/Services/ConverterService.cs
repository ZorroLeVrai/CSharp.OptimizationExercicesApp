namespace DistantWebApplication.Services;

public static class ConverterService
{
    public static string IntToBinary(int value)
    {
        WaitInMs(500);
        return Convert.ToString(value, 2);
    }

    private static void WaitInMs(int ms)
    {
        Task.Delay(500).Wait();
    }
}
