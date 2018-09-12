using Xamarin.Forms;
using TestAppX2.ViewModel;
using System;

namespace TestAppX2.View
{
    public partial class PersonListPage : ContentPage
    {
        public PersonListPage()
        {
            InitializeComponent();
            BindingContext = new PersonListViewModel() { Navigation = this.Navigation };
        }

        
    }
}