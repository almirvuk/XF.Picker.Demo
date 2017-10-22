using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XF.Picker.Demo.Models;

namespace XF.Picker.Demo.ViewModels {

    public class AllPersonsViewModel : INotifyPropertyChanged{

        public ObservableCollection<Person> AllPersons { get; set; }

        private Person selectedPerson;
        public Person SelectedPerson {
            get { return selectedPerson; }
            set { selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public AllPersonsViewModel() {

            AllPersons = new ObservableCollection<Person>() {

                new Person() {
                    Biography = "Lorem ipsum person 1",
                    FName = "Person",
                    LName = "One",
                    PersonId = 1,
                },

                new Person() {
                    Biography = "Lorem ipsum person 2",
                    FName = "Person",
                    LName = "Two",
                    PersonId = 2,
                },

                 new Person() {
                    Biography = "Lorem ipsum person 3",
                    FName = "Person",
                    LName = "Three",
                    PersonId = 3,
                },

            };
            

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
