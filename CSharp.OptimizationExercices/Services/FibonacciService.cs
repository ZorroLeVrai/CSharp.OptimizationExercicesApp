namespace CSharp.OptimizationApi.Services;

public static class FibonacciService
{
    public static long GetFibonacciTerm(int index)
    {
        if (index < 2)
            return index;

        return GetFibonacciTerm(index - 1) + GetFibonacciTerm(index - 2);
    }
}
