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
using System.Xml.Linq;

namespace SystemInteg
{
    public partial class AddForm : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                    ("INSERT INTO Students" +
                    "(Student_Name," +
                    "Student_Password," +
                    "Student_YearLevel," +
                    "Student_Section," +
                    "Student_Number," +
                    "Student_Teacher," +
                    "Student_Birthdate," +
                    "Student_GuardianName," +
                    "Guardian_Number," +
                    "Guardian_Address)" +

                    "VALUES" +
                    "(@Student_Name," +
                    "@Student_Password," +
                    "@Student_YearLevel," +
                    "@Student_Section," +
                    "@Student_Number," +
                    "@Student_Teacher," +
                    "@Student_Birthdate," +
                    "@Student_GuardianName," +
                    "@Guardian_Number," +
                    "@Guardian_Address)", con);

                try
                {
                    if (txtStudentName.Text == "Enter Student Name" || string.IsNullOrWhiteSpace(txtStudentName.Text))
                    {
                        MessageBox.Show("Student Name cannot be empty. Please enter a name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtYearLevel.Text == "Enter Student Year Level" || string.IsNullOrWhiteSpace(txtYearLevel.Text))
                    {
                        MessageBox.Show("Student Year Level cannot be empty. Please enter a Year Level.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtSection.Text == "Enter Student Section" || string.IsNullOrWhiteSpace(txtSection.Text))
                    {
                        MessageBox.Show("Student Section cannot be empty. Please enter a Section.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtStudentNumber.Text == "Enter Student Number" || string.IsNullOrWhiteSpace(txtStudentNumber.Text))
                    {
                        MessageBox.Show("Student Number cannot be empty. Please enter a Number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtTeacher.Text == "Enter Student Teacher Name" || string.IsNullOrWhiteSpace(txtTeacher.Text))
                    {
                        MessageBox.Show("Student Teacher Name cannot be empty. Please enter a Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtBirthdate.Text == "Enter Student Birthdate" || string.IsNullOrWhiteSpace(txtBirthdate.Text))
                    {
                        MessageBox.Show("Student Birthdate cannot be empty. Please enter a Birthdate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtGuardianName.Text == "Enter Student Guardian Name" || string.IsNullOrWhiteSpace(txtGuardianName.Text))
                    {
                        MessageBox.Show("Student Guardian Name cannot be empty. Please enter a Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtGuardianNumber.Text == "Enter Guardian Number" || string.IsNullOrWhiteSpace(txtGuardianNumber.Text))
                    {
                        MessageBox.Show("Student Guardian Number cannot be empty. Please enter a Number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txtGuardianAddress.Text == "Enter Guardian Permanent Address" || string.IsNullOrWhiteSpace(txtGuardianAddress.Text))
                    {
                        MessageBox.Show("Student Guardian Address cannot be empty. Please enter a Permanent Address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    cmd.Parameters.AddWithValue("@Student_Name", txtStudentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Password", txtStudentNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Yearlevel", txtYearLevel.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Section", txtSection.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Number", txtStudentNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Teacher", txtTeacher.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_Birthdate", txtBirthdate.Text.Trim());
                    cmd.Parameters.AddWithValue("@Student_GuardianName", txtGuardianName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Guardian_Number", txtGuardianNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Guardian_Address", txtGuardianAddress.Text.Trim());
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear(); 
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






        private void clear()
        {
            txtStudentName.Clear();
            txtYearLevel.Clear();
            txtSection.Clear();
            txtStudentNumber.Clear();
            txtTeacher.Clear();
            txtBirthdate.Clear();
            txtGuardianName.Clear();
            txtGuardianNumber.Clear();
            txtGuardianAddress.Clear();


            txtStudentName.Text = "Enter Student Name";
            txtYearLevel.Text = "Enter Student Year Level";
            txtSection.Text = "Enter Student Section";
            txtStudentNumber.Text = "Enter Student Number";
            txtTeacher.Text = "Enter Student Teacher Name";
            txtBirthdate.Text = "Enter Student Birthdate";
            txtGuardianName.Text = "Enter Student Guardian Name";
            txtGuardianNumber.Text = "Enter Guardian Number";
            txtGuardianAddress.Text = "Enter Guardian Permanent Address";
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            txtStudentName.Text = "Enter Student Name";
            txtYearLevel.Text = "Enter Student Year Level";
            txtSection.Text = "Enter Student Section";
            txtStudentNumber.Text = "Enter Student Number";
            txtTeacher.Text = "Enter Student Teacher Name";
            txtBirthdate.Text = "Enter Student Birthdate";
            txtGuardianName.Text = "Enter Student Guardian Name";
            txtGuardianNumber.Text = "Enter Guardian Number";
            txtGuardianAddress.Text = "Enter Guardian Permanent Address";

            this.ActiveControl = txtStudentName;
        }


        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "Enter Student Name")
            {
                txtStudentName.Text = "";
            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                txtStudentName.Text = "Enter Student Name";
            }
        }

        private void txtYearLevel_Enter(object sender, EventArgs e)
        {
            if (txtYearLevel.Text == "Enter Student Year Level")
            {
                txtYearLevel.Text = "";
            }
        }

        private void txtYearLevel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYearLevel.Text))
            {
                txtYearLevel.Text = "Enter Student Year Level";
            }
        }

        private void txtSection_Enter(object sender, EventArgs e)
        {
            if (txtSection.Text == "Enter Student Section")
            {
                txtSection.Text = "";
            }
        }

        private void txtSection_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSection.Text))
            {
                txtSection.Text = "Enter Student Section";
            }
        }

        private void txtStudentNumber_Enter(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Enter Student Number")
            {
                txtStudentNumber.Text = "";
            }
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                txtStudentNumber.Text = "Enter Student Number";
            }
        }

        private void txtTeacher_Enter(object sender, EventArgs e)
        {
            if (txtTeacher.Text == "Enter Student Teacher Name")
            {
                txtTeacher.Text = "";
            }
        }

        private void txtTeacher_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacher.Text))
            {
                txtTeacher.Text = "Enter Student Teacher Name";
            }
        }

        private void txtBirthdate_Enter(object sender, EventArgs e)
        {
            if (txtBirthdate.Text == "Enter Student Birthdate")
            {
                txtBirthdate.Text = "";
            }
        }

        private void txtBirthdate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthdate.Text))
            {
                txtBirthdate.Text = "Enter Student Birthdate";
            }
        }

        private void txtGuardianName_Enter(object sender, EventArgs e)
        {
            if (txtGuardianName.Text == "Enter Student Guardian Name")
            {
                txtGuardianName.Text = "";
            }
        }

        private void txtGuardianName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuardianName.Text))
            {
                txtGuardianName.Text = "Enter Student Guardian Name";
            }
        }

        private void txtGuardianNumber_Enter(object sender, EventArgs e)
        {
            if (txtGuardianNumber.Text == "Enter Guardian Number")
            {
                txtGuardianNumber.Text = "";
            }
        }

        private void txtGuardianNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuardianNumber.Text))
            {
                txtGuardianNumber.Text = "Enter Guardian Number";
            }
        }

        private void txtGuardianAddress_Enter(object sender, EventArgs e)
        {
            if (txtGuardianAddress.Text == "Enter Guardian Permanent Address")
            {
                txtGuardianAddress.Text = "";
            }
        }

        private void txtGuardianAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuardianAddress.Text))
            {
                txtGuardianAddress.Text = "Enter Guardian Permanent Address";
            }
        }
    }
}
