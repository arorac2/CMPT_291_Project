

namespace CMPT_291_Project
{
    partial class MovieUI
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
            this.AddCheck = new System.Windows.Forms.CheckBox();
            this.SearchCheck = new System.Windows.Forms.CheckBox();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.MovieInput = new System.Windows.Forms.TextBox();
            this.SearchGenreLabel = new System.Windows.Forms.Label();
            this.GenreInput = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddMovieNameLabel = new System.Windows.Forms.Label();
            this.AddGenreLabel = new System.Windows.Forms.Label();
            this.AddRatingLabel = new System.Windows.Forms.Label();
            this.AddFeeLabel = new System.Windows.Forms.Label();
            this.AddMovieInput = new System.Windows.Forms.TextBox();
            this.AddFeeBox = new System.Windows.Forms.TextBox();
            this.AddRatingBox = new System.Windows.Forms.ComboBox();
            this.AddGenreBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddID = new System.Windows.Forms.Label();
            this.AddIDInput = new System.Windows.Forms.TextBox();
            this.SearchIDLabel = new System.Windows.Forms.Label();
            this.SearchIDInput = new System.Windows.Forms.TextBox();
            this.MovieName = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCheck
            // 
            this.AddCheck.AutoSize = true;
            this.AddCheck.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddCheck.Location = new System.Drawing.Point(496, 10);
            this.AddCheck.Name = "AddCheck";
            this.AddCheck.Size = new System.Drawing.Size(91, 25);
            this.AddCheck.TabIndex = 0;
            this.AddCheck.Text = "Add Movie";
            this.AddCheck.UseVisualStyleBackColor = true;
            // 
            // SearchCheck
            // 
            this.SearchCheck.AutoSize = true;
            this.SearchCheck.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.SearchCheck.Location = new System.Drawing.Point(579, 10);
            this.SearchCheck.Name = "SearchCheck";
            this.SearchCheck.Size = new System.Drawing.Size(107, 25);
            this.SearchCheck.TabIndex = 1;
            this.SearchCheck.Text = "Search Movie";
            this.SearchCheck.UseVisualStyleBackColor = true;
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Rockwell Condensed", 18F);
            this.MovieLabel.Location = new System.Drawing.Point(49, 75);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(166, 29);
            this.MovieLabel.TabIndex = 2;
            this.MovieLabel.Text = "Search for a Movie:";
            // 
            // MovieInput
            // 
            this.MovieInput.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.MovieInput.Location = new System.Drawing.Point(201, 75);
            this.MovieInput.Name = "MovieInput";
            this.MovieInput.Size = new System.Drawing.Size(292, 28);
            this.MovieInput.TabIndex = 3;
            this.MovieInput.TextChanged += new System.EventHandler(this.MovieInput_TextChanged);
            // 
            // SearchGenreLabel
            // 
            this.SearchGenreLabel.AutoSize = true;
            this.SearchGenreLabel.Font = new System.Drawing.Font("Rockwell Condensed", 18F);
            this.SearchGenreLabel.Location = new System.Drawing.Point(49, 112);
            this.SearchGenreLabel.Name = "SearchGenreLabel";
            this.SearchGenreLabel.Size = new System.Drawing.Size(162, 29);
            this.SearchGenreLabel.TabIndex = 4;
            this.SearchGenreLabel.Text = "Search For a Genre";
            // 
            // GenreInput
            // 
            this.GenreInput.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.GenreInput.Location = new System.Drawing.Point(201, 113);
            this.GenreInput.Name = "GenreInput";
            this.GenreInput.Size = new System.Drawing.Size(292, 28);
            this.GenreInput.TabIndex = 5;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.UpdateButton.Location = new System.Drawing.Point(10, 10);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(67, 29);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddMovieNameLabel
            // 
            this.AddMovieNameLabel.AutoSize = true;
            this.AddMovieNameLabel.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddMovieNameLabel.Location = new System.Drawing.Point(26, 228);
            this.AddMovieNameLabel.Name = "AddMovieNameLabel";
            this.AddMovieNameLabel.Size = new System.Drawing.Size(85, 21);
            this.AddMovieNameLabel.TabIndex = 7;
            this.AddMovieNameLabel.Text = "Movie Name:";
            // 
            // AddGenreLabel
            // 
            this.AddGenreLabel.AutoSize = true;
            this.AddGenreLabel.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddGenreLabel.Location = new System.Drawing.Point(28, 286);
            this.AddGenreLabel.Name = "AddGenreLabel";
            this.AddGenreLabel.Size = new System.Drawing.Size(44, 21);
            this.AddGenreLabel.TabIndex = 8;
            this.AddGenreLabel.Text = "Genre:";
            // 
            // AddRatingLabel
            // 
            this.AddRatingLabel.AutoSize = true;
            this.AddRatingLabel.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddRatingLabel.Location = new System.Drawing.Point(28, 313);
            this.AddRatingLabel.Name = "AddRatingLabel";
            this.AddRatingLabel.Size = new System.Drawing.Size(51, 21);
            this.AddRatingLabel.TabIndex = 9;
            this.AddRatingLabel.Text = "Rating:";
            // 
            // AddFeeLabel
            // 
            this.AddFeeLabel.AutoSize = true;
            this.AddFeeLabel.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddFeeLabel.Location = new System.Drawing.Point(28, 337);
            this.AddFeeLabel.Name = "AddFeeLabel";
            this.AddFeeLabel.Size = new System.Drawing.Size(32, 21);
            this.AddFeeLabel.TabIndex = 10;
            this.AddFeeLabel.Text = "Fee:";
            // 
            // AddMovieInput
            // 
            this.AddMovieInput.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddMovieInput.Location = new System.Drawing.Point(104, 228);
            this.AddMovieInput.Name = "AddMovieInput";
            this.AddMovieInput.Size = new System.Drawing.Size(271, 28);
            this.AddMovieInput.TabIndex = 11;
            // 
            // AddFeeBox
            // 
            this.AddFeeBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddFeeBox.Location = new System.Drawing.Point(104, 338);
            this.AddFeeBox.Name = "AddFeeBox";
            this.AddFeeBox.Size = new System.Drawing.Size(271, 23);
            this.AddFeeBox.TabIndex = 13;
            // 
            // AddRatingBox
            // 
            this.AddRatingBox.FormattingEnabled = true;
            this.AddRatingBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AddRatingBox.Location = new System.Drawing.Point(104, 313);
            this.AddRatingBox.Name = "AddRatingBox";
            this.AddRatingBox.Size = new System.Drawing.Size(271, 21);
            this.AddRatingBox.TabIndex = 14;
            // 
            // AddGenreBox
            // 
            this.AddGenreBox.FormattingEnabled = true;
            this.AddGenreBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Foreign",
            "Action"});
            this.AddGenreBox.Location = new System.Drawing.Point(104, 287);
            this.AddGenreBox.Name = "AddGenreBox";
            this.AddGenreBox.Size = new System.Drawing.Size(271, 21);
            this.AddGenreBox.TabIndex = 15;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.SearchButton.Location = new System.Drawing.Point(316, 188);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(58, 23);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddButton.Location = new System.Drawing.Point(195, 363);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(68, 25);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddID
            // 
            this.AddID.AutoSize = true;
            this.AddID.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddID.Location = new System.Drawing.Point(26, 260);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(66, 21);
            this.AddID.TabIndex = 18;
            this.AddID.Text = "Movie ID:";
            // 
            // AddIDInput
            // 
            this.AddIDInput.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.AddIDInput.Location = new System.Drawing.Point(104, 257);
            this.AddIDInput.Name = "AddIDInput";
            this.AddIDInput.Size = new System.Drawing.Size(271, 28);
            this.AddIDInput.TabIndex = 19;
            // 
            // SearchIDLabel
            // 
            this.SearchIDLabel.AutoSize = true;
            this.SearchIDLabel.Font = new System.Drawing.Font("Rockwell Condensed", 18F);
            this.SearchIDLabel.Location = new System.Drawing.Point(49, 149);
            this.SearchIDLabel.Name = "SearchIDLabel";
            this.SearchIDLabel.Size = new System.Drawing.Size(116, 29);
            this.SearchIDLabel.TabIndex = 20;
            this.SearchIDLabel.Text = "Search By ID";
            // 
            // SearchIDInput
            // 
            this.SearchIDInput.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.SearchIDInput.Location = new System.Drawing.Point(201, 150);
            this.SearchIDInput.Name = "SearchIDInput";
            this.SearchIDInput.Size = new System.Drawing.Size(292, 28);
            this.SearchIDInput.TabIndex = 21;
            // 
            // MovieName
            // 
            this.MovieName.AutoSize = true;
            this.MovieName.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.MovieName.Location = new System.Drawing.Point(426, 231);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(85, 21);
            this.MovieName.TabIndex = 22;
            this.MovieName.Text = "Movie Name:";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.Rating.Location = new System.Drawing.Point(426, 257);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(51, 21);
            this.Rating.TabIndex = 23;
            this.Rating.Text = "Rating:";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.Genre.Location = new System.Drawing.Point(426, 286);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(44, 21);
            this.Genre.TabIndex = 24;
            this.Genre.Text = "Genre:";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.ID.Location = new System.Drawing.Point(426, 313);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(66, 21);
            this.ID.TabIndex = 25;
            this.ID.Text = "Movie ID:";
            // 
            // Fee
            // 
            this.Fee.AutoSize = true;
            this.Fee.Font = new System.Drawing.Font("Rockwell Condensed", 13F);
            this.Fee.Location = new System.Drawing.Point(429, 337);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(32, 21);
            this.Fee.TabIndex = 26;
            this.Fee.Text = "Fee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 9F);
            this.label1.Location = new System.Drawing.Point(98, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 9F);
            this.label2.Location = new System.Drawing.Point(98, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "OR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.SearchIDInput);
            this.Controls.Add(this.SearchIDLabel);
            this.Controls.Add(this.AddIDInput);
            this.Controls.Add(this.AddID);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddGenreBox);
            this.Controls.Add(this.AddRatingBox);
            this.Controls.Add(this.AddFeeBox);
            this.Controls.Add(this.AddMovieInput);
            this.Controls.Add(this.AddFeeLabel);
            this.Controls.Add(this.AddRatingLabel);
            this.Controls.Add(this.AddGenreLabel);
            this.Controls.Add(this.AddMovieNameLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.GenreInput);
            this.Controls.Add(this.SearchGenreLabel);
            this.Controls.Add(this.MovieInput);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.SearchCheck);
            this.Controls.Add(this.AddCheck);
            this.Name = "MovieUI";
            this.Text = "MovieUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AddCheck;
        private System.Windows.Forms.CheckBox SearchCheck;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.TextBox MovieInput;
        private System.Windows.Forms.Label SearchGenreLabel;
        private System.Windows.Forms.TextBox GenreInput;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label AddMovieNameLabel;
        private System.Windows.Forms.Label AddGenreLabel;
        private System.Windows.Forms.Label AddRatingLabel;
        private System.Windows.Forms.Label AddFeeLabel;
        private System.Windows.Forms.TextBox AddMovieInput;
        private System.Windows.Forms.TextBox AddFeeBox;
        private System.Windows.Forms.ComboBox AddRatingBox;
        private System.Windows.Forms.ComboBox AddGenreBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AddID;
        private System.Windows.Forms.TextBox AddIDInput;
        private System.Windows.Forms.Label SearchIDLabel;
        private System.Windows.Forms.TextBox SearchIDInput;
        private System.Windows.Forms.Label MovieName;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

