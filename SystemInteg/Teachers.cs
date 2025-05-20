using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInteg
{
    public partial class Teachers : Form
    {
        private Panel parentPanel;

        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public Teachers(Panel mainPanel)
        {
            InitializeComponent();
            DisplayData();
            parentPanel = mainPanel;
        }

        public void DisplayData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Teachers", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Store selected ID in txtId
                txtId_Teacher.Text = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnBack_Teacher_Click(object sender, EventArgs e)
        {
            CardsPanel cardsPanel = new CardsPanel(parentPanel);
            cardsPanel.TopLevel = false;
            parentPanel.Controls.Add(cardsPanel);
            cardsPanel.BringToFront();
            cardsPanel.Show();
        }

        private void btnAdd_Teacher_Click(object sender, EventArgs e)
        {
            AddFormTeacher addFormTeacher = new AddFormTeacher();
            addFormTeacher.ShowDialog();
        }

        private void btnEdit_Teacher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId_Teacher.Text))
            {
                EditFormTeacher editFormTeacher = new EditFormTeacher(txtId_Teacher.Text); // Pass selected ID
                editFormTeacher.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a record first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Teacher_Click(object sender, EventArgs e)
        {
            DeleteFormTeacher deleteFormTeacher = new DeleteFormTeacher();
            deleteFormTeacher.ShowDialog();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }
    }
}
