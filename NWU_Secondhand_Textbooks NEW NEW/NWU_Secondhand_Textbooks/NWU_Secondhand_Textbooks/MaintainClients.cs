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
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring;
        SqlDataAdapter adpt;
        SqlDataReader reader;
        private void viewAll()
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                //string prase = txtbPhrase.Text;
                conn.Open();

                adpt = new SqlDataAdapter();
                ds = new DataSet();


                string sql = "SELECT * FROM Client";

                cmd = new SqlCommand(sql, conn);
                adpt.SelectCommand = cmd;
                adpt.Fill(ds, "Client");

                dgInsertClients.DataSource = ds;
                dgInsertClients.DataMember = "Client";

                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MaintainClients_Load(object sender, EventArgs e)
        {
            try
            {
                connectionstring = @"Data Source=MAROELINDA;Initial Catalog=TestBooks;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn = new SqlConnection(connectionstring);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error in connecting");
            }
            conn.Close();
            conn.Open();
            adpt = new SqlDataAdapter();
            ds = new DataSet();
            string sql = @"SELECT* FROM Client ";
            cmd = new SqlCommand(sql, conn);
            adpt.SelectCommand = cmd;
            adpt.Fill(ds, "Client");
            dgInsertClients.DataSource = ds;
            dgInsertClients.DataMember = "Client";
            dgDeleteClients.DataSource = ds;
            dgDeleteClients.DataMember = "Client";
            conn.Close();

        
            conn = new SqlConnection(connectionstring);
            conn.Open();
            adpt = new SqlDataAdapter();
            ds = new DataSet();
            cbNumber.Items.Clear();


            
            conn = new SqlConnection(connectionstring);
            conn.Open();
            adpt = new SqlDataAdapter();
            ds = new DataSet();
            cbNumber.Items.Clear();


            conn.Close();

            conn.Open();
            sql = @"SELECT Student_No FROM Client";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (!cbNumber.Items.Contains(reader.GetValue(0)))
                {
                    cbNumber.Items.Add(reader.GetValue(0));
                }

            }
            conn.Close();
            viewAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string studentNum = txtStudentNumber.Text;


            conn.Open();

            string sql = "INSERT INTO Textbook (Client_FName, sName, Student_No) VALUES(@name, @surname, @studentNum)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@studentNum", studentNum);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data successfully inserted");
            viewAll();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                conn.Open();
                adpt = new SqlDataAdapter();


                string sql = "DELETE FROM Client WHERE Student_No LIKE '" + cbNumber.SelectedItem + "'";

                cmd = new SqlCommand(sql, conn);
                adpt.DeleteCommand = cmd;

                adpt.DeleteCommand.ExecuteNonQuery();


                conn.Close();
                viewAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
