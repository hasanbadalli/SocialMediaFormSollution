namespace SocialMediaForm
{
    partial class Main
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
            panelMenu = new Panel();
            createPostBtn = new FontAwesome.Sharp.IconButton();
            friendPostBtn = new FontAwesome.Sharp.IconButton();
            notificationBtn = new FontAwesome.Sharp.IconButton();
            postBtn = new FontAwesome.Sharp.IconButton();
            profileBtn = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            maxBtn = new FontAwesome.Sharp.IconPictureBox();
            exitBtn = new FontAwesome.Sharp.IconPictureBox();
            minusBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            pictureBox2 = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minusBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(23, 37, 84);
            panelMenu.Controls.Add(createPostBtn);
            panelMenu.Controls.Add(friendPostBtn);
            panelMenu.Controls.Add(notificationBtn);
            panelMenu.Controls.Add(postBtn);
            panelMenu.Controls.Add(profileBtn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(300, 915);
            panelMenu.TabIndex = 0;
            // 
            // createPostBtn
            // 
            createPostBtn.Cursor = Cursors.Hand;
            createPostBtn.Dock = DockStyle.Top;
            createPostBtn.FlatAppearance.BorderSize = 0;
            createPostBtn.FlatStyle = FlatStyle.Flat;
            createPostBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            createPostBtn.ForeColor = Color.FromArgb(139, 92, 246);
            createPostBtn.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            createPostBtn.IconColor = Color.FromArgb(139, 92, 246);
            createPostBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createPostBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createPostBtn.Location = new Point(0, 550);
            createPostBtn.Name = "createPostBtn";
            createPostBtn.Padding = new Padding(10, 0, 0, 0);
            createPostBtn.Size = new Size(300, 100);
            createPostBtn.TabIndex = 5;
            createPostBtn.Text = "Create Post";
            createPostBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createPostBtn.UseVisualStyleBackColor = true;
            createPostBtn.Click += createPostBtn_Click;
            // 
            // friendPostBtn
            // 
            friendPostBtn.Cursor = Cursors.Hand;
            friendPostBtn.Dock = DockStyle.Top;
            friendPostBtn.FlatAppearance.BorderSize = 0;
            friendPostBtn.FlatStyle = FlatStyle.Flat;
            friendPostBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            friendPostBtn.ForeColor = Color.FromArgb(139, 92, 246);
            friendPostBtn.IconChar = FontAwesome.Sharp.IconChar.FaceGrinHearts;
            friendPostBtn.IconColor = Color.FromArgb(139, 92, 246);
            friendPostBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            friendPostBtn.ImageAlign = ContentAlignment.MiddleLeft;
            friendPostBtn.Location = new Point(0, 450);
            friendPostBtn.Name = "friendPostBtn";
            friendPostBtn.Padding = new Padding(10, 0, 0, 0);
            friendPostBtn.Size = new Size(300, 100);
            friendPostBtn.TabIndex = 4;
            friendPostBtn.Text = "Friend Posts";
            friendPostBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            friendPostBtn.UseVisualStyleBackColor = true;
            friendPostBtn.Click += friendPostBtn_Click;
            // 
            // notificationBtn
            // 
            notificationBtn.Cursor = Cursors.Hand;
            notificationBtn.Dock = DockStyle.Top;
            notificationBtn.FlatAppearance.BorderSize = 0;
            notificationBtn.FlatStyle = FlatStyle.Flat;
            notificationBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            notificationBtn.ForeColor = Color.FromArgb(139, 92, 246);
            notificationBtn.IconChar = FontAwesome.Sharp.IconChar.Bell;
            notificationBtn.IconColor = Color.FromArgb(139, 92, 246);
            notificationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            notificationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            notificationBtn.Location = new Point(0, 350);
            notificationBtn.Name = "notificationBtn";
            notificationBtn.Padding = new Padding(10, 0, 0, 0);
            notificationBtn.Size = new Size(300, 100);
            notificationBtn.TabIndex = 3;
            notificationBtn.Text = "Notifications";
            notificationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            notificationBtn.UseVisualStyleBackColor = true;
            notificationBtn.Click += notificationBtn_Click;
            // 
            // postBtn
            // 
            postBtn.Cursor = Cursors.Hand;
            postBtn.Dock = DockStyle.Top;
            postBtn.FlatAppearance.BorderSize = 0;
            postBtn.FlatStyle = FlatStyle.Flat;
            postBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            postBtn.ForeColor = Color.FromArgb(139, 92, 246);
            postBtn.IconChar = FontAwesome.Sharp.IconChar.Message;
            postBtn.IconColor = Color.FromArgb(139, 92, 246);
            postBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            postBtn.ImageAlign = ContentAlignment.MiddleLeft;
            postBtn.Location = new Point(0, 250);
            postBtn.Name = "postBtn";
            postBtn.Padding = new Padding(10, 0, 0, 0);
            postBtn.Size = new Size(300, 100);
            postBtn.TabIndex = 2;
            postBtn.Text = "Posts";
            postBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            postBtn.UseVisualStyleBackColor = true;
            postBtn.Click += postBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.Cursor = Cursors.Hand;
            profileBtn.Dock = DockStyle.Top;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            profileBtn.ForeColor = Color.FromArgb(139, 92, 246);
            profileBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            profileBtn.IconColor = Color.FromArgb(139, 92, 246);
            profileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            profileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            profileBtn.Location = new Point(0, 150);
            profileBtn.Name = "profileBtn";
            profileBtn.Padding = new Padding(10, 0, 0, 0);
            profileBtn.Size = new Size(300, 100);
            profileBtn.TabIndex = 1;
            profileBtn.Text = "Profile";
            profileBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(23, 37, 84);
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(300, 150);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = Properties.Resources.image_removebg_preview;
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(261, 114);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(17, 28, 64);
            panelTitleBar.Controls.Add(maxBtn);
            panelTitleBar.Controls.Add(exitBtn);
            panelTitleBar.Controls.Add(minusBtn);
            panelTitleBar.Controls.Add(pictureBox1);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(300, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1196, 114);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxBtn.BackColor = Color.FromArgb(17, 28, 64);
            maxBtn.ForeColor = Color.FromArgb(139, 92, 246);
            maxBtn.IconChar = FontAwesome.Sharp.IconChar.Square;
            maxBtn.IconColor = Color.FromArgb(139, 92, 246);
            maxBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maxBtn.IconSize = 25;
            maxBtn.Location = new Point(1128, 10);
            maxBtn.Name = "maxBtn";
            maxBtn.Size = new Size(25, 33);
            maxBtn.TabIndex = 7;
            maxBtn.TabStop = false;
            maxBtn.Click += maxBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitBtn.BackColor = Color.FromArgb(17, 28, 64);
            exitBtn.ForeColor = Color.FromArgb(139, 92, 246);
            exitBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            exitBtn.IconColor = Color.FromArgb(139, 92, 246);
            exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitBtn.IconSize = 25;
            exitBtn.Location = new Point(1159, 10);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(25, 33);
            exitBtn.TabIndex = 6;
            exitBtn.TabStop = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minusBtn.Image = Properties.Resources.minus_sign;
            minusBtn.Location = new Point(1097, 3);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(25, 33);
            minusBtn.SizeMode = PictureBoxSizeMode.Zoom;
            minusBtn.TabIndex = 5;
            minusBtn.TabStop = false;
            minusBtn.Click += minusBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.fotor_20240208164613;
            pictureBox1.Location = new Point(1109, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(17, 28, 64);
            iconCurrentChildForm.Cursor = Cursors.No;
            iconCurrentChildForm.ForeColor = Color.FromArgb(139, 92, 246);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.User;
            iconCurrentChildForm.IconColor = Color.FromArgb(139, 92, 246);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 48;
            iconCurrentChildForm.Location = new Point(36, 49);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(48, 48);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(17, 28, 64);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(300, 114);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1196, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(21, 35, 79);
            panelDesktop.Controls.Add(pictureBox2);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(300, 123);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1196, 792);
            panelDesktop.TabIndex = 3;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(330, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(555, 326);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1496, 915);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Main";
            Text = "Main";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)maxBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)minusBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton profileBtn;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton friendPostBtn;
        private FontAwesome.Sharp.IconButton notificationBtn;
        private FontAwesome.Sharp.IconButton postBtn;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton createPostBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox exitBtn;
        private PictureBox minusBtn;
        private FontAwesome.Sharp.IconPictureBox maxBtn;
    }
}