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
    //creating a partial class "StudentLogin"
    //inheriting the properties of base class "Form"
    //Here "Form" represents System.Windows.Forms.Form 
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        //creating sql connection
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PPATUEC; " +
            "Initial Catalog=libraryyy; Integrated Security=true");
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (SID_textbox.Text != "" && Password_textbox.Text != "")
            {
                //sql connection with the StudentProfile page
                SqlDataAdapter adapter = new SqlDataAdapter("select * from stdsignup where StudentId = '"
                   + SID_textbox.Text + "' and StudentPassword ='" + Password_textbox.Text + "'", connection);
                connection.Open();
                StudentProfile studentprofile = new StudentProfile();
                DataTable datatable = new DataTable();
                adapter.Fill(studentprofile.datatable);
                adapter.Fill(datatable);
                if (datatable.Rows.Count > 0)
                {
                    MessageBox.Show("Sucessfully Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentprofile.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                connection.Close();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Logincs_Load(object sender, EventArgs e)
        {

        }
    }
}
