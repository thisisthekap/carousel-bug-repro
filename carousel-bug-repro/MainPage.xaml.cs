namespace carousel_bug_repro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        BindingContext = new MainPageViewModel();
        InitializeComponent();
    }
}