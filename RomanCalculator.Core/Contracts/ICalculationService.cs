namespace RomanCalculator.Core.Contracts;

public interface ICalculationService
{
    /// <summary>
    /// Adds the given roman numbers to each other if they are valid, or returns null if they are not.
    /// In that case, the out parameter <paramref name="error"/> is set.
    /// </summary>
    string? AddNumbers(string? val1, string? val2, out string? error);
}