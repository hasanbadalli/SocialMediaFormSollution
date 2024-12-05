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

namespace SocialMediaForm.components
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=THEUZUNHASAN;Database=SocialMediaDb;Trusted_Connection=True;User id = sa;Password = baku2024!;";

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        public void registerButton_MouseEnter(object sender, EventArgs e)
        {

            registerButton.BackColor = ColorTranslator.FromHtml("#581c87");


        }

        public void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = ColorTranslator.FromHtml("#7e21ce");



        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            string email = emailBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Zehmet olmasa hamsini doldurun!", "Eksik Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Users (Username, Email, Password, CreatedAt)
                VALUES (@Username, @Email, @Password, @CreatedAt)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Qeydiyyat oldunuz!", "Ugurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Qeydiyyat olammadi.", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir xeta oldu: {ex.Message}", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }
    }
}
