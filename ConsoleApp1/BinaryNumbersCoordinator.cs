namespace ConsoleApp1;

internal class BinaryNumbersCoordinator
{
    private int[] _numbers;

    public BinaryNumbersCoordinator(byte nbNumber)
    {
        _numbers = NumberGenerator.GenerateIntegers(nbNumber, 0, 255);
    }

    public void Execute()
    {
        var gbn = new BinaryNumbersCalculator(_numbers);
        var dbn = new BinaryNumbersDisplayer(gbn);
        dbn.DisplayBinariesAsync().Wait();
        //Console.WriteLine();
        //dbn.DisplayBinariesUsingTaskArray();
        //Console.WriteLine();
        //dbn.DisplayBinariesInExecutionOrder();
    }
}
