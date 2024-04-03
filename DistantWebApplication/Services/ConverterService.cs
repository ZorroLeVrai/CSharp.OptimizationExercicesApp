namespace DistantWebApplication.Services;

public static class ConverterService
{
    public static string IntToBinary(int value)
    {
        Thread.Sleep(100);
        return Convert.ToString(value, 2);
    }
}
