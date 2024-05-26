using System.ComponentModel;
using System.Runtime.CompilerServices;
using RomanCalculator.Core;
using RomanCalculator.Core.Contracts;

namespace RomanCalculator.Wpf;

public class MainViewModel : INotifyPropertyChanged
{
    // In the real world, this would probably be set via dependency injection.
    // For simplicity reasons, we'll just create it ourselves for now
    private readonly ICalculationService _calculationService = new CalculationService();

    private string? _error;
    private string? _sum;
    private string? _value1;
    private string? _value2;

    /// <summary>
    /// Contains an error, if it occurred during calculation. Triggers <see cref="OnPropertyChanged"/> on set.
    /// </summary>
    public string? Error
    {
        get => _error;
        private set
        {
            _error = value;
            OnPropertyChanged();
        }
        
    }

    /// <summary>
    /// The calculated sum in roman number format. Triggers <see cref="OnPropertyChanged"/> on set.
    /// </summary>
    public string? Sum
    {
        get => _sum;
        private set
        {
            _sum = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// The first value to add.
    /// </summary>
    public string? Value1
    {
        get => _value1;
        set
        {
            _value1 = value;
            Sum = _calculationService.AddNumbers(_value1, _value2, out var error);
            Error = error;
        }
    }

    /// <summary>
    /// The second value to add.
    /// </summary>
    public string? Value2
    {
        get => _value2;
        set
        {
            _value2 = value;
            Sum = _calculationService.AddNumbers(_value1, _value2, out var error);
            Error = error;
        }
    }

    /// <summary>
    /// Raised when a value displayed in the UI is changed. Required for WPF. 
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Fires <see cref="PropertyChanged"/> with the Property name of the caller.
    /// </summary>
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}