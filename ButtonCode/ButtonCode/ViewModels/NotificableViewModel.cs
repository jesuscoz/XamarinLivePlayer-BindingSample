using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ButtonCode.ViewModels
{
    public class NotificableViewModel : INotifyPropertyChanged
    {

        private string _text;

        int count = 0;

        public NotificableViewModel()
        {
            _text = "Tap for click count!";
        }

        public string Text {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public ICommand ClickCommand => new Command(ClickAsync);
        
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private void ClickAsync()
        {
            count++;
            Text = $"{count} click!";
        }
    }
}