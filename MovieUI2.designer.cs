
namespace CMPT_291_Project
{
    partial class MovieUI2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchGenre = new System.Windows.Forms.Button();
            this.labelnot = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movie,
            this.genre,
            this.copies,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(14, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(657, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // movie
            // 
            this.movie.HeaderText = "Movie Name";
            this.movie.Name = "movie";
            this.movie.Width = 300;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.Width = 150;
            // 
            // copies
            // 
            this.copies.HeaderText = "Copies Left";
            this.copies.Name = "copies";
            this.copies.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Movie:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(687, 339);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 31);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add To Queue";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.Search.Location = new System.Drawing.Point(98, 482);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search Movie";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(381, 453);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // SearchGenre
            // 
            this.SearchGenre.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.SearchGenre.Location = new System.Drawing.Point(479, 482);
            this.SearchGenre.Name = "SearchGenre";
            this.SearchGenre.Size = new System.Drawing.Size(114, 23);
            this.SearchGenre.TabIndex = 7;
            this.SearchGenre.Text = "Search Genre";
            this.SearchGenre.UseVisualStyleBackColor = true;
            this.SearchGenre.Click += new System.EventHandler(this.SearchGenre_Click);
            // 
            // labelnot
            // 
            this.labelnot.AccessibleName = "labelnot";
            this.labelnot.AutoSize = true;
            this.labelnot.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Bold);
            this.labelnot.ForeColor = System.Drawing.Color.Red;
            this.labelnot.Location = new System.Drawing.Point(207, 393);
            this.labelnot.Name = "labelnot";
            this.labelnot.Size = new System.Drawing.Size(255, 22);
            this.labelnot.TabIndex = 9;
            this.labelnot.Text = "Movie Not Found. Try Again.";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(687, 62);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(107, 28);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dropDown
            // 
            this.dropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.FormattingEnabled = true;
            this.dropDown.Location = new System.Drawing.Point(10, 451);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(320, 23);
            this.dropDown.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(719, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 12;
            // 
            // MovieUI2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 517);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dropDown);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.labelnot);
            this.Controls.Add(this.SearchGenre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MovieUI2";
            this.Text = "Movie UI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchGenre;
        private System.Windows.Forms.Label labelnot;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox dropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.TextBox textBox1;
    }
}

