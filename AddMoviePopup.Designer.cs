
namespace CMPT_291_Project
{
    partial class AddMoviePopup
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
            this.addMovieTitleLabel = new System.Windows.Forms.Label();
            this.addMovieGenreLabel = new System.Windows.Forms.Label();
            this.addMovieCopiesLabel = new System.Windows.Forms.Label();
            this.addMovieTitleTextbox = new System.Windows.Forms.TextBox();
            this.addMovieCopiesInput = new System.Windows.Forms.NumericUpDown();
            this.addMovieGenreDropdown = new System.Windows.Forms.ComboBox();
            this.addMoviePopupAddBtn = new System.Windows.Forms.Button();
            this.addMoviePopupCancelBtn = new System.Windows.Forms.Button();
            this.addMoviePopupStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addMovieCopiesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieTitleLabel
            // 
            this.addMovieTitleLabel.AutoSize = true;
            this.addMovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieTitleLabel.Location = new System.Drawing.Point(90, 66);
            this.addMovieTitleLabel.Name = "addMovieTitleLabel";
            this.addMovieTitleLabel.Size = new System.Drawing.Size(59, 25);
            this.addMovieTitleLabel.TabIndex = 0;
            this.addMovieTitleLabel.Text = "Title:";
            // 
            // addMovieGenreLabel
            // 
            this.addMovieGenreLabel.AutoSize = true;
            this.addMovieGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieGenreLabel.Location = new System.Drawing.Point(90, 124);
            this.addMovieGenreLabel.Name = "addMovieGenreLabel";
            this.addMovieGenreLabel.Size = new System.Drawing.Size(77, 25);
            this.addMovieGenreLabel.TabIndex = 1;
            this.addMovieGenreLabel.Text = "Genre:";
            this.addMovieGenreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addMovieCopiesLabel
            // 
            this.addMovieCopiesLabel.AutoSize = true;
            this.addMovieCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieCopiesLabel.Location = new System.Drawing.Point(90, 182);
            this.addMovieCopiesLabel.Name = "addMovieCopiesLabel";
            this.addMovieCopiesLabel.Size = new System.Drawing.Size(85, 25);
            this.addMovieCopiesLabel.TabIndex = 2;
            this.addMovieCopiesLabel.Text = "Copies:";
            // 
            // addMovieTitleTextbox
            // 
            this.addMovieTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieTitleTextbox.Location = new System.Drawing.Point(190, 65);
            this.addMovieTitleTextbox.Name = "addMovieTitleTextbox";
            this.addMovieTitleTextbox.Size = new System.Drawing.Size(340, 26);
            this.addMovieTitleTextbox.TabIndex = 3;
            // 
            // addMovieCopiesInput
            // 
            this.addMovieCopiesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieCopiesInput.Location = new System.Drawing.Point(190, 182);
            this.addMovieCopiesInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addMovieCopiesInput.Name = "addMovieCopiesInput";
            this.addMovieCopiesInput.Size = new System.Drawing.Size(120, 26);
            this.addMovieCopiesInput.TabIndex = 4;
            this.addMovieCopiesInput.ThousandsSeparator = true;
            // 
            // addMovieGenreDropdown
            // 
            this.addMovieGenreDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieGenreDropdown.FormattingEnabled = true;
            this.addMovieGenreDropdown.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Foreign"});
            this.addMovieGenreDropdown.Location = new System.Drawing.Point(190, 121);
            this.addMovieGenreDropdown.Name = "addMovieGenreDropdown";
            this.addMovieGenreDropdown.Size = new System.Drawing.Size(173, 28);
            this.addMovieGenreDropdown.TabIndex = 5;
            // 
            // addMoviePopupAddBtn
            // 
            this.addMoviePopupAddBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addMoviePopupAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoviePopupAddBtn.Location = new System.Drawing.Point(190, 240);
            this.addMoviePopupAddBtn.Name = "addMoviePopupAddBtn";
            this.addMoviePopupAddBtn.Size = new System.Drawing.Size(127, 34);
            this.addMoviePopupAddBtn.TabIndex = 6;
            this.addMoviePopupAddBtn.Text = "Add movie";
            this.addMoviePopupAddBtn.UseVisualStyleBackColor = true;
            this.addMoviePopupAddBtn.Click += new System.EventHandler(this.addMoviePopupAddBtn_Click);
            // 
            // addMoviePopupCancelBtn
            // 
            this.addMoviePopupCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addMoviePopupCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoviePopupCancelBtn.Location = new System.Drawing.Point(323, 240);
            this.addMoviePopupCancelBtn.Name = "addMoviePopupCancelBtn";
            this.addMoviePopupCancelBtn.Size = new System.Drawing.Size(127, 34);
            this.addMoviePopupCancelBtn.TabIndex = 7;
            this.addMoviePopupCancelBtn.Text = "Cancel";
            this.addMoviePopupCancelBtn.UseVisualStyleBackColor = true;
            // 
            // addMoviePopupStatusLabel
            // 
            this.addMoviePopupStatusLabel.AutoSize = true;
            this.addMoviePopupStatusLabel.BackColor = System.Drawing.Color.Red;
            this.addMoviePopupStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoviePopupStatusLabel.Location = new System.Drawing.Point(155, 9);
            this.addMoviePopupStatusLabel.Name = "addMoviePopupStatusLabel";
            this.addMoviePopupStatusLabel.Size = new System.Drawing.Size(0, 24);
            this.addMoviePopupStatusLabel.TabIndex = 8;
            // 
            // AddMoviePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 286);
            this.Controls.Add(this.addMoviePopupStatusLabel);
            this.Controls.Add(this.addMoviePopupCancelBtn);
            this.Controls.Add(this.addMoviePopupAddBtn);
            this.Controls.Add(this.addMovieGenreDropdown);
            this.Controls.Add(this.addMovieCopiesInput);
            this.Controls.Add(this.addMovieTitleTextbox);
            this.Controls.Add(this.addMovieCopiesLabel);
            this.Controls.Add(this.addMovieGenreLabel);
            this.Controls.Add(this.addMovieTitleLabel);
            this.Name = "AddMoviePopup";
            this.Text = "Add a Movie";
            this.Load += new System.EventHandler(this.AddMoviePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addMovieCopiesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addMovieTitleLabel;
        private System.Windows.Forms.Label addMovieGenreLabel;
        private System.Windows.Forms.Label addMovieCopiesLabel;
        private System.Windows.Forms.TextBox addMovieTitleTextbox;
        private System.Windows.Forms.NumericUpDown addMovieCopiesInput;
        private System.Windows.Forms.ComboBox addMovieGenreDropdown;
        private System.Windows.Forms.Button addMoviePopupAddBtn;
        private System.Windows.Forms.Button addMoviePopupCancelBtn;
        private System.Windows.Forms.Label addMoviePopupStatusLabel;
    }
}