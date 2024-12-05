namespace SocialMediaForm.components
{
    partial class PostForm
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
            postsPanel = new Panel();
            SuspendLayout();
            // 
            // postsPanel
            // 
            postsPanel.Dock = DockStyle.Fill;
            postsPanel.Location = new Point(0, 0);
            postsPanel.Name = "postsPanel";
            postsPanel.Size = new Size(1174, 736);
            postsPanel.TabIndex = 0;
            postsPanel.Paint += postsPanel_Paint;
            // 
            // PostForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 35, 79);
            ClientSize = new Size(1174, 736);
            Controls.Add(postsPanel);
            Name = "PostForm";
            Text = "PostForm";
            Load += PostForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel postsPanel;
    }
}