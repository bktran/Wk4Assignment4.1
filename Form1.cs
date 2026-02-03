namespace Wk4Assignment4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgAll.AutoGenerateColumns = true;
            dgAll.DataSource = PhoneBook.Contacts.Values.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person person = (Person)dgAll.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete {person.FirstName} {person.LastName} from your contacts?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PhoneBook.Contacts.Remove(person.FirstName + person.LastName);
                dgAll.DataSource = null;
                dgAll.DataSource = PhoneBook.Contacts.Values.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm newForm = new AddForm();
            newForm.ShowDialog();
        }

        public void Refresh()
        {
            dgAll.DataSource = null;
            dgAll.DataSource = PhoneBook.Contacts.Values.ToList();
        }
    }
}
