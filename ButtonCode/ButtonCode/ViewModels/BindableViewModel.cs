using System.Windows.Input;
using Xamarin.Forms;

namespace ButtonCode.ViewModels
{
    public class BindableViewModel : BindableObject
    {

        private string _text;

        int count = 0;

        public BindableViewModel()
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
        
        private void ClickAsync()
        {
            count++;
            Text = $"{count} click!";
        }
    }
}