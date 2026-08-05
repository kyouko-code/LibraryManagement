using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @u AND Password = @p";

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                con.Open();

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }
    }
}
