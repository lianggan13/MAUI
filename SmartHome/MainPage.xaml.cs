using SmartHome.AttachedProperties;
using SmartHome.ViewModels;

namespace SmartHome
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<LightViewModel>(this, "ShowAlert", vm =>
            {
                this.DisplayAlert("提示", "显示一个【编辑】窗口", "OK");
            });
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.mainFrame == null)
                return; // fisrt come...

            if (e.Value)
            {
                var btn = sender as RadioButton;
                Type type = ButtonPageType.GetPageType(btn);
                this.mainFrame.Content = (View)Activator.CreateInstance(type);
            }
            else
            {
                this.mainFrame.Content = null;
            }
        }
    }
}