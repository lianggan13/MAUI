namespace Maui.App.Views;

[QueryProperty($"{nameof(UserName)}", "username")]
[QueryProperty($"{nameof(Passowrd)}", "pwd")]
public partial class MainPage : ContentPage
{
    public string UserName
    {
        get;
        set;
    }
    public string Passowrd
    {
        get;
        set;
    }
    public MainPage()
    {
        InitializeComponent();
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {

    }
}

