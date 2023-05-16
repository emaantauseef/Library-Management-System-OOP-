using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_mangement_system{

    //creating a partial class "StudentSignUp"
    //inheriting the properties of base class "Form"
    public partial class StudentSignUp : Form
    {
        public StudentSignUp()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }
      
        //creating sql connection
        SqlConnectionn connection = new SqlConnectionn("Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; Integrated Security=true");

        //clears are the entries in the textboxes
        private void clear()
        {
            StudentName_Textbox.Clear();
            PhoneNumber_TextBox.Clear();
            email_Textbox.Clear();
            Password_Textbox.Clear();
            Department_Textbox.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //if the textboxes are not empty
            if (StudentName_Textbox.Text != "" && PhoneNumber_TextBox.Text != "" && Department_Textbox.Text != "" && email_Textbox.Text != "" && Password_Textbox.Text != "")
            {
                //insert the values of textboxes in the database
                connection.insertTo("insert into studentsignup values ('" + StudentName_Textbox.Text + "','" + PhoneNumber_TextBox.Text + "','" + Department_Textbox.Text + "','" + email_Textbox.Text + "','" + Password_Textbox.Text + "')");
                MessageBox.Show("Record inserted successfully", "Congrass", MessageBoxButtons.OK);
                clear();
                dataGridView1.DataSource = connection.GetData("select * from studentsignup");
            }
        }
      
        //by clicking on the "View" Button, it gets the data about students from the database
        private void ViewButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connection.GetData("select * from studentsignup");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //by clicking on the "Back" button, it goes to the "StaffProfile" page
            StaffProfile staffprofile = new StaffProfile();
            staffprofile.Show();
            this.Hide();
        }

        //selectId is used here to see if any entry is selected or not
        public int selectId;
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //if any 1 or more enteries are selected
            if (selectId > 0)
            {
                //then update the data in the tables of the database
                connection.UpdateData(@"Update stdsignup set stdName='" + StudentName_Textbox.Text + "'" +
                    ",stdPhone='" + PhoneNumber_TextBox.Text + "',depart='" + Department_Textbox.Text + "'," +
                    "stdEmail='" + email_Textbox.Text + "',stdPass='" + Password_Textbox.Text + "' " +
                    "where std_id = '" + selectId + "'");
                dataGridView1.DataSource = connection.GetData("select * from stdsignup");
                //shows that record has been updated suucessfully
                MessageBox.Show("Record updated successfully", "Congrass", MessageBoxButtons.OK);
                //then clears all the entries in the textboxes
                clear();

            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //if any entry is selected
            if (selectId > 0)
            {
                //then delete the selected row from the table in the database
                connection.delete(@"delete from stdsignup where std_id = '" + selectId + "'");
                dataGridView1.DataSource = connection.GetData("select * from stdsignup");
                //shows that record has been deleted suucessfully
                MessageBox.Show("Record delete successfully", "Congrass", MessageBoxButtons.OK);
                //then clears all the entries in the textboxes
                clear();

            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectId = int.Parse(dataGridView1.SelectedRows[0].Cells["std_id"].Value.ToString());
            StudentName_Textbox.Text = dataGridView1.SelectedRows[0].Cells["stdName"].Value.ToString();
            PhoneNumber_TextBox.Text = dataGridView1.SelectedRows[0].Cells["stdPhone"].Value.ToString();
            Department_Textbox.Text = dataGridView1.SelectedRows[0].Cells["depart"].Value.ToString();
            email_Textbox.Text = dataGridView1.SelectedRows[0].Cells["stdEmail"].Value.ToString();
            Password_Textbox.Text = dataGridView1.SelectedRows[0].Cells["stdPass"].Value.ToString();
        }

        private void StudentSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
