using System.Windows.Input;

namespace SmartHome.ViewModels;

public class MainViewModel : BindableObject
{
    public ICommand RadioButtonCommand => new Command<object>(RadioButton_CheckedChanged);

    public MainViewModel()
    {
    }


    private void RadioButton_CheckedChanged(object obj)
    {
    }



}