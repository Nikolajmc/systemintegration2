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
    public partial class DeleteFormTeacher : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public DeleteFormTeacher()
        {
            InitializeComponent();
            DisplayData();
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

                txtId_Teacher.Text = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void btnConfirm_Teacher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId_Teacher.Text))
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Teachers WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId_Teacher.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        txtId_Teacher.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error: Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void Search(string text = null)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Search")
            {
                dataGridView1.DataSource = Query("SELECT * FROM Teachers");
                return;
            }

            string query = @"
        SELECT * FROM Teachers
        WHERE CONCAT_WS('|', 
            Id, 
            Teacher_Name, 
            Classes
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }
    }
}
