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

namespace NWU_Secondhand_Textbooks
{
    public partial class Availible_Textbooks : Form
    {
        public Availible_Textbooks()
        {
            InitializeComponent();
        }
        //declaring the global variables
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring, sql;
        SqlDataAdapter adpt;

        private void viewAll(String modCode)
        {
            try
            {
                String sqlMod = "";
                //checking if the module code is null
                if(modCode.Equals("All") || modCode.Equals(null))
                    sqlMod = "";
                else
                    sqlMod = modCode;

                //opening the connection
                conn.Open();

                //creating the sql adapter
                adpt = new SqlDataAdapter();

                //creating a dataset
                ds = new DataSet();

                //creating the sql command
                string sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                                Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                                Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                                Join Condition On Textbook.Con_ID = Condition.Con_Id
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                $" Where Module.ModuleCode Like '%{sqlMod}%'"; //d

                //excecuting the sql command
                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;

                //filling the table
                adpt.Fill(ds, "TextBook");

                //filling and assigning the dataset to the data grid views
                dgvAvailable.DataSource = ds;
                dgvAvailable.DataMember = "TextBook";

                //closing the connection
                conn.Close();

            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error with the displaying the data from the database. Code:" + error.Message);
            }
        }

        private void Availible_Textbooks_Load(object sender, EventArgs e)
        {
            try
            {
                connectionstring = @"Data Source=.;Initial Catalog=TestBooks;Integrated Security=True";
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error in connecting to database. Code: " + error.Message);
            }
            conn.Close();

            //opening the connection
            conn.Open();

            //creating sql command
            sql = $"Select Distinct ModuleCode from Module"; //d

            //applying the sql command and adding it the the reader
            cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //adding a blank feild
            cbModule.Items.Add("All");

            //reading and adding the data to the list boxes the combo boxes
            while (reader.Read())
            {
                //adding the data to the Comboboxes
                cbModule.Items.Add(reader.GetString(0));
            }

            //cosing the reader
            reader.Close();

            //closing the connection
            conn.Close();

            //calling view all method
            viewAll("");
        }



        private void cbModule_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //ensuring something is selected
            if(cbModule.SelectedIndex != -1)
            {
                //calling view all method
                viewAll(cbModule.SelectedItem.ToString());
            }
        }
    }
}