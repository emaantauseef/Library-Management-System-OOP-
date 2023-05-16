using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_mangement_system
{
    //creating a class IssueBook and inheriting from the main class "Form"
    //"Form" represents System.Windows.Form
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }
        private void IssueBook_Load(object sender, EventArgs e)
        {
            //creating sql connection
            SqlConnection connection = new SqlConnection();
    connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; Integrated Security=true";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();

            command = new SqlCommand("select bookName from addbook", connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    BookName_ComboBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
            connection.Close();
        }

        int count;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchStudent_Textbox.Text != "")
            {
                //search the student from the database 
                string student = SearchStudent_Textbox.Text;
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy;" +
                    " Integrated Security=true";
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                //sql query
                command.CommandText = "select * from stdsignup where std_id='" + student + "'";
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //sql query
                command.CommandText = "select count(std_id) from IRbook where std_id='" + student + "' " +
                    "and bookReturnDate is null";
                SqlDataAdapter sda1 = new SqlDataAdapter(command);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1);

                
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                //if rows count is not equal to 0
                if (ds.Tables[0].Rows.Count !=0)
                {
            //then it writes the id, name, phone number, department and email of the searched stuent in the textboxes
                    StudentId_Textbox.Text = ds.Tables[0].Rows[0][0].ToString();
                    StudentName_Textbox.Text = ds.Tables[0].Rows[0][1].ToString();
                    PhoneNum_Textbox.Text = ds.Tables[0].Rows[0][2].ToString();
                    Department_textbox.Text = ds.Tables[0].Rows[0][3].ToString();
                    email_Textbox.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    //clear() clears the textboxes
                    StudentName_Textbox.Clear();
                    PhoneNum_Textbox.Clear();
                    Department_textbox.Clear();
                    email_Textbox.Clear();
                    MessageBox.Show("Invalid Student id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //by clicking on "Issue" Button
        private void IssueButton_Click(object sender, EventArgs e)
        {
            //if the StudentName textbox is not empty
            if (StudentName_Textbox.Text != "")
            {
                if (BookName_ComboBox.SelectedIndex != -1 && count <=2)
                {
                    int id = Int32.Parse(StudentId_Textbox.Text);
                    string studentname = StudentName_Textbox.Text;
                    long phonenumber = Int64.Parse(PhoneNum_Textbox.Text);
                    string department = Department_textbox.Text;
                    string email = email_Textbox.Text;
                    string bookname = BookName_ComboBox.Text;

                    string student = SearchStudent_Textbox.Text;

                    //sql connection
                    SqlConnection connection = new SqlConnection();
                    connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; " +
                        "Integrated Security=true";
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    connection.Open();
                    //sql query
                    command.CommandText = "insert into IRbook(Studentid,StudentName,studentPhone,department," +
                        "stddEmail,Bookkname,bookIssueDate)values('" + id+ "','" + studentname + "','" + phonenumber
                        + "','"+ department + "','" + email + "','" + bookname + "','" + dateTimePicker1.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Book Issue","success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Maximum Books Has Been Issued", "No Book selected", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchStudent_TextChanged(object sender, EventArgs e)
        {
            //if 'SearchStudent' textbox is empty then it clears all the other textboxes
            if (SearchStudent_Textbox.Text == "")
            {
                StudentId_Textbox.Clear();
                StudentName_Textbox.Clear();
                PhoneNum_Textbox.Clear();
                Department_textbox.Clear();
                email_Textbox.Clear();
            }
        }

        //by clicking on "Back" button
        private void BackButton_Click(object sender, EventArgs e)
        {
            //it will go back to the "StaffProfile" page
            StaffProfile stf1 = new StaffProfile();
            stf1.Show();
            this.Hide();
        }
    }
}
