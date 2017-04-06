using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class MainForm : Form
    {
        public Database Database;
        public User User;
        public BindingSource BindingSource;
        
        public MainForm()
        {
            InitializeComponent();
            Database = new Database();
            BindingSource = new BindingSource();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Database.Load();
            BindingSource.DataSource = Database.Songs;

            this.artistLabel.DataBindings.Add("Text", BindingSource, "Artist", true, DataSourceUpdateMode.OnPropertyChanged);
            this.songLabel.DataBindings.Add("Text", BindingSource, "Title", true, DataSourceUpdateMode.OnPropertyChanged);
            this.imagePanel.DataBindings.Add("BackgroundImage", BindingSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged);
            this.album.DataBindings.Add("Text", BindingSource, "AlbumTitle", true, DataSourceUpdateMode.OnPropertyChanged);
            this.year.DataBindings.Add("Text", BindingSource, "Year", true, DataSourceUpdateMode.OnPropertyChanged);
            this.genre.DataBindings.Add("Text", BindingSource, "Genre", true, DataSourceUpdateMode.OnPropertyChanged);

            LoginForm loginForm = new LoginForm();
            loginForm.BindingSource.DataSource = Database;

            if (loginForm.ShowDialog() != DialogResult.OK)
                this.Close();

            this.name.DataBindings.Add("Text", Database.CurrentUser, "Username", true, DataSourceUpdateMode.OnPropertyChanged);

            AddPlaylistsToTreeView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BindingSource.MoveNext();
        }

        void AddPlaylistsToTreeView() {

            treeView.BeginUpdate();

            for (int i = 0; i < Database.Playlists.Count; i++)
            {
                TreeNode node = new TreeNode(Database.Playlists[i].Title);
                node.Tag = Database.Playlists[i];


                for (int j = 0; j < Database.Playlists[i].Songs.Count; j++) {

                    TreeNode child = new TreeNode(Database.Playlists[i].Songs[j].Title);
                    child.Tag = Database.Playlists[i].Songs[j];

                    node.Nodes.Add(child);

                }

                treeView.Nodes.Add(node);
                

            }

            treeView.EndUpdate();


        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode playListNode;

            if (treeView.SelectedNode.Level == 0) {

                playListNode = treeView.SelectedNode;
                this.BindingSource.Position = this.BindingSource.IndexOf(treeView.SelectedNode.Nodes[0].Tag);

            }

            else
            {
                this.BindingSource.Position = this.BindingSource.IndexOf(treeView.SelectedNode.Tag);
                playListNode = treeView.SelectedNode.Parent;
            }

            this.length.Text = ((Playlist)playListNode.Tag).Length.ToString();
            this.rating.Text = ((Playlist)playListNode.Tag).Rating.ToString();
            this.owner.Text = ((Playlist)playListNode.Tag).Owner.Username == Database.CurrentUser.Username 
                ? "You" : ((Playlist)playListNode.Tag).Owner.Username ;

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
        }
    }
}
