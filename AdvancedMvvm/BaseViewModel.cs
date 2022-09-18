using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AdvancedMvvm;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetProperty<T>([DisallowNull] ref T storage, T value, [CallerMemberName] string? propertyName = null)
    {
        if (!storage.Equals(value))
        {
            storage = value;
            NotifyPropertyChanged(propertyName);
        }
    }

    protected void NotifyPropertyChanged(string? propertyName = null)
    {
        if (propertyName != null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
