using System.ComponentModel;

namespace MauiBinding
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;
        public string FirstName 
        {
            get => firstName;
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }

        private string email;
        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }

        private string password;
        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ClearFields()
        {
            FirstName = LastName = Email = Password = string.Empty;
        }
    }
}