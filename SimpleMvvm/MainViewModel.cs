using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SimpleMvvm;
public class MainViewModel : INotifyPropertyChanged
{
    private int count;

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            OnPropertyChanged();
        }
    }

    public ICommand CountCommand
        => new Command(() => Count++);

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
