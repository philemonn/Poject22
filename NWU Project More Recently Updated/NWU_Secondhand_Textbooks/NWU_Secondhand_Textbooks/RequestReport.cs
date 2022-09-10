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
    public partial class RequestReport : Form
    {
        public RequestReport()
        {
            InitializeComponent();
        }

        //creating the global variables for the form
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring, sql, modCode;
        SqlDataAdapter adpt;
        SqlDataReader reader;

        private void fillListBox(String parmSQL)
        {
            try
            {
                //first clearing the list boxes
                lstOutput.Items.Clear();

                //opening the connection
                conn.Open();

                //creating an sql command to fill the student number combo boxes
                sql = parmSQL;

                //applying the sql command and adding it the the reader
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                //opening the reader

                if (rbProfit.Checked)
                {
                    //creating a value to store the profit and losses
                    decimal profitLose = 0;
                    //reading and adding the data to the list boxes the combo boxes
                    while (reader.Read())
                    {
                        //creating a boolean to see if it was a profit or a loss
                        bool type = reader.GetBoolean(0);

                        //adding profis or losses
                        if (type)
                        {
                            profitLose += reader.GetDecimal(1);
                        }
                        else
                        {
                            profitLose -= reader.GetDecimal(1);
                        }
                        
                    }
                    
                    //checking if it was a profit or a loss
                    if (profitLose < 0)
                    {
                        //adding this info to the listbox
                        lstOutput.Items.Add("There is a loss of R" + profitLose);
                    }
                    else if (profitLose > 0)
                    {
                        //adding this info to the listbox
                        lstOutput.Items.Add("There is a profit of R" + profitLose);
                    }
                    else
                    {
                        //adding this info to the listbox
                        lstOutput.Items.Add("We broke even with R" + profitLose);
                    }
                }

                if (rbAllPurchases.Checked)
                {
                    //adding the headings to the listbox
                    lstOutput.Items.Add("Trans_ID, Txt_Title, Client_Name, Price_Paid");

                    //reading and adding the data to the list boxes the combo boxes
                    while (reader.Read())
                    {
                        while (reader.Read())
                        {
                            //creating a boolean to see if it was a profit or a loss
                            bool type = reader.GetBoolean(5);

                            //adding profis or losses
                            if (!(type))
                            {
                                lstOutput.Items.Add(reader.GetInt32(0).ToString() + ", " + reader.GetString(1) + ", " + reader.GetString(2) + " " + reader.GetString(3) + ", " + reader.GetDecimal(4));
                            }
                        }
                    }
                }

                if (rbAllSales.Checked)
                {
                    //adding the headings to the listbox
                    lstOutput.Items.Add("Trans_ID, Txt_Title, Client_Name, Price_Paid");

                    //reading and adding the data to the list boxes the combo boxes
                    while (reader.Read())
                    {    
                        //reading and adding the data to the list boxes the combo boxes
                        while (reader.Read())
                        {
                            while (reader.Read())
                            {
                                //creating a boolean to see if it was a profit or a loss
                                bool type = reader.GetBoolean(5);

                                //adding profis or losses
                                if ((type))
                                {
                                    lstOutput.Items.Add(reader.GetInt32(0).ToString() + ", " + reader.GetString(1) + ", " + reader.GetString(2) + " " + reader.GetString(3) + ", " + reader.GetDecimal(4));
                                }
                            }
                        }
                    }
                }

                if(rbInventory.Checked)
                {
                    //creating a value to store the te amount of valid textbooks
                    int count = 0;
                    //reading and adding the data to the list boxes the combo boxes
                    while (reader.Read())
                    {
                        //increasing the count for every textbook
                        count++;
                        if (reader.GetValue(1).Equals(false))
                        {
                            //decreasing the count for every textbook that has been sold
                            count--;
                        }
                    }
                    if (modCode.Equals(""))
                    {
                        lstOutput.Items.Add("There are " + count + " Book(s) in All the modules");
                    }
                    else
                    {
                        lstOutput.Items.Add("There are " + count + " Book(s) in " + modCode);
                    }
                }

                //closing the reader
                reader.Close();

                //closing the connection
                conn.Close();
            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error updating the List boxes the data from the database. Code:" + error.Message);
            }
        }

        private void rbAllPurchases_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllPurchases.Checked)
            {
                //making everything visible
                lblDateBetween.Visible = true;
                lblAnd.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                lblModule.Visible = true;
                comboBox1.Visible = true;

                //checking if a date has been picked
                if (dateTimePicker1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_ID, Textbook.Title, Client.Client_FName, Client.sName, Trans_Detail.PricePaid, Trans_Detail.Trans_Type From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Client On Trans_Detail.Client_ID = Client.Client_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_ID, Textbook.Title, Client.Client_FName, Client.sName, Trans_Detail.PricePaid, Trans_Detail.Trans_Type From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Client On Trans_Detail.Client_ID = Client.Client_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                }
                fillListBox(sql);
            }
        }

        //to update the chart
        private void updatechart(String parmSQL, String heading, String series, String xval, String yval)
        {
            try
            {
                //clearing the chart
                crtReport.Series.Clear();

                //clearing the title
                crtReport.Titles.Clear();

                //opening the connection
                conn.Open();

                //creating the sql adapter
                adpt = new SqlDataAdapter();
                ds = new DataSet();

                //creating the sql command
                string sql = parmSQL; //

                //excecuting the sql command
                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;

                //filling the table
                adpt.Fill(ds, "Trans_Detail");

                //adding data source to hart
                crtReport.DataSource = ds;

                //adding the series
                crtReport.Series.Add(series);

                //adding a series x value
                crtReport.Series[series].XValueMember = xval;

                //adding a series y value  
                crtReport.Series[series].YValueMembers = yval;

                //adding titles to the axii
                crtReport.ChartAreas[0].AxisX.Title = xval;
                crtReport.ChartAreas[0].AxisY.Title = yval;

                /*//only adjust the size when there are also negative values for the 
                if (rbProfitGraph.Checked)
                {
                    //getting the min and max values from the data
                    cmd = new SqlCommand($"Select Max(Total) From ({sql})", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    int max = reader.GetInt32(0);
                    reader.Close();

                    cmd = new SqlCommand($"Select Min(Total) From ({sql})", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    int min = reader.GetInt32(0);
                    reader.Close();

                    //setting the minimum and maximum values
                    crtReport.ChartAreas[0].AxisY.Minimum = min;
                    crtReport.ChartAreas[0].AxisY.Maximum = max;
                }*/

                //adding a heading
                crtReport.Titles.Add(heading);

                //filling the table
                adpt.Fill(ds);

                //closing the connection
                conn.Close();

            }
            catch (SqlException error)
            {
                //error message for the user
                MessageBox.Show("Error with the displaying the data from the database into chart. Code:" + error.Message);
            }
        }

        private void RequestReport_Load(object sender, EventArgs e)
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

            //filling the combobox
            //first clearing the Comboboxes
            comboBox1.Items.Clear();

            //opening the connection
            conn.Open();

            //author comboboxes
            //creating the sql statement
            sql = $"Select Distinct ModuleCode from Module"; //d

            //applying the sql command and adding it the the reader
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            //adding a blank feild
            comboBox1.Items.Add("All");

            //reading and adding the data to the list boxes the combo boxes
            while (reader.Read())
            {
                //adding the data to the Comboboxes
                comboBox1.Items.Add(reader.GetString(0));
            }

            //cosing the reader
            reader.Close();

            //closing the connection
            conn.Close();
        }
    


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            StaffMenu staff = new StaffMenu();
            staff.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdProfit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProfit.Checked)
            {
                //making everything visible
                lblDateBetween.Visible = true;
                lblAnd.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                lblModule.Visible = true;
                comboBox1.Visible = true;

                //checking if a date has been picked
                if (dateTimePicker1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_Type, Trans_Detail.PricePaid From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_Type, Trans_Detail.PricePaid From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                }
                fillListBox(sql);

            }
        }

        private void rbAllSales_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllSales.Checked)
            {
                //making everything visible
                lblDateBetween.Visible = true;
                lblAnd.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                lblModule.Visible = true;
                comboBox1.Visible = true;

                //making everything visible
                lblDateBetween.Visible = true;
                lblAnd.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                lblModule.Visible = true;
                comboBox1.Visible = true;

                //checking if a date has been picked
                if (dateTimePicker1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_ID, Textbook.Title, Client.Client_FName, Client.sName, Trans_Detail.PricePaid, Trans_Detail.Trans_Type From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Client On Trans_Detail.Client_ID = Client.Client_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select Trans_Detail.Trans_ID, Textbook.Title, Client.Client_FName, Client.sName, Trans_Detail.PricePaid, Trans_Detail.Trans_Type From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Client On Trans_Detail.Client_ID = Client.Client_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                                    $" Where Module.ModuleCode Like '%{modCode}%'";
                }
                fillListBox(sql);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //making group box visible
            gpbReport.Visible = true;

            //unchecking the radiobuttons
            rbAllPurchases.Checked = false;
            rbAllSales.Checked = false;
            rbProfit.Checked = false;
            rbInventory.Checked = false;

            if (comboBox1.SelectedIndex == -1)
            {
                modCode = "All";
            }
            else
            {
                modCode = comboBox1.SelectedItem.ToString();
            }

            //getting all of the values if choses
            if (modCode.Equals("All"))
            {
                modCode = "";
            }
        }

        private void gpbReport_Enter(object sender, EventArgs e)
        {

        }

        private void rbProfitGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProfitGraph.Checked)
            {
                //making all the required things visible
                label1.Visible = true;
                label2.Visible = true;
                dtpGraph1.Visible = true;
                dtpGraph2.Visible = true;

                //checking if a date has been picked
                if (dtpGraph1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select (SUM(CASE WHEN Trans_Detail.Trans_Type = 1 THEN Trans_Detail.PricePaid END) - SUM(CASE WHEN Trans_Detail.Trans_Type = 0 THEN Trans_Detail.PricePaid END))  As Total, Module.ModuleCode as ModuleCode from Trans_Detail
                            Left Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                            Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                            Group by Module.ModuleCode";
                    updatechart(sql, "Total Profit Between And", "Profit", "ModuleCode", "Total");
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select (SUM(CASE WHEN Trans_Detail.Trans_Type = 1 THEN Trans_Detail.PricePaid END) - SUM(CASE WHEN Trans_Detail.Trans_Type = 0 THEN Trans_Detail.PricePaid END))  As Total, Module.ModuleCode as ModuleCode from Trans_Detail
                            Left Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                            Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                            Group by Module.ModuleCode";
                    updatechart(sql, "Total Profit", "Profit", "ModuleCode", "Total");
                }
            }
        }

        private void rbSalesGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalesGraph.Checked)
            {
                //making all the required things visible
                label1.Visible = true;
                label2.Visible = true;
                dtpGraph1.Visible = true;
                dtpGraph2.Visible = true;

                //checking if a date has been picked
                if (dtpGraph1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select Count(Trans_Detail.Trans_Type) As Total, Module.ModuleCode AS ModuleCode From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                                where Trans_Detail.Trans_Type = 0
                                Group by Module.ModuleCode";
                    updatechart(sql, "Total Sales Between and ", "Sales", "ModuleCode", "Total");
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select Count(Trans_Detail.Trans_Type) As Total, Module.ModuleCode AS ModuleCode From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                                where Trans_Detail.Trans_Type = 0
                                Group by Module.ModuleCode";
                    updatechart(sql, "Total Sales", "Sales", "ModuleCode", "Total");
                }
            }
        }

        private void rbPurchaseGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPurchaseGraph.Checked)
            {
                //making all the required things visible
                label1.Visible = true;
                label2.Visible = true;
                dtpGraph1.Visible = true;
                dtpGraph2.Visible = true;

                //checking if a date has been picked
                if (dtpGraph1.Value.Equals(DateTime.Today))
                {
                    //creating the sql command
                    sql = @"Select Count(Trans_Detail.Trans_Type) As Total, Module.ModuleCode AS ModuleCode From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                                where Trans_Detail.Trans_Type = 1
                                Group by Module.ModuleCode";
                    updatechart(sql, "Total Purchases Between and ", "Purchases", "ModuleCode", "Total");
                    //$"AND Where TransDetail.date between and";
                }
                else
                {
                    //creating the sql command
                    sql = @"Select Count(Trans_Detail.Trans_Type) As Total, Module.ModuleCode AS ModuleCode From Trans_Detail 
                                Join Textbook on Trans_Detail.Txt_ID = Textbook.Txt_ID
                                Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                                where Trans_Detail.Trans_Type = 1
                                Group by Module.ModuleCode";
                    updatechart(sql, "Total Purchases", "Purchases", "ModuleCode", "Total");
                }
            }
        }

        private void rbInventoryGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInventoryGraph.Checked)
            {
                //making all the required things invisible
                label1.Visible = false;
                label2.Visible = false;
                dtpGraph1.Visible = false;
                dtpGraph2.Visible = false;

                if (rbInventoryGraph.Checked)
                {
                    //making everything visible


                    //creating the sql command
                    sql = @"Select (Count( DISTINCT TextBook.Txt_ID))  As Total, Module.ModuleCode as ModuleCode from Textbook
                            Left Join Trans_Detail on Trans_Detail.Txt_ID = Textbook.Txt_ID
                            Join Module ON Textbook.Module_CodeID = Module.Module_CodeID
                            where (Trans_Detail.Trans_Type = 0 OR Trans_Detail.Trans_Type Is Null) AND TextBook.Txt_ID IS NOT null
                            Group by Module.ModuleCode";
                    updatechart(sql, "Total Inventory", "Inventory", "ModuleCode", "Total"); 
                }
            }
        } //-Not Trans_Detail.Trans_Type = 1 AND Trans_Detail.Trans_Type IS Null     //Left Join Trans_Detail on Trans_Detail.Txt_ID = Textbook.Txt_ID




        private void lblModule_Click(object sender, EventArgs e)
        {

        }

        private void rbInventory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInventory.Checked)
            {
                //making everything visible
                lblDateBetween.Visible = false;
                lblAnd.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                lblModule.Visible = true;
                comboBox1.Visible = true;

                //checking if a date has been picked


                //creating the sql command
                sql = @"Select DISTINCT Textbook.Txt_ID, Trans_Detail.Trans_Type From Textbook
                    Left Join Trans_Detail on Trans_Detail.Txt_ID = Textbook.Txt_ID
                    Join Module ON Textbook.Module_CodeID = Module.Module_CodeID" +
                        $" Where Module.ModuleCode Like '%{modCode}%' ";
                fillListBox(sql);
            }
        }
    }
}
