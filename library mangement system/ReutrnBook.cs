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
    //creating a partial class "ReturnBook"
    //inheriting the properties of the base class "Form"
    //"Form" represents "System.Windows.Form"
    public partial class ReutrnBook : Form
    {
        public ReutrnBook()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //by clicking on "Back" button, it will go to the "StaffProfile" page
            StaffProfile Staffprofile = new StaffProfile();
            Staffprofile.Show();
            this.Hide();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //creating SQL Connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; " + "Integrated Security=true";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //sql query
            command.CommandText = "select * from IRbook where std_id='"+SearchStudent_Textbox.Text+ "'and " + "bookReturnDate is null";
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid Student id or No book Issued", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
         }
        long RowId;
        string BookName;
        string IssueBookDate;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if cell value is not null
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                //then get the values of row id, book name and issue book date in data grid view
                RowId = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                BookName = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                IssueBookDate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            BookName_Textbox.Text = BookName;
            IssueDate_TextBox.Text = IssueBookDate;
        }
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            //creating sql connection
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; " +
                "Integrated Security=true";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Connection.Open();
            Command.CommandText = "update IRbook set bookReturnDate='"+dateTimePicker1.Text+ "'where  std_id='"
                +SearchStudent_Textbox.Text+"'and idd='"+RowId+"'";
            Command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Return Successfull", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Loading the "ReturnBook" Page
        private void ReutrnBook_Load(object sender, EventArgs e)
        {

        }

    }
}
