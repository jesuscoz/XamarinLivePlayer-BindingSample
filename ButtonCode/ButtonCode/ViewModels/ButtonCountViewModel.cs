using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ButtonCode.ViewModels
{
    public class ButtonCountViewModel : INotifyPropertyChanged
    {

        private BindableViewModel _bindableViewModel;
        private NotificableViewModel _notificableViewModel;

        public ButtonCountViewModel()
        {
            _bindableViewModel = new BindableViewModel();
            _notificableViewModel = new NotificableViewModel();
        }

        public BindableViewModel BindableViewModel { get { return _bindableViewModel; } set { _bindableViewModel = value; } }

        public NotificableViewModel NotificableViewModel { get { return _notificableViewModel; } set { _notificableViewModel = value; } }

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
    }
}