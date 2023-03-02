namespace MeetingRoom.Models
{
    public class MonitorItemModel : BindableObject
    {
        public string Icon { get; set; }
        public string Header { get; set; }
        //public double Value { get; set; }// 动态，  通知
        private double _value;

        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Unit { get; set; }
        public string State { get; set; }
    }
}
