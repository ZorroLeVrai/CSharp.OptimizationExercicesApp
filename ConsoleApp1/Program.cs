// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

await DisplayBinaries(10);

async Task DisplayBinaries(int nb)
{
    await foreach (var binaryItem in GenerateBinaryNumbers.GenerateBinaries(nb))
        Console.WriteLine(binaryItem);
}
