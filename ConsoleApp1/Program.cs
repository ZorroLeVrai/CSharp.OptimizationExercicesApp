// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

//await DisplayBinaries(10);
DisplayBinariesUsingTasks(10);

async Task DisplayBinaries(int nb)
{
    await foreach (var binaryItem in GenerateBinaryNumbers.GenerateBinaries(nb))
        Console.WriteLine(binaryItem);
}


void DisplayBinariesUsingTasks(int nb)
{
    var taskArray = GenerateBinaryNumbers.GenerateBinariesUsingTasks(nb);

    Task.WaitAll(taskArray);

    foreach (var taskItem in taskArray)
        Console.WriteLine(taskItem.Result);
}
