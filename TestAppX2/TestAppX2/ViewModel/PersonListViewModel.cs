using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using TestAppX2.View;

namespace TestAppX2.ViewModel
{
    public class PersonListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<PersonViewModel> Persons { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand EditPersonCommand { protected set; get; }
        public ICommand CreatePersonCommand { protected set; get; }
        public ICommand DeletePersonCommand { protected set; get; }
        public ICommand SavePersonCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        PersonViewModel selectedPerson;

        public INavigation Navigation { get; set; }

        public PersonListViewModel()
        {
            Persons = new ObservableCollection<PersonViewModel>()
            {
                new PersonViewModel() {FirstName="Igor", LastName="Serganov", PhoneNumber="+380674899448"},
                new PersonViewModel() {FirstName="Nikita", LastName="Kildibekov", PhoneNumber="+380993174320"},
                new PersonViewModel() {FirstName="Viktor", LastName="Prokopenko", PhoneNumber="+380982159299"},
                new PersonViewModel() {FirstName="Vika", LastName="Kildibekova", PhoneNumber="+380674899448"},
                new PersonViewModel() {FirstName="Maria", LastName="Prokopenko", PhoneNumber="+380993174320"},
                new PersonViewModel() {FirstName="Svetlana", LastName="Ivanova", PhoneNumber="+380982159299"}
            };
            EditPersonCommand = new Command(EditPerson);
            CreatePersonCommand = new Command(CreatePerson);
            DeletePersonCommand = new Command(DeletePerson);
            SavePersonCommand = new Command(SavePerson);
            BackCommand = new Command(Back);
        }

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                if (selectedPerson != value)
                {
                    PersonViewModel tempPerson = value;
                    selectedPerson = null;
                    OnPropertyChanged("SelectedPerson");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private void EditPerson( object personObject )
        {
            PersonViewModel person = personObject as PersonViewModel;
            if (person != null)
            {
                Navigation.PushAsync( new PersonEditPage( person ) );
            }
            Back();

        }
        private void CreatePerson()
        {
            Navigation.PushAsync(new PersonCreatePage(new PersonViewModel() { ListViewModel = this }));
        }        
        private void SavePerson(object personObject)
        {
            PersonViewModel person = personObject as PersonViewModel;
            if (person != null && person.IsValid)
            {
                Persons.Add(person);
            }
            Back();
        }
        private void DeletePerson(object personObject)
        {
            PersonViewModel person= personObject as PersonViewModel;
            if (person != null)
            {
                Persons.Remove(person);
            }
            Back();
        }

        private void Back()
        {
            Navigation.PopAsync();
        }
    }
}