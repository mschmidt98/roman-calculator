using RomanCalculator.Core.Contracts;

namespace RomanCalculator.Core;

public class CalculationService : ICalculationService
{
    private readonly IRomanParsingService _parsingService = new RomanParsingService();
    
    /// <inheritdoc />
    public string? AddNumbers(string? val1, string? val2, out string? error)
    {
        if (string.IsNullOrWhiteSpace(val1) || string.IsNullOrWhiteSpace(val2))
        {
            error = "The input values may not be empty";
            return null;
        }

        var parsed1 = TryGetOrParseNumber(val1);
        if (parsed1 is null)
        {
            error = "The first value is not a valid roman or arabic number.";
            return null;
        }

        var parsed2 = TryGetOrParseNumber(val2);
        if (parsed2 is null)
        {
            error = "The second value is not a valid roman or arabic number.";
            return null;
        }

        error = null;
        var sum = parsed1.Value + parsed2.Value;
        var sumRoman = _parsingService.ToRoman(sum);
        return sumRoman;
    }

    /// <summary>
    /// Returns the input as number if it is an arabic number, and tries to parse it as roman otherwise.
    /// </summary>
    private int? TryGetOrParseNumber(string value)
    {
        if (int.TryParse(value, out var intVal))
            return intVal;

        return _parsingService.ToArabic(value);
    }
}