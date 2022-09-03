using RomanNumeralsConverter.Models;

var input = string.Empty;
var romanNumerals = new RomanNumerals();

Console.WriteLine("Hello, come in to the world of Roman Numerals Converter");
Console.Write("Please enter a Roman Numerals: ");

input = Console.ReadLine();

try
{
    var numberConverted = romanNumerals.ConvertRomanNumeral(input);
    Console.WriteLine("Your converted number is " + numberConverted);
}
catch (Exception ex)
{
    Console.WriteLine("This is not a valid Roman Numeral and can not be converted");
}

Console.WriteLine("Press any key to end program");
Console.ReadLine();

