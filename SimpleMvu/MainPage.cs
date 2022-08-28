namespace SimpleMvu;
public class MainPage : View
{
    readonly State<int> count = 0;

    [Body]
    View body()
        => new VStack(spacing: 25) {
            new Text("Counter")
                .FontSize(32)
                .HorizontalLayoutAlignment(LayoutAlignment.Start),

            new Text(() => $"Current count: {count.Value}")
                .FontSize(18)
                .HorizontalLayoutAlignment(LayoutAlignment.Start),

            new Button("Click me", () => count.Value++)
                .HorizontalLayoutAlignment(LayoutAlignment.Start),
        }
        .Padding(new Thickness(30, 0))
        .VerticalLayoutAlignment(LayoutAlignment.Start);
}


