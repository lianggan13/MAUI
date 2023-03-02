namespace Maui.App.Views;

public partial class MeterPage : ContentPage
{
    public MeterPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}