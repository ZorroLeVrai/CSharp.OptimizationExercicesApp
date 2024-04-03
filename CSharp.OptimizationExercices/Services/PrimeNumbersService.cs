namespace CSharp.OptimizationApi.Services;

public static class PrimeNumbersService
{
    public static string GetFirstPrimeNumbers(int nb)
    {
        var result = string.Empty;
        var nbPrimes = 0;
        foreach(var primeNumber in GetNextPrime())
        {
            if (result.Length > 0)
                result += ",";
            result += primeNumber.ToString();

            if (++nbPrimes >= nb)
                break;
        }

        return result;
    }

    public static IEnumerable<int> GetNextPrime()
    {
        var currentNumber = 2;
        while (true)
        {
            if (isPrime())
                yield return currentNumber;

            ++currentNumber;
        }

        bool isPrime()
        {
            for (int i = 2; i < currentNumber; ++i)
            {
                if (currentNumber % i == 0)
                    return false;
            }

            return true;
        }
    }
}
