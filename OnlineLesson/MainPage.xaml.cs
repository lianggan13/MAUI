using System.Reflection;

namespace OnlineLesson
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            while (viewModel == null)
            {
                await Task.Delay(1000); // fix null bug
            }

            if (e.Value)
            {
                viewModel.Page = null;
                var button = sender as RadioButton;
                Type type = Assembly.GetExecutingAssembly().GetType("OnlineLesson.Views." + button.BindingContext.ToString());
                viewModel.Page = (View)Activator.CreateInstance(type);
            }
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {

        }
    }
}