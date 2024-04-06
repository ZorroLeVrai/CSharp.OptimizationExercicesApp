namespace ConsoleApp1;

internal partial class BinaryNumbersDisplayer
{
    public void DisplayBinariesUsingTaskArray()
    {
        Console.WriteLine(nameof(DisplayBinariesUsingTaskArray));
        var taskArray = _binaryGenerator.GenerateBinariesUsingTaskArray();
        Task.WaitAll(taskArray);
        foreach (var taskItem in taskArray)
            Console.WriteLine(taskItem.Result);
    }

    public void DisplayBinariesInExecutionOrder()
    {
        Console.WriteLine(nameof(DisplayBinariesInExecutionOrder));
        List<Task> tasks = new List<Task>();
        foreach (var generateBinariesTask in _binaryGenerator.GenerateBinaries())
            tasks.Add(DisplayResult(generateBinariesTask));

        Task.WaitAll(tasks.ToArray());

        static async Task DisplayResult(Task<BinaryData> binaryGeneratorTask)
        {
            var binaryStr = await binaryGeneratorTask;
            Console.WriteLine(binaryStr);
        }
    }
}
