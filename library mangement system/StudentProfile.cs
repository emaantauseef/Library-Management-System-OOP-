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
    //creating a class "StudentProfile" which is inherited from the class "Form"
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }
        public DataTable datatable = new DataTable();
        private void InfoUser_Load(object sender, EventArgs e)
        {
            foreach (DataRow datarow in datatable.Rows)
            {
                //converts the "StudentName" label to string and shows the name of student at its place
                StudentName_Label.Text = datarow["StudentName"].ToString();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            //it goes to the "Details" page
            Details details = new Details();
            details.Show();
            this.Hide();
        }
    }
}


