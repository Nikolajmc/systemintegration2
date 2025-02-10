using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInteg
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            DashboardPanel dashboardPanel = new DashboardPanel();
            dashboardPanel.TopLevel = false;
            pnlMain.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();
            dashboardPanel.Show();
        }
    }
}
