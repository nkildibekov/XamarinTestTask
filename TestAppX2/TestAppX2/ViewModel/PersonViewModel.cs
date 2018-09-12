using System.ComponentModel;
using TestAppX2.Model;

namespace TestAppX2.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        PersonListViewModel plvm;

        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person();
        }

        public PersonListViewModel ListViewModel
        {
            get { return plvm; }
            set
            {
                if (plvm != value)
                {
                    plvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string FirstName
        {
            get { return Person.FirstName; }
            set
            {
                if (Person.FirstName != value)
                {
                    Person.FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }
        public string LastName
        {
            get { return Person.LastName; }
            set
            {
                if (Person.LastName != value)
                {
                    Person.LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }
        public string PhoneNumber
        {
            get { return Person.PhoneNumber; }
            set
            {
                if (Person.PhoneNumber != value)
                {
                    Person.PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return
                    (!string.IsNullOrEmpty(FirstName.Trim())) ||
                    (!string.IsNullOrEmpty(LastName.Trim()));
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}