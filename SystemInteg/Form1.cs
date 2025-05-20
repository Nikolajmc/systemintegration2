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
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=GeoFenceDB;Integrated Security=True;Encrypt=False;";

        public Form1()
        {
            InitializeComponent();
            chkPassword.CheckedChanged += new EventHandler(chkPassword_CheckedChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "Enter Username";
            SetPasswordPlaceholder();

            this.ActiveControl = txtUsername;
        }



        // =========================================================  USERS LOGIN ========================================================= //

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (txtUsername.Text == "Enter Username" || string.IsNullOrWhiteSpace(username) || txtPassword.Text == "Enter Password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        //MessageBox.Show("Login successful! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // ========================================================= END OF USERS LOGIN ========================================================= //






        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SetPasswordPlaceholder();
            }
        }

        private void SetPasswordPlaceholder()
        {
            txtPassword.Text = "Enter Password";
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }


    }
}
