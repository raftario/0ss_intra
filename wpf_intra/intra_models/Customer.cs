using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Customer : INotifyPropertyChanged
    {
        private string _name;
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); OnPropertyChanged("DisplayName"); } }
        private string _lastName;
        public string LastName { get => _lastName; set { _lastName = value; OnPropertyChanged(); OnPropertyChanged("DisplayName"); } }
        private string _address;
        public string Address { get => _address; set { _address = value; OnPropertyChanged(); } }
        private string _city;
        public string City { get => _city; set { _city = value; OnPropertyChanged(); } }
        private string _province;
        public string Province { get => _province; set { _province = value; OnPropertyChanged(); } }
        private string _postalCode;
        public string PostalCode { get => _postalCode; set { _postalCode = value; OnPropertyChanged(); } }
        private string _contactInfo;
        public string ContactInfo { get => _contactInfo; set { _contactInfo = value; OnPropertyChanged(); } }
        private string _picturePath;
        public string PicturePath { get => _picturePath; set { _picturePath = value; OnPropertyChanged(); } }
        private string _info;
        public string Info { get => _info; set { _info = value; OnPropertyChanged(); } }

        public string DisplayName => $"{LastName}, {Name}";

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
