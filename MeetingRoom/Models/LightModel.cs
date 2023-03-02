namespace MeetingRoom.Models
{
    public class LightModel : BindableObject
    {
        private bool state;

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged();
            }
        }

    }
}
