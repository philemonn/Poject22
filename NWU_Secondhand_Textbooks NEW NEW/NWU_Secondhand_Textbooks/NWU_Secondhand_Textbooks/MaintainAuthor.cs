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
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring;
        SqlDataAdapter adpt;
        SqlDataReader reader;

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Auth_name = txtName.Text;
            string Auth_Sname = txtSurname.Text;
            string Textbook = txtTextbook.Text;


            conn.Open();

            string sql = "INSERT INTO Author (Auth_fName,sName) VALUES(@name, @Sname)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", Auth_name);
            cmd.Parameters.AddWithValue("@Sname", Auth_Sname);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data successfully inserted");


        }

        private void MaintainAuthor_Load(object sender, EventArgs e)
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
            string sql = @"SELECT* FROM Author ";
            cmd = new SqlCommand(sql, conn);
            adpt.SelectCommand = cmd;
            adpt.Fill(ds, "Author");
            dgInsertAuthor.DataSource = ds;
            dgInsertAuthor.DataMember = "Author";
            dgDeleteAuthor.DataSource = ds;
            dgDeleteAuthor.DataMember = "Author";
            
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connectionstring);
                conn.Open();
                adpt = new SqlDataAdapter();


                string sql = "DELETE FROM Author WHERE Author_ID LIKE '" + cbID.SelectedItem + "'";

                cmd = new SqlCommand(sql, conn);
                adpt.DeleteCommand = cmd;

                adpt.DeleteCommand.ExecuteNonQuery();


                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }


        }
    }
}
