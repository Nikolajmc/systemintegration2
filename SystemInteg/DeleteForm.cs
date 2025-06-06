﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SystemInteg
{
    public partial class DeleteForm : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public DeleteForm()
        {
            InitializeComponent();
            DisplayData();
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

                txtId.Text = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                        txtId.Clear();
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
