namespace AdvancedMvvm;

public class TodoItemViewModel : BaseViewModel
{
    private string id = Guid.NewGuid().ToString();

    public string Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    private string title = string.Empty;

    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    private bool isComplete = false;

    public bool IsComplete
    {
        get => isComplete;
        set => SetProperty(ref isComplete, value);
    }
}
