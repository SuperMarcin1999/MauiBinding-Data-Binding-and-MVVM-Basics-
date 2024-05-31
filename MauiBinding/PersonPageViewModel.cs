using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiBinding
{
    public class PersonPageViewModel : INotifyPropertyChanged
    {
        public Person Person { get; } = new Person();

        public PersonPageViewModel()
        {
            PostPeopleCommand = new Command(AddPerson);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand PostPeopleCommand { get; }

        public void AddPerson()
        {
            // add to db!

            Person.ClearFields();
        }
    }
}
