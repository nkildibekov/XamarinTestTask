using TestAppX2.ViewModel;
using Xamarin.Forms;

namespace TestAppX2.View
{
    public partial class PersonPage : ContentPage
    {
        public PersonViewModel ViewModel { get; private set; }
        public PersonPage(PersonViewModel pvm)
        {
            InitializeComponent();
            ViewModel = pvm;
            this.BindingContext = ViewModel;       
        }
    }
}