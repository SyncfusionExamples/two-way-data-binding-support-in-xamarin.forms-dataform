using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TwowayDataBinding;
using Xamarin.Forms;

namespace TwowayDataBinding
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        Button button;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            button = bindable.FindByName<Button>("button");
            dataForm.SourceProvider = new SourceProviderExt();
            button.Clicked += Button_Clicked;
            dataForm.RegisterEditor("LastName", "MultilineText");
            dataForm.RegisterEditor("Password", "Password");
            dataForm.RegisterEditor("DateOfBith", "Date");
            dataForm.RegisterEditor("TimeOfBirth", "Time");
            dataForm.RegisterEditor("Age", "NumericUpDown");
            dataForm.RegisterEditor("Indian", "Switch");
            dataForm.RegisterEditor("City", "DropDown");
            dataForm.RegisterEditor("State", "RadioGroup");
            dataForm.RegisterEditor("Planet", "Segment");

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = dataForm.DataObject as ContactForm;
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
    }
}
