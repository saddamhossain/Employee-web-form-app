using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebApp
{
    public partial class Employee : System.Web.UI.Page
    {
        private Person aPerson;
        //private string name;
        //private string email;
        //private string address;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            aPerson = new Person();

            aPerson.Name = nameTextBox.Text;
           aPerson.Email = emailTextBox.Text;
            aPerson.Address = addressTextBox.Text;

            ViewState["Person"] = aPerson;
        
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;

        }

        protected void retriveButton_Click(object sender, EventArgs e)
        {
            Person retrivePerson = (Person) ViewState["Person"];
            nameTextBox.Text = retrivePerson.Name;
            emailTextBox.Text = retrivePerson.Email;
            addressTextBox.Text = retrivePerson.Address;
        }
    }
}