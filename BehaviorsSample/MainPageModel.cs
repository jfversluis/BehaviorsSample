using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace BehaviorsSample
{
    public class MainPageModel : INotifyPropertyChanged
    {
        private int clickCount;

        public int ClickCount
        {
            get => clickCount;
            set
            {
                clickCount = value;
                NotifyPropertyChanged();
            }
        }

        public Command ClickCommand { get; set; }

        public MainPageModel()
        {
            ClickCommand = new Command(() => ClickCount++);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}