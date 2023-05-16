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
    //inheriting properties from the base class "Form"
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }
        //creating database connection
        SqlConnection StaffLogin_connection = new SqlConnection("Data Source=DESKTOP-PPATUEC;" +"Initial Catalog=libraryyy; " +"Integrated Security=true");

        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (email_textbox.Text != "" && password_textbox.Text != "")
            {
                //creating a new sql connection object
                SqlDataAdapter adapter = new SqlDataAdapter("select * from signupp where staffEmail ='"
                    + email_textbox.Text + "'" +" and staffPass ='" + password_textbox.Text 
                    + "'", StaffLogin_connection);
                
                StaffLogin_connection.Open();


                //open staff's profile page when the connection is successfull and when user writes email and password in the textbox

                StaffProfile staffprofile = new StaffProfile();
                DataTable datatable = new DataTable();
                adapter.Fill(staffprofile.datatable);
                adapter.Fill(datatable);
                if (datatable.Rows.Count > 0)
                {
                    MessageBox.Show("Sucessfully Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    staffprofile.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user name or password", "Invalid", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //closing the connection
                StaffLogin_connection.Close();
            }
        }

        //On clicking the "Create Account" Button
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Staff_SignUp staff_signup = new Staff_SignUp();
            staff_signup.Show();
            this.Hide();
        }

        //Loading the Staff Login page
        private void stafflogin_Load(object sender, EventArgs e)
        {

        }
    }
}
