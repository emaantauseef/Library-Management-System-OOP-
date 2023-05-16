using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_mangement_system
{
    public partial class StaffProfile : Form
    {
        public StaffProfile()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        //creating sql connection
        SqlConnection StaffProfileConnection = new SqlConnection("Data Source=DESKTOP-PPATUEC; " +
            "Initial Catalog=libraryyy; Integrated Security=true");
           
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            //by clicking on "Add Book" Button it will go to the "AddBook" page
            AddBook addbook = new AddBook();
            addbook.Show();
            this.Hide();
        }
        private void ReturnBook_Click(object sender, EventArgs e)
        {
            //by clicking on "Return Book" Button it will go to the "ReturnBook" page
            ReutrnBook returnbook = new ReutrnBook();
            returnbook.Show();
            this.Hide();
        }

        private void IssueBookButton_Click(object sender, EventArgs e)
        {
            //by clicking on "Issue Book" Button it will go to the "IssueBook" page
            IssueBook issuebook = new IssueBook();
            issuebook.Show();
            this.Hide();
        }
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            //by clicking on "Details" Button it will go to the "Details" page
            Details details = new Details();
            details.Show();
            this.Hide();
        }
        private void AccountForStudent_Click(object sender, EventArgs e)
        {
            //by clicking on "Create Account for Student" Button it will go to the "StudentSignin" page
            StudentLogin student_signin = new StudentLogin();
            student_signin.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //by clicking "Logout" Button it will go back to the "StaffLogin" page
            StaffLogin Stafflogin = new StaffLogin();
            Stafflogin.Show();
            this.Hide();
        }

        public DataTable datatable = new DataTable();
        private void StaffProfile_Load(object sender, EventArgs e)
        {
    
        }
    }
}
