namespace Maui.App.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		string userName = this.txtUserName.Text;
		string pwd = this.txtPwd.Text;
		//
		// MainPage
		// /MainPage
		// //MainPage
		// ///MainPage
		await Shell.Current.GoToAsync($"//MainPage?username={userName}&pwd={pwd}");
	}
}