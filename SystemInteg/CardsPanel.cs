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
    public partial class CardsPanel : Form
    {
        private Panel parentPanel;

        public CardsPanel(Panel mainPanel)
        {
            InitializeComponent();
            parentPanel = mainPanel;
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            DashboardPanel dashboardPanel = new DashboardPanel(parentPanel);
            dashboardPanel.TopLevel = false;
            parentPanel.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();
            dashboardPanel.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers(parentPanel);
            teachers.TopLevel = false;
            parentPanel.Controls.Add(teachers);
            teachers.BringToFront();
            teachers.Show();
        }
    }
}
