using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_mangement_system
{
    //creating class Staff_SignUp and inheriting the properties from base class "Form"
    public partial class Staff_SignUp : Form
    {
        public Staff_SignUp()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        //creating sql connection
        SqlConnectionn signup_connection = new SqlConnectionn("Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; " +
            "Integrated Security=true");

        //by clicking on Signin button, it will go to the "StaffLogin" page
        private void SigninButton_Click(object sender, EventArgs e)
        {
            StaffLogin stafflogin = new StaffLogin();
            stafflogin.Show();
            this.Hide();
        }

        //by clicking on SignUp button it will ask to enter values
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (Name_Textbox.Text != "" && PhoneNum_TextBox.Text != "" && Email_Textbox.Text != "" 
                && Password_Textbox.Text != "")
            {
                //insert into table in the database
                signup_connection.insertTo("insert into signupp values('" + Name_Textbox.Text + "','" 
                    + PhoneNum_TextBox.Text + "','" + Email_Textbox.Text + "','" + Password_Textbox.Text + "')");

                MessageBox.Show("Sucessfully signin", "Add record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Going back to "StaffLogin" page
                StaffLogin StaffLogin = new StaffLogin();
                StaffLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(".........", "Error", MessageBoxButtons.OK);
            }
        }
        // on clicking the Exit Button, it exists the application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //loads the "Staff_SignUp" page
        private void StaffSignUp_Load(object sender, EventArgs e)
        {

        }

    }
}
