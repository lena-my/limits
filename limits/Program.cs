Console.WriteLine("Enter a number to define the lowest number ");
string lowestToParse = Console.ReadLine();
Console.WriteLine("Enter a number to define the highest number ");
string highestToParse = Console.ReadLine();

Console.WriteLine($"The limits are {lowestToParse} and {highestToParse}.");

int highest = Convert.ToInt32(highestToParse);
int lowest = Convert.ToInt32(lowestToParse);

Console.WriteLine("Enter a new number ");
string numberToParse = Console.ReadLine();

int number = Convert.ToInt32(numberToParse);

if (number <= highest || number >= lowest) {
    Console.WriteLine($"You have entered {number} which is between {highest} and {lowest}.");
    Console.WriteLine($"Resulting integer: {number}");
}

if (number > highest) {
    Console.WriteLine($"You have entered {number} which is greater than {highest}.");
    Console.WriteLine($"Resulting integer: {highest}");
}

if (number < lowest) {
    Console.WriteLine($"You have entered {number} which is lower than {lowest}.");
    Console.WriteLine($"Resulting integer: {lowest}");
}