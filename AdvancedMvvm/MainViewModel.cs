using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AdvancedMvvm;
public class MainViewModel : BaseViewModel
{
    public ICommand AddItemCommand
        => new Command<Entry>((Entry entry) => AddItem(entry.Text));

    public ICommand ToggleItemCommand
        => new Command<TodoItemViewModel>((TodoItemViewModel item) => ToggleItem(item));

    public ObservableCollection<TodoItemViewModel> Items { get; } = new();

    public void ToggleItem(TodoItemViewModel item)
    {
        item.IsComplete = !item.IsComplete;
    }

    public void AddItem(string text)
    {
        Items.Add(new TodoItemViewModel { Title = text });
    }
}
