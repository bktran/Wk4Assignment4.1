using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Wk4Assignment4._1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == string.Empty || txtLast.Text == string.Empty)
            {
                MessageBox.Show("First and Last Name cannot be blank");
            }
            else if (txtMobile.Text == string.Empty && txtWork.Text == string.Empty)
            {
                MessageBox.Show("Atleast one Phone number must not be blank!");
            }
            else 
            {
                Person person = new Person();
                person.FirstName = txtFirst.Text;
                person.LastName = txtLast.Text;
                bool hasMobile = long.TryParse(txtMobile.Text, out long mobile);
                bool hasWork = long.TryParse(txtWork.Text, out long work);
                if (hasMobile)
                {
                    person.Mobile = mobile;
                }
                else if (hasWork) 
                {
                    person.Work = work;
                }
                person.Address = txtAddress.Text;

                PhoneBook.Contacts.Add(person.FirstName + person.LastName, person);
                MessageBox.Show("Contact Added!");
                
                this.Close();
            }

            
        }
    }
}
