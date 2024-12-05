namespace SocialMediaForm.components
{
    partial class Profile
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
            usernameLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            editProfileBtn = new FontAwesome.Sharp.IconPictureBox();
            followedCountLabel = new Label();
            followerCountLabel = new Label();
            followedLabel = new Label();
            followerLabel = new Label();
            postsPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)editProfileBtn).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(172, 56);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(101, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "username";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(usernameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 128);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fotor_20240208164613;
            pictureBox1.Location = new Point(34, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(editProfileBtn);
            panel2.Controls.Add(followedCountLabel);
            panel2.Controls.Add(followerCountLabel);
            panel2.Controls.Add(followedLabel);
            panel2.Controls.Add(followerLabel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(699, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(475, 128);
            panel2.TabIndex = 1;
            // 
            // editProfileBtn
            // 
            editProfileBtn.BackColor = Color.FromArgb(21, 35, 79);
            editProfileBtn.Cursor = Cursors.Hand;
            editProfileBtn.ForeColor = Color.FromArgb(139, 92, 246);
            editProfileBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            editProfileBtn.IconColor = Color.FromArgb(139, 92, 246);
            editProfileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            editProfileBtn.IconSize = 48;
            editProfileBtn.Location = new Point(415, 12);
            editProfileBtn.Name = "editProfileBtn";
            editProfileBtn.Size = new Size(48, 48);
            editProfileBtn.TabIndex = 3;
            editProfileBtn.TabStop = false;
            editProfileBtn.Click += editProfileBtn_Click;
            // 
            // followedCountLabel
            // 
            followedCountLabel.AutoSize = true;
            followedCountLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            followedCountLabel.ForeColor = Color.White;
            followedCountLabel.Location = new Point(352, 56);
            followedCountLabel.Name = "followedCountLabel";
            followedCountLabel.Size = new Size(23, 25);
            followedCountLabel.TabIndex = 5;
            followedCountLabel.Text = "0";
            // 
            // followerCountLabel
            // 
            followerCountLabel.AutoSize = true;
            followerCountLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            followerCountLabel.ForeColor = Color.White;
            followerCountLabel.Location = new Point(130, 56);
            followerCountLabel.Name = "followerCountLabel";
            followerCountLabel.Size = new Size(23, 25);
            followerCountLabel.TabIndex = 4;
            followerCountLabel.Text = "0";
            // 
            // followedLabel
            // 
            followedLabel.AutoSize = true;
            followedLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            followedLabel.ForeColor = Color.White;
            followedLabel.Location = new Point(265, 56);
            followedLabel.Name = "followedLabel";
            followedLabel.Size = new Size(95, 25);
            followedLabel.TabIndex = 3;
            followedLabel.Text = "followed:";
            // 
            // followerLabel
            // 
            followerLabel.AutoSize = true;
            followerLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            followerLabel.ForeColor = Color.White;
            followerLabel.Location = new Point(42, 56);
            followerLabel.Name = "followerLabel";
            followerLabel.Size = new Size(91, 25);
            followerLabel.TabIndex = 2;
            followerLabel.Text = "follower:";
            followerLabel.Click += followerLabel_Click;
            // 
            // postsPanel
            // 
            postsPanel.AutoScroll = true;
            postsPanel.Dock = DockStyle.Fill;
            postsPanel.Location = new Point(0, 128);
            postsPanel.Name = "postsPanel";
            postsPanel.Size = new Size(1174, 608);
            postsPanel.TabIndex = 2;
            postsPanel.Paint += panel3_Paint;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 79);
            ClientSize = new Size(1174, 736);
            Controls.Add(postsPanel);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDark;
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)editProfileBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label usernameLabel;
        private Panel panel1;
        private Panel panel2;
        private Label followedLabel;
        private Label followerLabel;
        private Label followerCountLabel;
        private Label followedCountLabel;
        private Panel postsPanel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox editProfileBtn;
    }
}