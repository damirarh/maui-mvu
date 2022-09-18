namespace AdvancedMvvm;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        viewModel = new MainViewModel();
        BindingContext = viewModel;
    }

    public void OnListItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is TodoItemViewModel item)
        {
            viewModel.ToggleItemCommand.Execute(item);
        }
        if (sender is ListView itemList)
        {
            itemList.SelectedItem = null;
        }
    }
}

