using System;
using System.Collections.Generic;
using System.Text;

namespace TwowayDataBinding
{
    public class DataformViewModel
    {
        private ContactForm contactsform;
        public ContactForm Contactsform
        {
            get { return this.contactsform; }
            set { this.contactsform = value; }
        }
        public DataformViewModel()
        {
            this.contactsform = new ContactForm();
        }
    }
}
