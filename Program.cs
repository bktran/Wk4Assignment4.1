namespace Wk4Assignment4._1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Person p1 = new Person() {FirstName = "Bao", LastName = "Tran" , Mobile = 123456789, Work = 987654321, Address = "Chicago, IL"  };
            Person p2 = new Person() {FirstName = "Sophia", LastName = "Tran" , Mobile = 321654987, Work = 987456321, Address = "Chicago, IL"  };
            PhoneBook.Contacts.Add(p1.FirstName.ToLower() + p1.LastName.ToLower(), p1);
            PhoneBook.Contacts.Add(p2.FirstName.ToLower() + p2.LastName.ToLower(), p2);

            Application.Run(new Form1());
        }
    }
}