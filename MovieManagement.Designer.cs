
namespace CMPT_291_Project
{
    partial class MovieManagement
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
            this.moviesListView = new System.Windows.Forms.ListView();
            this.movieIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieTitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieGenreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieCopiesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.editMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesListView
            // 
            this.moviesListView.AllowColumnReorder = true;
            this.moviesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieIdColumn,
            this.movieTitleHeader,
            this.movieGenreHeader,
            this.movieCopiesHeader});
            this.moviesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesListView.FullRowSelect = true;
            this.moviesListView.HideSelection = false;
            this.moviesListView.Location = new System.Drawing.Point(48, 83);
            this.moviesListView.MultiSelect = false;
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(883, 567);
            this.moviesListView.TabIndex = 0;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            this.moviesListView.View = System.Windows.Forms.View.Details;
            this.moviesListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // movieIdColumn
            // 
            this.movieIdColumn.Text = "ID";
            this.movieIdColumn.Width = 75;
            // 
            // movieTitleHeader
            // 
            this.movieTitleHeader.Text = "Title";
            this.movieTitleHeader.Width = 461;
            // 
            // movieGenreHeader
            // 
            this.movieGenreHeader.Text = "Genre";
            this.movieGenreHeader.Width = 155;
            // 
            // movieCopiesHeader
            // 
            this.movieCopiesHeader.Text = "Copies Available";
            this.movieCopiesHeader.Width = 188;
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieBtn.Location = new System.Drawing.Point(847, 656);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(39, 35);
            this.addMovieBtn.TabIndex = 1;
            this.addMovieBtn.Text = "➕";
            this.addMovieBtn.UseVisualStyleBackColor = true;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMovieButton.Location = new System.Drawing.Point(892, 656);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(39, 35);
            this.deleteMovieButton.TabIndex = 2;
            this.deleteMovieButton.Text = "➖";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // editMovieButton
            // 
            this.editMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMovieButton.Location = new System.Drawing.Point(48, 656);
            this.editMovieButton.Name = "editMovieButton";
            this.editMovieButton.Size = new System.Drawing.Size(124, 35);
            this.editMovieButton.TabIndex = 3;
            this.editMovieButton.Text = "Edit";
            this.editMovieButton.UseVisualStyleBackColor = true;
            this.editMovieButton.Click += new System.EventHandler(this.editMovieButton_Click);
            // 
            // MovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 779);
            this.Controls.Add(this.editMovieButton);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieBtn);
            this.Controls.Add(this.moviesListView);
            this.Name = "MovieManagement";
            this.Text = "MovieManagement";
            this.Load += new System.EventHandler(this.MovieManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView moviesListView;
        private System.Windows.Forms.ColumnHeader movieIdColumn;
        private System.Windows.Forms.ColumnHeader movieTitleHeader;
        private System.Windows.Forms.ColumnHeader movieGenreHeader;
        private System.Windows.Forms.ColumnHeader movieCopiesHeader;
        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button editMovieButton;
    }
}