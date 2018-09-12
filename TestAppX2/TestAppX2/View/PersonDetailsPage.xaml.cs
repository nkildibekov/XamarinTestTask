using TestAppX2.ViewModel;
using Xamarin.Forms;

namespace TestAppX2.View
{
    public partial class PersonDetailPage : ContentPage
    {
        public PersonViewModel ViewModel { get; private set; }
        public PersonDetailPage(PersonViewModel pvm)
        {
            InitializeComponent();
            ViewModel = pvm;
            this.BindingContext = ViewModel;
        }
    }
}