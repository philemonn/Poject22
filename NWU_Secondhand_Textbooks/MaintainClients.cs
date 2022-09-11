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
    public partial class MaintainClients : Form
    {
        public MaintainClients()
        {
            InitializeComponent();
        }

        //creating the global variables for the form
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
                string sql = @"SELECT* FROM Client ";   //d

                //excecuting the sql command
                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;

                //filling the table
                adpt.Fill(ds, "Client");

                //filling and assigning the dataset to the data grid views
                dgInsertClients.DataSource = ds;
                dgInsertClients.DataMember = "Client";

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
                String tempList = "ID, FirstName, Surname, StudentNumber";

                //adding the headings to the list box
                lstDelete.Items.Add(tempList);
                lstUpdate.Items.Add(tempList);

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the list boxes
                    tempList = reader.GetInt32(0).ToString() + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3);
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
            fillListBox(@"SELECT * FROM Client"); //d
        }

        private void MaintainClients_Load(object sender, EventArgs e)
        {
            //to create the connection to the database
            try
            {
                //creating the connection
                connectionstring = @"Data Source=.;Initial Catalog=TestBooks;Integrated Security=True"; //d
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception error)
            {
                //letting the user know
                MessageBox.Show("Error with connecting to the database");
            }

            //ensuring that the connection is closed
            conn.Close();
           
            //calling the view all method to fill data grid view
            viewAll();

            //calling a method to fill the list boxes
            fillListBox(@"SELECT * FROM Client"); //d
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting all of the values from the textboxes
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string studentNum = txtStudentNumber.Text;

            //ensuring nothing is empty
            if (!(name.Equals("")) && !(surname.Equals("")))
            {
                //ensuring that the student number is the corrct length
                if (studentNum.Length == 8 && !(studentNum.Equals("")))
                {
                    //calling method to excecute the command
                    sqlChanges($"INSERT INTO Client(Client_FName, sName, Student_No) VALUES('{name}', '{surname}', '{studentNum}')"); //d

                    //letting use know that data added successfully
                    MessageBox.Show("Data successfully inserted");
                }
                else
                {
                    //letting user know
                    MessageBox.Show("Please Enter a valid student number");
                }         
            }else
            {
                //letting user know
                MessageBox.Show("Please Ensure nothing is empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ensuring that the user has selected someone
            if (lstDelete.SelectedIndex != -1)
            {

                //getting the student id that has to be deleted
                String[] tempID = lstDelete.SelectedItem.ToString().Split(',');

                //updating the transdetail table
                sqlChanges($"Update Trans_Detail set Client_ID = NULL where Client_ID = {tempID[0]}");

                sqlChanges($"Delete from Client where Client_ID = {tempID[0]}"); //d

            }
            else
            {
                //letting user know
                MessageBox.Show("Please Select Client To Delete");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //to close this form and go back to the previous form
            this.Dispose();
            StaffMenu staff = new StaffMenu();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //to close the application
            this.Close();
        }

        private void txtDeleteFName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where Client_FName Like '{txtDeleteFName.Text}%'"); //d
        }

        private void txtUpdateFName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where Client_FName Like '{txtUpdateFName.Text}%'"); //d
        }

        private void txtUpdateSName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where sName Like '{txtUpdateSName.Text}%'"); //d
        }

        private void txtDeletSName_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where sName Like '{txtDeletSName.Text}%'"); //d
        }

        private void txtDeleteStudent_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where Student_No Like '{txtDeleteStudent.Text}%'"); //d
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //creating a temporary strings for an update template
            String strUpdate = "Update Client Set ";

            //ensuring that the user has selected someone
            if (lstUpdate.SelectedIndex != -1)
            {
                //ensuring user updates atleast one value
                if ((txtChangeFName.Text.Equals("")) && (txtChangeSurname.Text.Equals("")) && (txtChangeStudent.Text.Equals("")))
                {
                    //letting user know
                    MessageBox.Show("Please Update Atleast One Field");

                }
                else
                {
                    //to update firstname
                    if (!(txtChangeFName.Equals("")))
                    {
                        strUpdate += $"Client_FName = '{txtChangeFName.Text}', ";
                    }

                    //to update surname
                    if (!(txtChangeFName.Equals("")))
                    {
                        strUpdate += $"sName = '{txtChangeSurname.Text}', ";
                    }

                    //to update student number
                    if (!(txtChangeFName.Equals("")))
                    {
                            strUpdate += $"Student_No = '{txtChangeStudent.Text}', ";
                    }

                    //removing the last extra comma
                    int index = strUpdate.LastIndexOf(',');
                    strUpdate = strUpdate.Remove(index);

                    //getting the student id that has to be updated
                    String[] tempID = lstUpdate.SelectedItem.ToString().Split(',');

                    //adding end part of the update statement
                    strUpdate += $" Where Client_ID = {tempID[0]};"; //d (Explain how to)

                    //ensuring a valid student number if entered
                    if (txtChangeStudent.Text.Length == 8 && !(txtChangeFName.Equals("")))
                    {
                        //applying update command
                        sqlChanges(strUpdate);

                        //letting use know that data added successfully
                        MessageBox.Show("Data successfully updated");
                    }
                    else
                        MessageBox.Show("Please use a valid student number and update again to change it");
                }
            }
            else
            {
                //letting user know
                MessageBox.Show("Please Select Client To Update");
            }
        }

        private void txtChangeFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateStudent_TextChanged(object sender, EventArgs e)
        {
            //to update the listboxes
            fillListBox($"SELECT * FROM Client where Student_No Like '{txtUpdateStudent.Text}%'"); //d
        }
    }
}
