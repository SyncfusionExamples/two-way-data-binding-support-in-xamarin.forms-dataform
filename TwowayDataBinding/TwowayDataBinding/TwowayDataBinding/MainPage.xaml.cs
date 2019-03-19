using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwowayDataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ContactForm item = new ContactForm();
        public MainPage()
        {
            InitializeComponent();
            dataForm.SourceProvider = new SourceProviderExt();
            dataForm.DataObject = item;
            button.Clicked += Button_Clicked;
            dataForm.RegisterEditor("LastName", "MultilineText");
            dataForm.RegisterEditor("Password", "Password");
            dataForm.RegisterEditor("DateOfBith", "Date");
            dataForm.RegisterEditor("TimeOfBirth", "Time");
            dataForm.RegisterEditor("Age", "NumericUpDown");
            dataForm.RegisterEditor("Indian", "Switch");
            dataForm.RegisterEditor("City", "DropDown");
            dataForm.RegisterEditor("Country", "Picker");
            dataForm.RegisterEditor("State", "RadioGroup");
            dataForm.RegisterEditor("Planet", "Segment");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            item.FirstName = "Kely";
            item.State = "Tamilnadu";
            item.LastName = "williams";
            item.Password = "passwod";
            item.Indian = true;
            item.NRI = true;
            item.Planet = "Earth";
            item.State = "Tamilnadu";
            item.Country = "Brazil";
            item.City = "Salem";
            item.ContactNumber = 1234;
            item.Age = 12;
            item.TimeOfBirth = new DateTime(12, 12, 12, 12, 12, 12);
            item.DateOfBith = new DateTime(1996, 3, 12);
        }
    }
    public class SourceProviderExt : SourceProvider
    {
        public override IList GetSource(string sourceName)
        {
            var list = new List<string>();
            if (sourceName == "City")
            {
                list.Add("Chennai");
                list.Add("Salem");
                list.Add("Madurai");
            }
            else if (sourceName == "Country")
            {
                list.Add("Canada");
                list.Add("Argentina");
                list.Add("Brazil");
            }
            else if (sourceName == "State")
            {
                list.Add("Tamilnadu");
                list.Add("Telegana");
                list.Add("Maharastra");
            }
            else if (sourceName == "Planet")
            {
                list.Add("Earth");
                list.Add("Pluto");
                list.Add("Jupiter");
            }
            return list;
        }
    }
    public class ContactForm : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

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
