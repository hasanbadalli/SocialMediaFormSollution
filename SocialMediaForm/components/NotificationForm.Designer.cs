namespace SocialMediaForm.components
{
    partial class NotificationForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            button1 = new Button();
            acceptButton = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(122, 35);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(101, 25);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 35);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 2;
            label1.Text = " wants to follow you";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fotor_20240208164613;
            pictureBox1.Location = new Point(0, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 16, 38);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(acceptButton);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(55, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 171);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(688, 136);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 7;
            label4.Text = "3h ago";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(10, 16, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(185, 28, 28);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(185, 28, 28);
            button1.Location = new Point(258, 100);
            button1.Name = "button1";
            button1.Size = new Size(114, 50);
            button1.TabIndex = 6;
            button1.Text = "Reject";
            button1.UseVisualStyleBackColor = false;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.FromArgb(126, 33, 206);
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Lucida Console", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptButton.ForeColor = Color.White;
            acceptButton.Location = new Point(122, 100);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(114, 50);
            acceptButton.TabIndex = 5;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 35);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(219, 35);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "liked your photo";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fotor_20240208164613;
            pictureBox2.Location = new Point(0, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(10, 16, 38);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(55, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 109);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(688, 74);
            label5.Name = "label5";
            label5.Size = new Size(70, 24);
            label5.TabIndex = 8;
            label5.Text = "4h ago";
            // 
            // NotificationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 79);
            ClientSize = new Size(1174, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "NotificationForm";
            Text = "NotificationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button acceptButton;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label4;
        private Label label5;
    }
}