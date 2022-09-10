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
        SqlConnection conn;
        SqlCommand cmd;
        DataSet ds;
        string connectionstring;
        SqlDataAdapter adpt;
        SqlDataReader reader;

        private void lblAvailable_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Error in connecting");
            }
            conn.Close();
            conn.Open();
            adpt = new SqlDataAdapter();
            ds = new DataSet();
            string sql = @"SELECT Title, Edition , Price FROM Textbook ";
            cmd = new SqlCommand(sql, conn);
            adpt.SelectCommand = cmd;
            adpt.Fill(ds, "Textbook");
            dgvAvailable.DataSource = ds;
            dgvAvailable.DataMember = "Textbook";
            conn.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
