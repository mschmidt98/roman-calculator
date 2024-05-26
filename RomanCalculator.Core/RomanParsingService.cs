using System.Text;
using RomanCalculator.Core.Contracts;

namespace RomanCalculator.Core;

public class RomanParsingService : IRomanParsingService
{
        /// <summary>
    /// Tries to parse the given string as a roman number into an int. Returns null if the input string is invalid.
    /// </summary>
    public int? ToArabic(string roman)
    {
        // someone entered an invalid digit, so we'll stop here
        if (roman.Any(x => !RomanDigitMap.ContainsKey(x)))
            return null;
        
        // https://stackoverflow.com/a/26667855
        var sum = 0;
        for (var i = 0; i < roman.Length; i++)
        {
            // if the current digit is a smaller value than the next one, we need to subtract it
            if (i + 1 < roman.Length && RomanDigitMap[roman[i]] < RomanDigitMap[roman[i + 1]])
            {
                sum -= RomanDigitMap[roman[i]];
            }
            else
            {
                sum += RomanDigitMap[roman[i]];
            }
        }

        return sum;
    }

    /// <summary>
    /// Converts the given number back into a roman number.
    /// </summary>
    public string ToRoman(int number)
    {
        // https://stackoverflow.com/a/22039673
        var roman = new StringBuilder();

        foreach (var item in NumberRomanDictionary)
        {
            while (number >= item.Key)
            {
                roman.Append(item.Value);
                number -= item.Key;
            }
        }

        return roman.ToString();
    }

    /// <summary>
    /// Contains a mapping from the latin number characters to their respective arabic number value.
    /// </summary>
    private static readonly IReadOnlyDictionary<char, int> RomanDigitMap = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    /// <summary>
    /// Contains a mapping from the arabic numbers to their roman equivalent.
    /// </summary>
    private static readonly IReadOnlyDictionary<int, string> NumberRomanDictionary = new Dictionary<int, string>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };
}