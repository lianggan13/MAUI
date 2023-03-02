using SmartHome.Models;

namespace SmartHome.ViewModels;

public class LightViewModel : BindableObject
{
    public List<LightItemModel> LightControls { get; set; }
    public LightViewModel()
    {
        LightControls = new List<LightItemModel>();
        LightControls.Add(new LightItemModel { ItemType = 1, Header = "Ͳ��", IsOpen = false, Value1 = 0.6 });
        LightControls.Add(new LightItemModel { ItemType = 1, Header = "�ſ����", IsOpen = true, Value1 = 1 });
        LightControls.Add(new LightItemModel
        {
            ItemType = 2,
            Header = "RGB����",
            Value1 = 0,
            EditCommand = new Command(DoEditCommand)
        });// ����EditCommand���洦��

        LightControls.Add(new LightItemModel { ItemType = 3, Header = "��ů����", Value1 = 0.8, Value2 = 1 });
    }

    private void DoEditCommand()
    {
        MessagingCenter.Send<LightViewModel>(this, "ShowAlert");
        //Mqtt.Publish("Test", Encoding.UTF8.GetBytes("Hello MAUI!"));
    }
}