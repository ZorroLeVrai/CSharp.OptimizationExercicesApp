// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

await DisplayBinaries(5);

async Task DisplayBinaries(int nb)
{
    await foreach (var binaryItem in GenerateBinaryNumbers.GenerateBinaries(5))
        Console.WriteLine(binaryItem);
}
