namespace RomanCalculator.Core.Contracts;

/// <summary>
/// Handles parsing roman from and to arabic numbers.
/// </summary>
public interface IRomanParsingService
{
    /// <summary>
    /// Checks if the given string is a valid roman number and converts it to an int. Returns null if invalid.
    /// </summary>
    int? ToArabic(string roman);

    /// <summary>
    /// Converts the given number into roman format.
    /// </summary>
    string ToRoman(int number);
}