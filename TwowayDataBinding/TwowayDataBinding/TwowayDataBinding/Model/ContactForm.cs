using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TwowayDataBinding
{
    public class ContactForm : INotifyPropertyChanged
    {
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        private string firstName;
        private string lastName;
        private int contactNo;
        private int age;
        private string password;
        private string state;

        public ContactForm()
        {

        }

        [Display(ShortName = "First Name")]
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                this.RaisePropertyChanged("FirstName");
            }
        }

        [Display(ShortName = "Last Name")]
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                this.RaisePropertyChanged("LastName");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                this.RaisePropertyChanged("Password");

            }
        }

        [Display(ShortName = "Contact Number")]
        public int ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
                this.RaisePropertyChanged("ContactNumber");

            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                this.age = value;
                this.RaisePropertyChanged("Age");

            }
        }

        private bool nri;
        public bool NRI
        {
            get { return this.nri; }
            set
            {
                this.nri = value;
                this.RaisePropertyChanged("NRI");
            }
        }
        private bool indian;
        public bool Indian
        {
            get { return this.indian; }
            set
            {
                this.indian = value;
                this.RaisePropertyChanged("Indian");
            }
        }
        private string country;
        public string Country
        {
            get { return this.country; }
            set
            {
                this.country = value;
                this.RaisePropertyChanged("Country");
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                this.RaisePropertyChanged("State");
            }
        }

        private string city;
        public string City
        {
            get { return this.city; }
            set
            {
                this.city = value;
                this.RaisePropertyChanged("City");
            }
        }
        private string planet;
        public string Planet
        {
            get { return this.planet; }
            set
            {
                this.planet = value;
                this.RaisePropertyChanged("Planet");
            }
        }
        private DateTime dateOfBith;

        [DataType(DataType.Date)]
        public DateTime DateOfBith
        {
            get { return this.dateOfBith; }
            set
            {
                this.dateOfBith = value;
                this.RaisePropertyChanged("DateOfBith");
            }
        }
        private DateTime timeOfBirth;

        public event PropertyChangedEventHandler PropertyChanged;

        [DataType(DataType.Time)]

        public DateTime TimeOfBirth
        {
            get { return this.timeOfBirth; }
            set
            {
                this.timeOfBirth = value;
                this.RaisePropertyChanged("TimeOfBirth");
            }
        }
    }
}


