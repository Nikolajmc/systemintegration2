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
    public partial class DashboardPanel : Form
    {
        private Panel parentPanel;

        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";


        public DashboardPanel(Panel mainPanel)
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
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
                txtId.Text = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            }
        }


        void Search(string text = null)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Search")
            {
                dataGridView1.DataSource = Query("SELECT * FROM Students");
                return;
            }

            string query = @"
        SELECT * FROM Students 
        WHERE CONCAT_WS('|', 
            Id, 
            Student_Name, 
            Student_Password, 
            Student_YearLevel, 
            Student_Section, 
            Student_Number, 
            Student_Teacher, 
            Student_Birthdate, 
            Student_GuardianName, 
            Guardian_Number, 
            Guardian_Address
        ) LIKE @Search";

            dataGridView1.DataSource = Query(query, new SqlParameter("@Search", "%" + text + "%"));
        }

        DataTable Query(string command, params SqlParameter[] parameters)
        {
            DataTable dTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand(command, con))
                {

                    if (parameters != null)
                    {
                        cm.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cm);
                    adapter.Fill(dTable);
                }
            }

            return dTable;
        }

























        private void roundButton4_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }


        private void btnEdit_Dashboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                EditForm editForm = new EditForm(txtId.Text); // Pass selected ID
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a record first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Dashboard_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CardsPanel cardsPanel = new CardsPanel(parentPanel);
            cardsPanel.TopLevel = false;
            parentPanel.Controls.Add(cardsPanel);
            cardsPanel.BringToFront();
            cardsPanel.Show();
        }
    }
}
