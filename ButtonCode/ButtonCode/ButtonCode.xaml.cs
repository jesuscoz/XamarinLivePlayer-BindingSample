
using ButtonCode.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonCode : ContentPage
    {
        public ButtonCode()
        {
            BindingContext = new ButtonCountViewModel();
            InitializeComponent();
        }
    }
}