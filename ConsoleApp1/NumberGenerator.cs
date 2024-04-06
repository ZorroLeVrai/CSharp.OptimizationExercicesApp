namespace ConsoleApp1;

internal static class NumberGenerator
{
    private static Random random = new Random();

    public static int[] GenerateIntegers(byte nb, int minValue, int maxValue)
    {
        var values = new int[nb];
        for (int i = 0; i < nb; ++i)
            values[i] = random.Next(minValue, maxValue);
        return values;
    }
}
