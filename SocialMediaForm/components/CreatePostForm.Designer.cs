namespace SocialMediaForm.components
{
    partial class CreatePostForm
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
            panel1 = new Panel();
            titleBox = new TextBox();
            contentBox = new RichTextBox();
            titleLabel = new Label();
            contentLabel = new Label();
            isPublicCheck = new CheckBox();
            createPostBtn = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(134, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 1);
            panel1.TabIndex = 11;
            // 
            // titleBox
            // 
            titleBox.BackColor = Color.FromArgb(21, 35, 79);
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.ForeColor = Color.White;
            titleBox.Location = new Point(134, 177);
            titleBox.Multiline = true;
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "title";
            titleBox.Size = new Size(303, 37);
            titleBox.TabIndex = 9;
            // 
            // contentBox
            // 
            contentBox.BackColor = Color.FromArgb(21, 35, 79);
            contentBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentBox.ForeColor = Color.White;
            contentBox.Location = new Point(134, 313);
            contentBox.Name = "contentBox";
            contentBox.Size = new Size(335, 213);
            contentBox.TabIndex = 14;
            contentBox.Text = "";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Cursor = Cursors.Hand;
            titleLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(139, 92, 246);
            titleLabel.Location = new Point(121, 127);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(119, 47);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "TITLE";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Cursor = Cursors.Hand;
            contentLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contentLabel.ForeColor = Color.FromArgb(139, 92, 246);
            contentLabel.Location = new Point(121, 263);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(202, 47);
            contentLabel.TabIndex = 16;
            contentLabel.Text = "CONTENT";
            // 
            // isPublicCheck
            // 
            isPublicCheck.AutoSize = true;
            isPublicCheck.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isPublicCheck.ForeColor = Color.FromArgb(139, 92, 246);
            isPublicCheck.Location = new Point(138, 546);
            isPublicCheck.Name = "isPublicCheck";
            isPublicCheck.Size = new Size(121, 29);
            isPublicCheck.TabIndex = 17;
            isPublicCheck.Text = "is Public?";
            isPublicCheck.UseVisualStyleBackColor = true;
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
            createPostBtn.Location = new Point(420, 574);
            createPostBtn.Name = "createPostBtn";
            createPostBtn.Size = new Size(318, 100);
            createPostBtn.TabIndex = 18;
            createPostBtn.Text = "Create Post";
            createPostBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createPostBtn.UseVisualStyleBackColor = false;
            createPostBtn.Click += createPostBtn_Click;
            // 
            // CreatePostForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 79);
            ClientSize = new Size(1174, 736);
            Controls.Add(createPostBtn);
            Controls.Add(isPublicCheck);
            Controls.Add(contentLabel);
            Controls.Add(titleLabel);
            Controls.Add(contentBox);
            Controls.Add(panel1);
            Controls.Add(titleBox);
            Name = "CreatePostForm";
            Text = "CreatePostForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox titleBox;
        private RichTextBox contentBox;
        private Label titleLabel;
        private Label contentLabel;
        private CheckBox isPublicCheck;
        private FontAwesome.Sharp.IconButton createPostBtn;
    }
}