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
    public partial class MaintainAuthor : Form
    {
        public MaintainAuthor()
        {
            InitializeComponent();
        }

        //initialising all of the global variables for the form
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring, sql;
        SqlDataAdapter adpt;
        SqlDataReader reader;

        //this method is to fill the data grid views
        private void viewAll()
        {
            try
            {
                //opening the connection
                conn.Open();

                //creating the sql adapter
                adpt = new SqlDataAdapter();

                //creating a dataset
                ds = new DataSet();

                //creating the sql command
                string sql = @"SELECT* FROM Author ";   //d

                //excecuting the sql command
                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;

                //filling the table
                adpt.Fill(ds, "Author");

                //filling and assigning the dataset to the data grid views
                dgInsertAuthor.DataSource = ds;
                dgInsertAuthor.DataMember = "Author";

                //closing the connection
                conn.Close();

            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error with the displaying the data from the database. Code:" + error.Message);
            }
        }

        //this list boxes
        private void fillListBox(String parmSQL)
        {
            try
            {
                //first clearing the list boxes
                lstDelete.Items.Clear();
                lstUpdate.Items.Clear();

                //opening the connection
                conn.Open();

                //creating an sql command to fill the student number combo boxes
                sql = parmSQL;

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //creating a temporary string to store the values to be added to the list box
                String tempList = "ID, FirstName, Surname";

                //adding the headings to the list box
                lstDelete.Items.Add(tempList);
                lstUpdate.Items.Add(tempList);

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the list boxes
                    tempList = reader.GetInt32(0).ToString() + ", " + reader.GetString(1) + ", " + reader.GetString(2);
                    lstDelete.Items.Add(tempList);
                    lstUpdate.Items.Add(tempList);
                }

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the List boxes the data from the database. Code:" + error.Message);
            }
        }

        private void sqlChanges(String parmSQL)
        {
            //opening the connection
            conn.Open();

            //creating the string for the sql
            string sql = parmSQL;

            //creating sql command
            cmd = new SqlCommand(sql, conn);

            //executing the sql command
            cmd.ExecuteNonQuery();

            //closing the connection
            conn.Close();

            //updating everything
            viewAll();
            fillListBox(@"SELECT * FROM Author"); //d
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting all of the values from the textboxes
            string Auth_name = txtName.Text;
            string Auth_Sname = txtSurname.Text;


            //ensuring nothing is empty
            if (!(Auth_name.Equals("")) && !(Auth_Sname.Equals("")))
            {
                //calling method to excecute the command
                sqlChanges($"INSERT INTO Author(Auth_FName, sName) VALUES('{Auth_name}', '{Auth_Sname}')"); //d

                //letting use know that data added successfully
                MessageBox.Show("Data successfully inserted");

            }
            else
            {
                //letting user know
                MessageBox.Show("Please Ensure nothing is empty");
            }

            
        }

        private void MaintainAuthor_Load(object sender, EventArgs e)
        {
            try
            {
                //creating the connection
                connectionstring = @"Data Source=.;Initial Catalog=TestBooks;Integrated Security=True"; 
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception error)
            {
                //letting the user know
                MessageBox.Show("Error with connecting to the database");
            }
            
            //ensuring thatthe connection isnt open
            conn.Close();

            //calling the view all method to fill data grid view
            viewAll();

            //calling a method to fill the list boxes
            fillListBox(@"SELECT * FROM Author"); //d
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //closing this form and going back to te staff menu
            this.Dispose();
            StaffMenu staff = new StaffMenu();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closing the form
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //creating a temporary strings for an update template
            String strUpdate = "Update Author Set ";

            //ensuring that the user has selected someone
            if (lstUpdate.SelectedIndex != -1)
            {
                //ensuring user updates atleast one value
                if ((txtChangeFName.Text.Equals("")) && (txtChangeSurname.Text.Equals("")))
                {
                    //letting user know
                    MessageBox.Show("Please Update Atleast One Field");

                }
                else
                {
                    //to update firstname
                    if (!(txtChangeFName.Equals("")))
                    {
                        strUpdate += $"Auth_FName = '{txtChangeFName.Text}', ";
                    }

                    //to update surname
                    if (!(txtChangeFName.Equals("")))
                    {
                        strUpdate += $"sName = '{txtChangeSurname.Text}', ";
                    }

                    //removing the last extra comma
                    int index = strUpdate.LastIndexOf(',');
                    strUpdate = strUpdate.Remove(index);

                    //getting the student id that has to be updated
                    String[] tempID = lstUpdate.SelectedItem.ToString().Split(',');

                    //adding end part of the update statement
                    strUpdate += $" Where Author_ID = {tempID[0]};"; //d (Explain how to)

                    //applying update command
                    sqlChanges(strUpdate);

                    //letting use know that data added successfully
                    MessageBox.Show("Data successfully updated");
                }
            }
            else
            {
                //letting user know
                MessageBox.Show("Please Select User To Update");
            }
        }

        private void txtDeleteFName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Author where Auth_FName Like '{txtDeleteFName.Text}%'"); //d
        }

        private void txtDeleteSName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Author where sName Like '{txtDeleteSName.Text}%'"); //d
        }

        private void txtUpdateFName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Author where Auth_FName Like '{txtUpdateFName.Text}%'"); //d
        }

        private void txtUpdateSName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Author where sName Like '{txtUpdateSName.Text}%'"); //d
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChangeFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ensuring that the user has selected someone
            if (lstDelete.SelectedIndex != -1)
            {
                //deleting the textbooks and the auth textbooks and the transactions
                //opening the connection
                conn.Open();

                //getting the student id that has to be deleted
                String[] tempID = lstDelete.SelectedItem.ToString().Split(',');

                //creating sql command
                sql = $"Select Txt_ID from AuthTextbook where Author_ID = {tempID[0]}";

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //creating a lisy of ints to store the TXT_ID values
                List<int> tempTXT = new List<int>();


                //deleting everything related to the author
                while (reader.Read())
                {
                    //getting the value of the TXT_ID
                    tempTXT.Add(reader.GetInt32(0));

                }
                conn.Close();

                //looping through to delete everything related to the author
                for (int i = 0; i < tempTXT.Count; i++)
                {
                    //deleting the trans delail value
                    sqlChanges($"Delete from Trans_Detail where Txt_ID = {tempTXT[i]}"); //d

                    //deleting auth textbok
                    sqlChanges($"Delete from AuthTextbook where Txt_ID = {tempTXT[i]}"); //d

                    //deleting from table textbook
                    sqlChanges($"Delete from Textbook where Txt_ID = {tempTXT[i]}"); //d
                }

                //deleting the author
                sqlChanges($"Delete from Author where Author_ID = {tempID[0]}"); //d
            }

        }
    }
}
