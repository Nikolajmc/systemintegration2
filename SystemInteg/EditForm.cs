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
    public partial class EditForm : Form
    {
        private string studentID;
        //private string connectionString;

        public EditForm(string id)
        {
            InitializeComponent();
            studentID = id;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", studentID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtStudentName.Text = reader["Student_Name"].ToString();
                    txtYearLevel.Text = reader["Student_YearLevel"].ToString();
                    txtSection.Text = reader["Student_Section"].ToString();
                    txtStudentNumber.Text = reader["Student_Number"].ToString();
                    txtTeacher.Text = reader["Student_Teacher"].ToString();
                    txtBirthdate.Text = reader["Student_Birthdate"].ToString();
                    txtGuardianName.Text = reader["Student_GuardianName"].ToString();
                    txtGuardianNumber.Text = reader["Guardian_Number"].ToString();
                    txtGuardianAddress.Text = reader["Guardian_Address"].ToString();
                }

                reader.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

           

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET " +
                    "Student_Name=@Student_Name, " +
                    "Student_Password=@Student_Number, " +
                    "Student_YearLevel=@Student_YearLevel, " +
                    "Student_Section=@Student_Section, " +
                    "Student_Number=@Student_Number, " +
                    "Student_Teacher=@Student_Teacher, " +
                    "Student_Birthdate=@Student_Birthdate, " +
                    "Student_GuardianName=@Student_GuardianName, " +
                    "Guardian_Number=@Guardian_Number, " +
                    "Guardian_Address=@Guardian_Address " +
                    "WHERE Id=@Id", con);

                cmd.Parameters.AddWithValue("@Id", studentID);
                cmd.Parameters.AddWithValue("@Student_Name", txtStudentName.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_Password", txtStudentNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_YearLevel", txtYearLevel.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_Section", txtSection.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_Number", txtStudentNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_Teacher", txtTeacher.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_Birthdate", txtBirthdate.Text.Trim());
                cmd.Parameters.AddWithValue("@Student_GuardianName", txtGuardianName.Text.Trim());
                cmd.Parameters.AddWithValue("@Guardian_Number", txtGuardianNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Guardian_Address", txtGuardianAddress.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
