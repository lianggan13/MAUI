namespace OnlineLesson.ViewModels
{
    public class MainViewModel : BindableObject
    {
        private View _page;

        public View Page
        {
            get { return _page; }
            set
            {
                _page = value;
                OnPropertyChanged();
            }
        }

    }
}
