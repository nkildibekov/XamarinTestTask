using TestAppX2.ViewModel;
using Xamarin.Forms;

namespace TestAppX2.View
{
    public partial class PersonCreatePage : ContentPage
    {
        public PersonViewModel ViewModel { get; private set; }
        public PersonCreatePage( PersonViewModel pvm )
        {
            InitializeComponent();
            ViewModel = pvm;
            this.BindingContext = ViewModel;
        }
    }
}