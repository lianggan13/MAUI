using SmartHome.Models;

namespace SmartHome.ViewModels;

public class LightViewModel : BindableObject
{
    public List<LightItemModel> LightControls { get; set; }
    public LightViewModel()
    {
        LightControls = new List<LightItemModel>();
        LightControls.Add(new LightItemModel { ItemType = 1, Header = "筒灯", IsOpen = false, Value1 = 0.6 });
        LightControls.Add(new LightItemModel { ItemType = 1, Header = "门口射灯", IsOpen = true, Value1 = 1 });
        LightControls.Add(new LightItemModel
        {
            ItemType = 2,
            Header = "RGB调光",
            Value1 = 0,
            EditCommand = new Command(DoEditCommand)
        });// 关于EditCommand后面处理

        LightControls.Add(new LightItemModel { ItemType = 3, Header = "冷暖调光", Value1 = 0.8, Value2 = 1 });
    }

    private void DoEditCommand()
    {
        MessagingCenter.Send<LightViewModel>(this, "ShowAlert");
        //Mqtt.Publish("Test", Encoding.UTF8.GetBytes("Hello MAUI!"));
    }
}