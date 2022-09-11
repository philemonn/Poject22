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
    public partial class MaintainTextbook : Form
    {
        public MaintainTextbook()
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
                string sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                                Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                                Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                                Join Condition On Textbook.Con_ID = Condition.Con_Id
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID"; //d

                //excecuting the sql command
                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;

                //filling the table
                adpt.Fill(ds, "TextBook");

                //filling and assigning the dataset to the data grid views
                dgvTextbooks.DataSource = ds;
                dgvTextbooks.DataMember = "TextBook";

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
                String tempList = "ID, Title, Edition, Quality, ModuleCode, Price, Auth_Fname, Auth_Sname";

                //adding the headings to the list box
                lstDelete.Items.Add(tempList);
                lstUpdate.Items.Add(tempList);

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the list boxes
                    tempList = reader.GetInt32(0).ToString() + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3) + ", " + reader.GetString(4) + ", " + reader.GetDecimal(5) + ", " + reader.GetString(6) + ", " + reader.GetString(7);
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
            fillComboBoxAuthor("");
            fillComboBoxEdition("");
            fillComboBoxModule("");
            fillComboBoxQuality("");
            sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                                Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                                Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                                Join Condition On Textbook.Con_ID = Condition.Con_Id
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID";

            fillListBox(sql);
        }

        //The next few methods are to fill the comboboxes
        private void fillComboBoxAuthor(String text)
        {
            try
            {
                //first clearing the Comboboxes
                cbDeleteAuthor.Items.Clear();
                cbUpdateAuthor.Items.Clear();
                cbAuthor.Items.Clear();

                //opening the connection
                conn.Open();

                //author comboboxes
                //creating the sql statement
                sql = $"Select Distinct Auth_Fname, sName from Author where Auth_FName Like '%{text}%' OR sName Like '%{text}%'"; //d

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //adding a blank feild
                cbDeleteAuthor.Items.Add("");
                cbUpdateAuthor.Items.Add("");

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the Comboboxes
                    cbDeleteAuthor.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                    cbUpdateAuthor.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                    cbAuthor.Items.Add(reader.GetString(0));
                }

                //cosing the reader
                reader.Close();

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the Author Combo boxes the data from the database. Code:" + error.Message);
            }
        }
        private void fillComboBoxModule(String text)
        {
            try
            {
                //first clearing the Comboboxes
                cbDeleteModule.Items.Clear();
                cbUpdateModule.Items.Clear();
                cbModCode.Items.Clear();

                //opening the connection
                conn.Open();

                //author comboboxes
                //creating the sql statement
                sql = $"Select Distinct ModuleCode from Module where ModuleCode Like '%{text}%'"; //d

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //adding a blank feild
                cbDeleteModule.Items.Add("");
                cbUpdateModule.Items.Add("");

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the Comboboxes
                    cbDeleteModule.Items.Add(reader.GetString(0));
                    cbUpdateModule.Items.Add(reader.GetString(0));
                    cbModCode.Items.Add(reader.GetString(0));

                }

                //cosing the reader
                reader.Close();

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the Module Combo boxes the data from the database. Code:" + error.Message);
            }
        }
        private void fillComboBoxEdition(String text)
        {
            try
            {
                //first clearing the Comboboxes
                cbDeleteEdition.Items.Clear();
                cbUpdateEdition.Items.Clear();
                cbEddition.Items.Clear();

                //opening the connection
                conn.Open();

                //author comboboxes
                //creating the sql statement
                sql = $"Select Distinct Edition from Textbook where Edition Like '%{text}%'"; //d

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //adding a blank feild
                cbDeleteEdition.Items.Add("");
                cbUpdateEdition.Items.Add("");

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the Comboboxes
                    cbDeleteEdition.Items.Add(reader.GetString(0));
                    cbUpdateEdition.Items.Add(reader.GetString(0));
                    cbEddition.Items.Add(reader.GetString(0));
                }

                //cosing the reader
                reader.Close();

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the Edition Combo boxes the data from the database. Code:" + error.Message);
            }
        }
        private void fillComboBoxQuality(String text)
        {
            try
            {
                //first clearing the Comboboxes
                cbDeleteQuality.Items.Clear();
                cbUpdateQuality.Items.Clear();
                cbQuality.Items.Clear();

                //opening the connection
                conn.Open();

                //author comboboxes
                //creating the sql statement
                sql = $"Select Distinct Quality from Condition where Quality Like '%{text}%'"; //d

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //adding a blank feild
                cbDeleteQuality.Items.Add("");
                cbUpdateQuality.Items.Add("");

                //reading and adding the data to the list boxes the combo boxes
                while (reader.Read())
                {
                    //adding the data to the Comboboxes
                    cbDeleteQuality.Items.Add(reader.GetString(0));
                    cbUpdateQuality.Items.Add(reader.GetString(0));
                    cbQuality.Items.Add(reader.GetString(0));
                }

                //cosing the reader
                reader.Close();

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the Quality Combo boxes the data from the database. Code:" + error.Message);
            }
        }


        private void MaintainTextbook_Load(object sender, EventArgs e)
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

            sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                                Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                                Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                                Join Condition On Textbook.Con_ID = Condition.Con_Id
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID";

            //calling a method to fill the list boxes
            fillListBox(sql); //d
            fillComboBoxAuthor("");
            fillComboBoxEdition("");
            fillComboBoxModule("");
            fillComboBoxQuality("");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //ensuring non of the comboboxes are empty
            if ((cbQuality.SelectedIndex != -1) && (cbModCode.SelectedIndex != -1) && (cbAuthor.SelectedIndex != -1))
            {
                //getting all of the values from the textboxes
                string name = txtBookName.Text;
                string edition = cbEddition.SelectedItem.ToString();
                decimal price = nudInsert.Value;
                String quality = cbQuality.SelectedItem.ToString(); 
                String modCode = cbModCode.SelectedItem.ToString(); 
                String authFName = cbAuthor.SelectedItem.ToString(); 

                //ensuring nothing is empty
                if (!(name.Equals("")) && (price != (decimal) 0))
                {
                    //calling method to excecute the command
                    sql = @"INSERT INTO Textbook(Title, Edition, Price, Con_ID, Module_CodeID) " +
                            $"Values ('{name}', '{edition}', {price.ToString()}, (Select Con_ID from Condition where Quality = '{quality}'), (Select Module_CodeID from Module where ModuleCode = '{modCode}'))"; //d
                    sqlChanges(sql); //d

                    //adding the link to the author
                    sql = @"Insert Into AuthTextbook(Author_ID, Txt_ID) " +
                        $"Values ((Select Author_ID From Author where Auth_FName = '{authFName}'), (Select Txt_ID from TextBook where Title = '{name}' And Edition = '{edition}' And Price = {price.ToString()}))"; //d maybe update it more also, the atual statement\
                    sqlChanges(sql);

                    //letting use know that data added successfully
                    MessageBox.Show("Data successfully inserted");

                }
                else
                {
                    //letting user know
                    MessageBox.Show("Please Ensure nothing is empty");
                }
            }
            else
            {
                //letting user know
                MessageBox.Show("Please Ensure combo boxes arent is empty");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //closing this form
            this.Dispose();

            //opening the previous form
            StaffMenu staff = new StaffMenu();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closing this form
            this.Close();
        }

        private void txtDeleteName_TextChanged(object sender, EventArgs e)
        {
            //creaing the sqlcommand
            sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                    $"Where Textbook.Title Like '%{txtDeleteName.Text}%' ";

            //calling the command
            fillListBox(sql);
        }

        private void nudDelete_ValueChanged(object sender, EventArgs e)
        {
            //creaing the sqlcommand
            sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                    $"Where Textbook.Price = {nudDelete.Value.ToString()} ";

            //calling the command
            fillListBox(sql);
        }

        private void cbDeleteEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking if the value is null
            if (cbDeleteEdition.SelectedIndex != -1)
            {
                //ensuring thatit isnt blank
                if (cbDeleteEdition.SelectedItem.ToString().Equals(""))
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID ";

                    //calling the command
                    fillListBox(sql);
                }
                else
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                            $"Where Textbook.Edition = '{cbDeleteEdition.SelectedItem.ToString()}' ";

                    //calling the command
                    fillListBox(sql);
                }
            }
        }

        private void cbDeleteQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking if the value is null
            if (cbDeleteQuality.SelectedIndex != -1)
            {
                //ensuring thatit isnt blank
                if (cbDeleteQuality.SelectedItem.ToString().Equals(""))
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID ";

                    //calling the command
                    fillListBox(sql);
                }
                else
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                            $"Where Condition.Quality = '{cbDeleteQuality.SelectedItem.ToString()}' ";

                    //calling the command
                    fillListBox(sql);
                }
            }
        }

        private void cbDeleteModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking if the value is null
            if (cbDeleteModule.SelectedIndex != -1)
            {
                //ensuring thatit isnt blank
                if (cbDeleteModule.SelectedItem.ToString().Equals(""))
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID ";

                    //calling the command
                    fillListBox(sql);
                }
                else
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                            $"Where Module.ModuleCode = '{cbDeleteModule.SelectedItem.ToString()}' ";

                    //calling the command
                    fillListBox(sql);
                }
            }
        }

        private void cbDeleteAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking if the value is null
            if (cbDeleteAuthor.SelectedIndex != -1)
            {
                //ensuring thatit isnt blank
                if (cbDeleteAuthor.SelectedItem.ToString().Equals(""))
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID ";

                    //calling the command
                    fillListBox(sql);
                }
                else
                {
                    //creaing the sqlcommand
                    sql = @"Select Textbook.Txt_ID, Textbook.Title, Textbook.Edition, Condition.Quality, Module.ModuleCode, Textbook.Price, Author.Auth_FName, Author.sName From TextBook 
                    Join AuthTextbook on Textbook.Txt_ID = AuthTextBook.Txt_ID
                    Join Author ON AuthTextbook.Author_ID = Author.Author_ID
                    Join Condition On Textbook.Con_ID = Condition.Con_Id
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID " +
                            $"Where CHARINDEX(Author.Auth_FName, '{cbDeleteAuthor.SelectedItem.ToString()}') > 0";

                    //calling the command
                    fillListBox(sql);
                }
            }
        }

        private void tbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //calling a method to fill the list boxes
            fillComboBoxAuthor("");
            fillComboBoxEdition("");
            fillComboBoxModule("");
            fillComboBoxQuality("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //creating a temporary strings for an update template
            String strUpdate = "Update TextBook Set ";

            //ensuring that the user has selected someone
            if (lstUpdate.SelectedIndex != -1)
            {
                //ensuring user updates atleast one value
                if ((txtUpdateName.Text.Equals("")) && (cbUpdateAuthor.SelectedIndex == -1) && (cbUpdateQuality.SelectedIndex == -1) && (cbUpdateEdition.SelectedIndex == -1) && (cbUpdateModule.SelectedIndex == -1) && (nudUpdate.Value == 0))
                {
                    //letting user know
                    MessageBox.Show("Please Update Atleast One Field");

                }
                else
                {
                    //getting the student id that has to be updated
                    String[] tempID = lstUpdate.SelectedItem.ToString().Split(',');

                    //to update title
                    if (!(txtUpdateName.Text.Equals("")))
                    {
                        strUpdate += $"Title = '{txtUpdateName.Text}', ";
                    }

                    //to update author
                    if (!(cbUpdateAuthor.SelectedIndex == -1))
                    {
                        //creating a temp string for author
                        String[] tempAuth = cbUpdateAuthor.SelectedItem.ToString().Split(' ');

                        sql = $"Update AuthTextbook Set Author_ID = (Select Author_ID From Author where Auth_FName = '{tempAuth[0]}') Where txt_ID = {tempID[0]}";
                        sqlChanges(sql);
                    }

                    //to update student number
                    if (!(cbUpdateQuality.SelectedIndex == -1))
                    {
                        strUpdate += $"Con_ID = (Select Con_ID from Condition where Quality = '{cbUpdateQuality.SelectedItem.ToString()}'), ";
                    }

                    //to update student number
                    if (!(cbUpdateEdition.SelectedIndex == -1))
                    {
                        strUpdate += $"Edition = '{cbUpdateEdition.SelectedItem.ToString()}, ";
                    }

                    //to update student number
                    if (!(cbUpdateModule.SelectedIndex == -1))
                    {
                        strUpdate += $"Module_CodeID = (Select Module_CodeID from Module where ModuleCode = '{cbUpdateModule.SelectedItem.ToString()}'), ";
                    }

                    //to update student number
                    if (!(nudUpdate.Value == 0))
                    {
                        strUpdate += $"price = {nudUpdate.Value}, ";
                    }

                    //removing the last extra comma
                    int index = strUpdate.LastIndexOf(',');
                    strUpdate = strUpdate.Remove(index);

                    //adding end part of the update statement
                    strUpdate += $" Where Txt_ID = {tempID[0]};"; //d (Explain how to)


                    //applying update command
                    sqlChanges(strUpdate);

                    //letting use know that data added successfully
                    MessageBox.Show("Data successfully updated");

                }
            }
            else
            {
                //letting user know
                MessageBox.Show("Please Select TextBook To Update");
            }
        }

        private void cbUpdateQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbModCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUpdateAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            //ensuring that the user has selected someone
            if (lstDelete.SelectedIndex != -1)
            {

                //getting the student id that has to be deleted
                String[] tempID = lstDelete.SelectedItem.ToString().Split(',');

                //deleting the trans delail value
                sqlChanges($"Delete from Trans_Detail where Txt_ID = {tempID[0]}"); //d

                //deleting auth textbok
                sqlChanges($"Delete from AuthTextbook where Txt_ID = {tempID[0]}"); //d

                //deleting from table textbook
                sqlChanges($"Delete from Textbook where Txt_ID = {tempID[0]}"); //d

            }
            else
            {
                //letting user know
                MessageBox.Show("Please Select Textbook To Delete");
            }
        }
    }
}
