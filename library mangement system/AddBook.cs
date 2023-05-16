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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }

        // Creating Database Connection
        SqlConnectionn addbook_connection = new SqlConnectionn("Data Source=DESKTOP-PPATUEC; " + "Initial Catalog=libraryyy; Integrated Security=true");            
        private void BackButton_Click(object sender, EventArgs e)
        {
            //by clicking on "back" button, it wil go to "Staff Profile" page
            StaffProfile info = new StaffProfile();
            info.Show();
            this.Hide();
        }

        //clears all the textboxes data
        private void clear()
        {
            BookName_Textbox.Clear();
            BookAuthor_Textbox.Clear();
            BookPrice_Textbox.Clear();
            BookQuantity_Textbox.Clear();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (BookName_Textbox.Text != "" && BookAuthor_Textbox.Text != "" && BookPrice_Textbox.Text != ""
                && BookQuantity_Textbox.Text != "")
            {
                //insert values to the database
                addbook_connection.insertTo("insert into addbook values ('" + BookName_Textbox.Text + "','" 
                    + BookAuthor_Textbox.Text + "','" + dateTimePicker1.Text + "','" + BookPrice_Textbox.Text
                    + "','" + BookQuantity_Textbox.Text + "')");

                MessageBox.Show("Record inserted successfully", "Congrass", MessageBoxButtons.OK);
                clear();

                //datagrid view for displaying data (in the form of table)
                dataGridView1.DataSource = addbook_connection.GetData("select * from addbook");
            }
        }

        //"SelectId" will be used for calculating how many enteries are selected
        public int SelectId;
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //if any entry is selected
            if (SelectId > 0)
            {
                //update the data in the database
                addbook_connection.UpdateData(@"Update addbook set bookName='" + BookName_Textbox.Text + "'" +
                    ",bookAuthor='" + BookAuthor_Textbox.Text + "',bookPurh='" + dateTimePicker1.Text + "'" +
                    ",bookPrice='"+BookPrice_Textbox.Text+ "',bookQan='"+BookQuantity_Textbox.Text+"' " +
                    "where book_id = '" + SelectId + "'");
                
                dataGridView1.DataSource = addbook_connection.GetData("select * from addbook");
                MessageBox.Show("Record updated successfully", "Congrass", MessageBoxButtons.OK);
                clear();

            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }

        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //if any 1 or more enteries are selected
            if (SelectId > 0)
            {
                //delete the selected data from the database
                addbook_connection.delete(@"delete from addbook where book_id = '" + SelectId + "'");
                dataGridView1.DataSource = addbook_connection.GetData("select * from addbook");
                MessageBox.Show("Record delete successfully", "Congrass", MessageBoxButtons.OK);
                clear();
            }
            else
            {
                MessageBox.Show("Please Select A record to update", "Error", MessageBoxButtons.OK);
            }

        }
        //storing values from the texboxes into the database
        //and displaying them in the form of a table(DataGrid View)
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectId = int.Parse(dataGridView1.SelectedRows[0].Cells["book_id"].Value.ToString());
            BookName_Textbox.Text = dataGridView1.SelectedRows[0].Cells["bookName"].Value.ToString();
            BookAuthor_Textbox.Text = dataGridView1.SelectedRows[0].Cells["bookAuthor"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells["bookPurh"].Value.ToString();
            BookPrice_Textbox.Text = dataGridView1.SelectedRows[0].Cells["bookPrice"].Value.ToString();
            BookQuantity_Textbox.Text = dataGridView1.SelectedRows[0].Cells["bookQan"].Value.ToString();

        }
        private void ViewBookButton_Click(object sender, EventArgs e)
        {
            //clicking on the "View Book" button, it will show the books data
            dataGridView1.DataSource = addbook_connection.GetData("select * from addbook");
        }

        //Loads the "AddBook" page
        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
