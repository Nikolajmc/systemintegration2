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
    public partial class RecordsPanel : Form
    {
        private string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public RecordsPanel()
        {
            InitializeComponent();
            LoadCounts();
        }

        private void LoadCounts()
        {
            lblStudents.Text = "" + GetCount("Students");
            lblTeachers.Text = "" + GetCount("Teachers");
        }

        private int GetCount(string tableName)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(*) FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }
    }
}
