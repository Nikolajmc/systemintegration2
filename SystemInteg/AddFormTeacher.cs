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
    public partial class AddFormTeacher : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public AddFormTeacher()
        {
            InitializeComponent();
        }

        private void btnConfirm_Teacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO Teachers" +
                    "(Teacher_Name," +
                    "Classes)" +

                    "VALUES" +
                    "(@Teacher_Name," +
                    "@Classes)", con);

                try
                {
                    if (txtTeacherName.Text == "Enter Teacher Name" || string.IsNullOrWhiteSpace(txtTeacherName.Text))
                    {
                        MessageBox.Show("Teacher Name cannot be empty. Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtClassName.Text == "Enter Class Name" || string.IsNullOrWhiteSpace(txtClassName.Text))
                    {
                        MessageBox.Show("Class Name cannot be empty. Please enter a class name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@Teacher_Name", txtTeacherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Classes", txtClassName.Text.Trim());
                }

                catch (FormatException)
                {
                    MessageBox.Show("Invalid format detected. Please enter the correct data format.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The value entered is too large. Please enter a valid number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
        }

        private void btnClear_Teacher_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtTeacherName.Clear();
            txtClassName.Clear();

            txtTeacherName.Text = "Enter Teacher Name";
            txtClassName.Text = "Enter Class Name";
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

        private void AddFormTeacher_Load(object sender, EventArgs e)
        {
            txtTeacherName.Text = "Enter Teacher Name";
            txtClassName.Text = "Enter Class Name";

            this.ActiveControl = txtTeacherName;
        }

        private void txtTeacherName_Enter(object sender, EventArgs e)
        {
            if (txtTeacherName.Text == "Enter Teacher Name")
            {
                txtTeacherName.Text = "";
            }
        }

        private void txtTeacherName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text))
            {
                txtTeacherName.Text = "Enter Teacher Name";
            }
        }

        private void txtClassName_Enter(object sender, EventArgs e)
        {
            if (txtClassName.Text == "Enter Class Name")
            {
                txtClassName.Text = "";
            }
        }

        private void txtClassName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                txtClassName.Text = "Enter Class Name";
            }
        }
    }
}
