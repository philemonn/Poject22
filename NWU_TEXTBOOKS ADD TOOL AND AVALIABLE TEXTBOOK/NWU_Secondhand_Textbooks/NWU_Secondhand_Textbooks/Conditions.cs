using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWU_Secondhand_Textbooks
{
    public partial class Conditions : Form
    {
        public Conditions()
        {
            InitializeComponent();
        }

        private void btnUpdateCOn_Click(object sender, EventArgs e)
        {

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
    }
}
