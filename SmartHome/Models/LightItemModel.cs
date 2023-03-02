namespace SmartHome.Models
{
    public class LightItemModel
    {
        public int ItemType { get; set; } = 1;

        public string Header { get; set; }
        public bool IsOpen { get; set; }
        public double Value1 { get; set; }
        public double Value2 { get; set; }

        public Command EditCommand { get; set; }
    }
}
