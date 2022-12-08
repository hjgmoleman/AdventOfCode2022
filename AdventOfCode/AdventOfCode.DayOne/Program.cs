using var reader = new StreamReader(File.OpenRead("./input.txt"));

var currentElfNr = 1;
var currentElfAmount = 0;
var maxAmount = 0;
var maxElfNr = 0;

var line = reader.ReadLine();
while (line is not null)
{
    if (line.Length > 0)
    {
        var amount = int.Parse(line);
        currentElfAmount += amount;
    }
    else
    {
        if (maxAmount < currentElfAmount)
        {
            maxElfNr = currentElfNr;
            maxAmount = currentElfAmount;
        }
        currentElfAmount = 0; // reset counter
        currentElfNr++;
    }
    
    line = reader.ReadLine();
}

Console.WriteLine($"Elf {maxElfNr} has the most calories of {maxAmount}");
Console.ReadKey();
