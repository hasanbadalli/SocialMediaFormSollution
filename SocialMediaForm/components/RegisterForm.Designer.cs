namespace SocialMediaForm.components
{
    partial class RegisterForm
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
            checkBox1 = new CheckBox();
            exitIcon = new FontAwesome.Sharp.IconPictureBox();
            loginLabel = new Label();
            panel2 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            passwordBox = new TextBox();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            registerLabel = new Label();
            pictureBox1 = new PictureBox();
            usernameBox = new TextBox();
            registerButton = new Button();
            panel3 = new Panel();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            emailBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(270, 524);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(167, 28);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
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
            exitIcon.Location = new Point(436, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(48, 48);
            exitIcon.TabIndex = 22;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.FromArgb(126, 33, 206);
            loginLabel.Location = new Point(48, 527);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(131, 25);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "TO REGISTER";
            loginLabel.Click += loginLabel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(48, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 1);
            panel2.TabIndex = 20;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.ForeColor = Color.FromArgb(126, 33, 206);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.FromArgb(126, 33, 206);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 48;
            iconPictureBox2.Location = new Point(48, 440);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(48, 48);
            iconPictureBox2.TabIndex = 19;
            iconPictureBox2.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.White;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(102, 452);
            passwordBox.Multiline = true;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "password";
            passwordBox.Size = new Size(303, 37);
            passwordBox.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(48, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 1);
            panel1.TabIndex = 17;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(126, 33, 206);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.FromArgb(126, 33, 206);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(48, 262);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 16;
            iconPictureBox1.TabStop = false;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = Color.White;
            registerLabel.Font = new Font("Lucida Console", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.FromArgb(126, 33, 206);
            registerLabel.Location = new Point(123, 195);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(260, 48);
            registerLabel.TabIndex = 15;
            registerLabel.Text = "REGISTER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(114, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.White;
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.Location = new Point(102, 274);
            usernameBox.Multiline = true;
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "username";
            usernameBox.Size = new Size(303, 37);
            usernameBox.TabIndex = 13;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(126, 33, 206);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(140, 589);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(163, 67);
            registerButton.TabIndex = 12;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(48, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 1);
            panel3.TabIndex = 26;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.ForeColor = Color.FromArgb(126, 33, 206);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox3.IconColor = Color.FromArgb(126, 33, 206);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(48, 347);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 48);
            iconPictureBox3.TabIndex = 25;
            iconPictureBox3.TabStop = false;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.White;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.Location = new Point(102, 359);
            emailBox.Multiline = true;
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "email";
            emailBox.Size = new Size(303, 37);
            emailBox.TabIndex = 24;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 696);
            Controls.Add(panel3);
            Controls.Add(iconPictureBox3);
            Controls.Add(emailBox);
            Controls.Add(checkBox1);
            Controls.Add(exitIcon);
            Controls.Add(loginLabel);
            Controls.Add(panel2);
            Controls.Add(iconPictureBox2);
            Controls.Add(passwordBox);
            Controls.Add(panel1);
            Controls.Add(iconPictureBox1);
            Controls.Add(registerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(usernameBox);
            Controls.Add(registerButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private FontAwesome.Sharp.IconPictureBox exitIcon;
        private Label loginLabel;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox passwordBox;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label registerLabel;
        private PictureBox pictureBox1;
        private TextBox usernameBox;
        private Button registerButton;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TextBox emailBox;
    }
}