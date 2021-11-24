namespace MinimalMaui;

public class App : Application
{
    public App()
    {
        MainPage = new ContentPage {
            Content = new GridLayout {
                Children = {
                    new Label {
                        Text = "MinimalMaui App",
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center
                    }
                }
            }
        };
    }
}
