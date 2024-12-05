using SocialMediaForm.components;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SocialMediaForm
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=THEUZUNHASAN;Database=SocialMediaDb;Trusted_Connection=True;User id = sa;Password = baku2024!;";
        public LoginForm()
        {
            InitializeComponent();


            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.MouseEnter += LoginButton_MouseEnter;
            LoginButton.MouseLeave += LoginButton_MouseLeave;


        }

        /*        protected override void OnPaint(PaintEventArgs e)
                {
                    base.OnPaint(e);

                    // Gradyan renklerini belirleyin
                    Color topColor = ColorTranslator.FromHtml("#0c4a6e"); // Üst kısım rengi
                    Color bottomColor = ColorTranslator.FromHtml("#581c87"); // Alt kısım gradyan rengi

                    // Gradyan arka plan oluştur
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        this.ClientRectangle, topColor, bottomColor, LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(brush, this.ClientRectangle);
                    }

                }
        */



        public void LoginButton_MouseEnter(object sender, EventArgs e)
        {

            LoginButton.BackColor = ColorTranslator.FromHtml("#581c87");


        }

        public void LoginButton_MouseLeave(object sender, EventArgs e)
        {

            LoginButton.BackColor = ColorTranslator.FromHtml("#7e21ce");

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Zehmet olmasa username ve parolu doldurun.", "Eksik Melumat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Username FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                UserSession.UserId = Convert.ToInt32(reader["Id"]);
                                UserSession.Username = reader["Username"].ToString();

                                MessageBox.Show("Giriş olundu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                Main main = new Main();
                                main.Show();


                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Parol yada username sehvdi.", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oldu: {ex.Message}", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
