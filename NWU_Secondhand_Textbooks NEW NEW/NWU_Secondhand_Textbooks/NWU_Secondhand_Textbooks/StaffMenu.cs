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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintainClients GoToClient = new MaintainClients();
            GoToClient.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintainAuthor GoToAuthor = new MaintainAuthor();
            GoToAuthor.Show();
        }

        private void btnTextbooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintainTextbook GoToTextbooks = new MaintainTextbook();
            GoToTextbooks.Show();
        }

        private void btnConditions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conditions GoToConditions = new Conditions();
            GoToConditions.Show();
        }

        private void btnGetReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestReport GoToReports = new RequestReport();
            GoToReports.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignIn GoToMainMenu = new frmSignIn();
            GoToMainMenu.ShowDialog();
        }
    }
}
