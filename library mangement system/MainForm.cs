using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_mangement_system
{
    //creating a partial class "MainForm"
    //"MainForm" is the name of the Form and ':' is used to inherit the properties of base class .
    //Here "Form" represents System.Windows.Forms.Form 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        //The "object sender" portion will be a reference to the button which was clicked
        private void LoginAsStaff_ButtonClick(object sender, EventArgs e)
        {
            StaffLogin stafflogin = new StaffLogin();

            //Show is a method that displays a message in a small window
            stafflogin.Show();

            //hide the windows form
            this.Hide();
        }

        private void LoginAsStudent_ButtonClick(object sender, EventArgs e)
        {
            StudentLogin studentlogin = new StudentLogin();
            studentlogin.Show();
            this.Hide();
        }

        //load the main form
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}

