using SocialMediaForm.ViewModels;
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
    public partial class PostForm : Form
    {
        private string connectionString = "Server=THEUZUNHASAN;Database=SocialMediaDb;Trusted_Connection=True;User id = sa;Password = baku2024!;";

        public PostForm()
        {
            InitializeComponent();
            LoadPosts();
        }
        private void LoadPosts()
        {
            List<PostViewModel> posts = new List<PostViewModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            P.PostID,
            P.Title,
            P.Content,
            U.Username AS Author,
            P.CreatedAt
        FROM [Posts] P
        INNER JOIN [Users] U ON P.UserId = U.Id
        WHERE P.IsPublished = 1 AND U.Id != @UserId
        ORDER BY P.CreatedAt DESC";

                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                  
                        command.Parameters.AddWithValue("@UserId", UserSession.UserId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                posts.Add(new PostViewModel
                                {
                                    Title = reader["Title"].ToString(),
                                    Content = reader["Content"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Data gelende xeta oldu: {ex.Message}");
                }
            }

            PopulatePostsPanel(posts);
        }


        private void PopulatePostsPanel(List<PostViewModel> posts)
        {
            postsPanel.Controls.Clear();
            int yOffset = 10; 

            foreach (var post in posts)
            {
                
                Panel postPanel = new Panel
                {
                    Size = new Size(postsPanel.Width - 30, 0), 
                    Location = new Point(10, yOffset),
                    BackColor = Color.FromArgb(10, 16, 38),
                    BorderStyle = BorderStyle.None
                };

                Label authorLabel = new Label
                {
                    Text = $"Yazan: {post.Author}",
                    Font = new Font("Arial", 9, FontStyle.Italic),
                    ForeColor = Color.LightGray,
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label titleLabel = new Label
                {
                    Text = post.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(10, authorLabel.Bottom + 5),
                    AutoSize = true
                };

                Label contentLabel = new Label
                {
                    Text = post.Content,
                    Font = new Font("Arial", 10),
                    ForeColor = Color.Gray,
                    Location = new Point(10, titleLabel.Bottom + 10),
                    AutoSize = true,
                    MaximumSize = new Size(postPanel.Width - 20, 0) 
                };

       
                contentLabel.Size = contentLabel.PreferredSize;

             
                FontAwesome.Sharp.IconButton heartIcon = new FontAwesome.Sharp.IconButton
                {
                    IconChar = FontAwesome.Sharp.IconChar.Heart,
                    IconColor = Color.FromArgb(139, 92, 246),
                    Text = "1",
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ImageAlign = ContentAlignment.TopCenter,
                    ForeColor = Color.White,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(10, contentLabel.Bottom + 15),
                    Size = new Size(70, 50), 
                    IconSize = 32,       
                    FlatAppearance = {
                        BorderSize = 0,
                        MouseOverBackColor = Color.Transparent,
                        MouseDownBackColor = Color.Transparent
                    }

                };

         
                FontAwesome.Sharp.IconButton commentIcon = new FontAwesome.Sharp.IconButton
                {
                    IconChar = FontAwesome.Sharp.IconChar.Comment,
                    IconColor = Color.FromArgb(139, 92, 246),
                    Text = "1",
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ImageAlign = ContentAlignment.TopCenter,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(heartIcon.Right + 15, contentLabel.Bottom + 15),
                    Size = new Size(70, 50), 
                    IconSize = 32,         
                    FlatAppearance = {
                        BorderSize = 0,
                        MouseOverBackColor = Color.Transparent,
                        MouseDownBackColor = Color.Transparent
                    }  
                };

  
                int panelHeight = Math.Max(heartIcon.Bottom, commentIcon.Bottom) + 15;
                postPanel.Size = new Size(postPanel.Width, panelHeight);

               
                postPanel.Controls.Add(authorLabel);
                postPanel.Controls.Add(titleLabel);
                postPanel.Controls.Add(contentLabel);
                postPanel.Controls.Add(heartIcon);
                postPanel.Controls.Add(commentIcon);

                
                postsPanel.Controls.Add(postPanel);

                yOffset += postPanel.Height + 20; 
            }

            postsPanel.AutoScroll = true;
        }
        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void postsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
