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
    public partial class EditFormTeacher : Form
    {
        private string teacherID;
        //private string connectionString;

        public EditFormTeacher(string id)
        {
            InitializeComponent();
            teacherID = id;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Teachers WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", teacherID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTeacherName.Text = reader["Teacher_Name"].ToString();
                    txtClassName.Text = reader["Classes"].ToString();
                }

                reader.Close();
            }
        }

        private void btnConfirm_Teacher_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Teachers SET " +
                    "Teacher_Name=@Teacher_Name, " +
                    "Classes=@Classes " +
                    "WHERE Id=@Id", con);

                cmd.Parameters.AddWithValue("@Id", teacherID);
                cmd.Parameters.AddWithValue("@Teacher_Name", txtTeacherName.Text.Trim());
                cmd.Parameters.AddWithValue("@Classes", txtClassName.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
