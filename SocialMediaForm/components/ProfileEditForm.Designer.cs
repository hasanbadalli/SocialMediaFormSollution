namespace SocialMediaForm.components
{
    partial class ProfileEditForm
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            titleBox = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            createPostBtn = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fotor_20240208164613;
            pictureBox1.Location = new Point(24, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(24, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 1);
            panel1.TabIndex = 13;
            // 
            // titleBox
            // 
            titleBox.BackColor = Color.FromArgb(21, 35, 79);
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.ForeColor = Color.White;
            titleBox.Location = new Point(24, 157);
            titleBox.Multiline = true;
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "hbedelli";
            titleBox.Size = new Size(303, 37);
            titleBox.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(24, 244);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(21, 35, 79);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(24, 217);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "hbedelli@std.beu.edu.az";
            textBox1.Size = new Size(303, 37);
            textBox1.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(24, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(21, 35, 79);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(24, 276);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "password";
            textBox2.Size = new Size(303, 37);
            textBox2.TabIndex = 16;
            // 
            // createPostBtn
            // 
            createPostBtn.BackColor = Color.FromArgb(126, 33, 206);
            createPostBtn.Cursor = Cursors.Hand;
            createPostBtn.FlatAppearance.BorderSize = 0;
            createPostBtn.FlatStyle = FlatStyle.Flat;
            createPostBtn.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            createPostBtn.ForeColor = Color.White;
            createPostBtn.IconChar = FontAwesome.Sharp.IconChar.PenFancy;
            createPostBtn.IconColor = Color.White;
            createPostBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createPostBtn.ImageAlign = ContentAlignment.MiddleRight;
            createPostBtn.Location = new Point(64, 350);
            createPostBtn.Name = "createPostBtn";
            createPostBtn.Size = new Size(244, 52);
            createPostBtn.TabIndex = 19;
            createPostBtn.Text = "SAVE";
            createPostBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createPostBtn.UseVisualStyleBackColor = false;
            createPostBtn.Click += createPostBtn_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(21, 35, 79);
            iconPictureBox1.ForeColor = Color.FromArgb(139, 92, 246);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CameraAlt;
            iconPictureBox1.IconColor = Color.FromArgb(139, 92, 246);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 48;
            iconPictureBox1.Location = new Point(162, 44);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(48, 48);
            iconPictureBox1.TabIndex = 20;
            iconPictureBox1.TabStop = false;
            // 
            // ProfileEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 79);
            ClientSize = new Size(411, 450);
            Controls.Add(iconPictureBox1);
            Controls.Add(createPostBtn);
            Controls.Add(panel3);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(titleBox);
            Controls.Add(pictureBox1);
            Name = "ProfileEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileEditForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox titleBox;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton createPostBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}