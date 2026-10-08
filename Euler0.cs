// find 777000^2 (or start with five) int is not big enough
using System.Globalization;

List<long> squares = new List<long>();
// create loop to find all squares until 777000 found
for (long i = 1; i <= 5; i++)
{
    // grab your newly created list named squares and add the squares until you reach <= 5 as requested above
    squares.Add(i * i);
}
Console.WriteLine(squares.Count);

long total = 0; // start at zero before adding elements

foreach (long number in squares)
{
    Console.WriteLine(number);
    // skip the evens and add up the rest G
    if (number % 2 != 0)
    {
        total = total + number;
    }

    Console.WriteLine(total);

}
