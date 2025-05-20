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
            RecordsPanel recordsPanel = new RecordsPanel();
            recordsPanel.TopLevel = false;
            pnlMain.Controls.Add(recordsPanel);
            recordsPanel.BringToFront();
            recordsPanel.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            CardsPanel cardsPanel = new CardsPanel(pnlMain);
            cardsPanel.TopLevel = false;
            pnlMain.Controls.Add(cardsPanel);
            cardsPanel.BringToFront();
            cardsPanel.Show();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            //CreditsPanel creditsPanel = new CreditsPanel();
            //creditsPanel.TopLevel = false;
            //pnlMain.Controls.Add(creditsPanel);
            //creditsPanel.BringToFront();
            //creditsPanel.Show();
            MessageBox.Show("Update Soon.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Soon.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
