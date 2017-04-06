namespace MyFirstApp
{
    partial class MainForm
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.songLabel = new System.Windows.Forms.RichTextBox();
            this.artistLabel = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.albumLabel = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.genre = new System.Windows.Forms.RichTextBox();
            this.year = new System.Windows.Forms.RichTextBox();
            this.album = new System.Windows.Forms.RichTextBox();
            this.genreLabel = new System.Windows.Forms.RichTextBox();
            this.yearLabel = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.RichTextBox();
            this.rating = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.owner = new System.Windows.Forms.RichTextBox();
            this.lengthLabel = new System.Windows.Forms.RichTextBox();
            this.length = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.AutoSize = true;
            this.imagePanel.BackColor = System.Drawing.Color.White;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(155, 64);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(305, 257);
            this.imagePanel.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBar.Location = new System.Drawing.Point(12, 31);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(133, 23);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Search...";
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeView.Location = new System.Drawing.Point(12, 64);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(133, 315);
            this.treeView.TabIndex = 2;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleLabel.Location = new System.Drawing.Point(59, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 26);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "ListPlay";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.songLabel);
            this.panel1.Controls.Add(this.artistLabel);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(155, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 52);
            this.panel1.TabIndex = 0;
            // 
            // songLabel
            // 
            this.songLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.songLabel.Location = new System.Drawing.Point(61, 25);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(176, 22);
            this.songLabel.TabIndex = 3;
            this.songLabel.Text = "Love Yourz";
            // 
            // artistLabel
            // 
            this.artistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.artistLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.artistLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.artistLabel.Location = new System.Drawing.Point(61, 7);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(176, 20);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "J. Cole";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(250, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(14, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::MyFirstApp.Properties.Resources.generic_avatar;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(132, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 38);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(469, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 49);
            this.panel3.TabIndex = 8;
            // 
            // albumLabel
            // 
            this.albumLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.albumLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.albumLabel.Location = new System.Drawing.Point(5, 34);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(54, 20);
            this.albumLabel.TabIndex = 5;
            this.albumLabel.Text = "Album:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.richTextBox4);
            this.panel4.Controls.Add(this.richTextBox3);
            this.panel4.Controls.Add(this.length);
            this.panel4.Controls.Add(this.lengthLabel);
            this.panel4.Controls.Add(this.owner);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.rating);
            this.panel4.Controls.Add(this.ratingLabel);
            this.panel4.Controls.Add(this.genre);
            this.panel4.Controls.Add(this.year);
            this.panel4.Controls.Add(this.album);
            this.panel4.Controls.Add(this.genreLabel);
            this.panel4.Controls.Add(this.yearLabel);
            this.panel4.Controls.Add(this.albumLabel);
            this.panel4.Location = new System.Drawing.Point(469, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 257);
            this.panel4.TabIndex = 9;
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genre.Location = new System.Drawing.Point(60, 3);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(108, 17);
            this.genre.TabIndex = 10;
            this.genre.Text = "Rap";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.WhiteSmoke;
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.year.Location = new System.Drawing.Point(60, 18);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(108, 17);
            this.year.TabIndex = 9;
            this.year.Text = "2014";
            // 
            // album
            // 
            this.album.BackColor = System.Drawing.Color.WhiteSmoke;
            this.album.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.album.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.album.Location = new System.Drawing.Point(60, 34);
            this.album.Name = "album";
            this.album.Size = new System.Drawing.Size(108, 40);
            this.album.TabIndex = 8;
            this.album.Text = "Forest Hills Drive";
            // 
            // genreLabel
            // 
            this.genreLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genreLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreLabel.Location = new System.Drawing.Point(5, 3);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(54, 17);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearLabel.Location = new System.Drawing.Point(5, 18);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(54, 17);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.richTextBox2);
            this.panel5.Location = new System.Drawing.Point(469, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 52);
            this.panel5.TabIndex = 10;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.Location = new System.Drawing.Point(5, 7);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(181, 30);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Version 5.4\nLast updated on 4/6/17";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.SlateBlue;
            this.name.Location = new System.Drawing.Point(46, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 20);
            this.name.TabIndex = 8;
            this.name.Text = "Jahkell";
            // 
            // ratingLabel
            // 
            this.ratingLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ratingLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratingLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ratingLabel.Location = new System.Drawing.Point(5, 116);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(54, 20);
            this.ratingLabel.TabIndex = 11;
            this.ratingLabel.Text = "Rating:";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rating.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rating.Location = new System.Drawing.Point(60, 116);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(104, 20);
            this.rating.TabIndex = 12;
            this.rating.Text = "-";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(5, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(54, 20);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Owner:";
            // 
            // owner
            // 
            this.owner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.owner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.owner.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.owner.Location = new System.Drawing.Point(60, 133);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(104, 20);
            this.owner.TabIndex = 14;
            this.owner.Text = "-";
            // 
            // lengthLabel
            // 
            this.lengthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lengthLabel.Location = new System.Drawing.Point(5, 150);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(54, 20);
            this.lengthLabel.TabIndex = 15;
            this.lengthLabel.Text = "Length:";
            // 
            // length
            // 
            this.length.BackColor = System.Drawing.Color.WhiteSmoke;
            this.length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.length.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.length.Location = new System.Drawing.Point(60, 150);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(104, 20);
            this.length.TabIndex = 16;
            this.length.Text = "-";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox3.Location = new System.Drawing.Point(60, 166);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(104, 20);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "seconds";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox4.Location = new System.Drawing.Point(5, 98);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(54, 20);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "Playlist";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.titleLabel);
            this.panel6.Location = new System.Drawing.Point(206, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 37);
            this.panel6.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 391);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(671, 430);
            this.MinimumSize = new System.Drawing.Size(671, 430);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox albumLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox artistLabel;
        private System.Windows.Forms.RichTextBox songLabel;
        private System.Windows.Forms.RichTextBox yearLabel;
        private System.Windows.Forms.RichTextBox genreLabel;
        private System.Windows.Forms.RichTextBox album;
        private System.Windows.Forms.RichTextBox year;
        private System.Windows.Forms.RichTextBox genre;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.RichTextBox ratingLabel;
        private System.Windows.Forms.RichTextBox rating;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox owner;
        private System.Windows.Forms.RichTextBox lengthLabel;
        private System.Windows.Forms.RichTextBox length;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Panel panel6;
    }
}

