namespace SocialMediaForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LoginButton = new Button();
            usernameBox = new TextBox();
            pictureBox1 = new PictureBox();
            loginLabel = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            passwordBox = new TextBox();
            registerLabel = new Label();
            exitIcon = new FontAwesome.Sharp.IconPictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(126, 33, 206);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(177, 653);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(163, 67);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Log in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.White;
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(114, 322);
            usernameBox.Multiline = true;
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "username";
            usernameBox.Size = new Size(303, 37);
            usernameBox.TabIndex = 1;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(114, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.White;
            loginLabel.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(126, 33, 206);
            loginLabel.Location = new Point(152, 232);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(200, 48);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "LOG IN";
            loginLabel.Click += loginLabel_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(126, 33, 206);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(126, 33, 206);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(60, 310);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(60, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(60, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 1);
            panel2.TabIndex = 8;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(126, 33, 206);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(126, 33, 206);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 48;
            iconPictureBox2.Location = new Point(60, 415);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(48, 48);
            iconPictureBox2.TabIndex = 7;
            iconPictureBox2.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.White;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(114, 427);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "password";
            passwordBox.Size = new Size(303, 37);
            passwordBox.TabIndex = 6;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.FromArgb(126, 33, 206);
            registerLabel.Location = new Point(60, 501);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(131, 25);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "TO REGISTER";
            registerLabel.Click += registerLabel_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.White;
            exitIcon.Cursor = Cursors.Hand;
            exitIcon.ForeColor = Color.FromArgb(126, 33, 206);
            exitIcon.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            exitIcon.IconColor = Color.FromArgb(126, 33, 206);
            exitIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitIcon.IconSize = 48;
            exitIcon.Location = new Point(458, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(48, 48);
            exitIcon.TabIndex = 10;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(282, 500);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 28);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(518, 752);
            Controls.Add(checkBox1);
            Controls.Add(exitIcon);
            Controls.Add(registerLabel);
            Controls.Add(panel2);
            Controls.Add(iconPictureBox2);
            Controls.Add(passwordBox);
            Controls.Add(panel1);
            Controls.Add(iconPictureBox1);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox1);
            Controls.Add(usernameBox);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Button LoginButton;
        private TextBox usernameBox;
        private PictureBox pictureBox1;
        private Label loginLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox passwordBox;
        private Label registerLabel;
        private FontAwesome.Sharp.IconPictureBox exitIcon;
        private CheckBox checkBox1;
    }
}