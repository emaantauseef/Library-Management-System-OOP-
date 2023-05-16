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
    //creating a class "Details" inherited from "Form"
    public partial class Details : Form
    {
        public Details()
        {
            //function for initializing the values of the form
            InitializeComponent();
        }  
        private void detials_Load(object sender, EventArgs e)
        {
            //creating sql connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=DESKTOP-PPATUEC; Initial Catalog=libraryyy; " +
                "Integrated Security=true";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //sql query for the issued books
            command.CommandText = "select * from IRbook where bookReturnDate is null";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];

            //sql query for the returned books
            command.CommandText = "select * from IRbook where bookReturnDate is not null";
            SqlDataAdapter SQLdataAdapter = new SqlDataAdapter(command);
            DataSet DATASET = new DataSet();
            SQLdataAdapter.Fill(DATASET);
            dataGridView2.DataSource = DATASET.Tables[0];
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}




