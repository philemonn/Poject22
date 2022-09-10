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
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring;
        SqlDataAdapter adpt;
        SqlDataReader reader;

        private void MaintainTextbook_Load(object sender, EventArgs e)
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
            string sql = @"SELECT* FROM Textbook ";
            cmd = new SqlCommand(sql, conn);
            adpt.SelectCommand = cmd;
            adpt.Fill(ds, "Textbook");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Textbook";
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "Textbook";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = lblBookName.Text;
            string edition = txtBookEdd.Text;
            int price = Convert.ToInt32(lblBookPrice.Text);


            conn.Open();

            string sql = "INSERT INTO Textbook (Title, Edition, Price) VALUES(@name, @edition, @price)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@edition", edition);
            cmd.Parameters.AddWithValue("@price", price);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Data successfully inserted");


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
