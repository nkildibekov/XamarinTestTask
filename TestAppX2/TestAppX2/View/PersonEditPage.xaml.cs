using TestAppX2.ViewModel;
using Xamarin.Forms;

namespace TestAppX2.View
{
    public partial class PersonEditPage : ContentPage
    {
        public PersonViewModel ViewModel { get; private set; }
        public PersonEditPage(PersonViewModel pvm)
        {
            InitializeComponent();
            ViewModel = pvm;
            this.BindingContext = ViewModel;
        }
    }
}