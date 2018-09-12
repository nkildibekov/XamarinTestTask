using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestAppX2.Model;
using TestAppX2.ViewModel;

namespace TestAppX2.DataSource
{
    public class PersonData
    {
        public ObservableCollection<PersonViewModel> GetAllPeople()
        {
            ObservableCollection<PersonViewModel> persons = new ObservableCollection<PersonViewModel>()
            {
                new PersonViewModel() {FirstName="Igor", LastName="Serganov", PhoneNumber="+380674899448"},
                new PersonViewModel() {FirstName="Nikita", LastName="Kildibekov", PhoneNumber="+380993174320"},
                new PersonViewModel() {FirstName="Viktor", LastName="Prokopenko", PhoneNumber="+380982159299"},
                new PersonViewModel() {FirstName="Vika", LastName="Kildibekova", PhoneNumber="+380674899448"},
                new PersonViewModel() {FirstName="Maria", LastName="Prokopenko", PhoneNumber="+380993174320"},
                new PersonViewModel() {FirstName="Svetlana", LastName="Ivanova", PhoneNumber="+380982159299"}
            };
            return persons;
        }        
    }
}
