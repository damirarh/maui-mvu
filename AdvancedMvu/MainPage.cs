using System.Collections.ObjectModel;

namespace AdvancedMvu;
public class MainPage : View
{
    class TodoItem : BindingObject
    {
        public string Id
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public string Title
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public bool IsComplete
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
    }

    [State]
    readonly ObservableCollection<TodoItem> items = new();

    readonly State<string> newItem = "";

    [Body]
    View body() =>
        new VStack
        {
            new HStack()
            {
                new Image("additem.png")
                    .Frame(width: 20, height: 20)
                    .Background(Colors.Transparent)
                    .Margin(5, 2, 0, 2)
                    .VerticalLayoutAlignment(LayoutAlignment.Center),
                new TextField(newItem, "Enter Todo Item Text", () =>
                    {
                        items.Add(new TodoItem { Title = newItem.Value });
                        this.Reload();
                    })
                    .VerticalLayoutAlignment(LayoutAlignment.Center)
                    .HorizontalLayoutAlignment(LayoutAlignment.Fill),
            },
            new ListView<TodoItem>(() => items)
            {
                ViewFor = (item) => new HStack()
                    {
                        new Text(item.Title)
                            .HorizontalLayoutAlignment(LayoutAlignment.Fill)
                            .VerticalLayoutAlignment(LayoutAlignment.Center)
                            .Color(Colors.Black),
                        item.IsComplete ?
                            new Image("completed.png")
                                .Frame(width: 24, height: 24)
                                .HorizontalLayoutAlignment(LayoutAlignment.End)
                                .VerticalLayoutAlignment(LayoutAlignment.Center) :
                            null,
                    }
                    .Padding(new Thickness(20, 0, 20, 0))
                    .HorizontalLayoutAlignment(LayoutAlignment.Fill)
                    .VerticalLayoutAlignment(LayoutAlignment.Center),
            }.OnSelected((item) => item.IsComplete = !item.IsComplete),
        };
}


