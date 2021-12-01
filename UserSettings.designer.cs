namespace CMPT_291_Project
{
    partial class UserSettings
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
            this.settingsLabel = new System.Windows.Forms.Label();
            this.myActivityLabel = new System.Windows.Forms.Label();
            this.recentActivityControl = new System.Windows.Forms.TabControl();
            this.recentlyWatchedTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.watchedDateViewedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.watchedMovieColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.watchedUserRatingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.watchedAvgUserRatingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieRatingsTab = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.movieRatingTitleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieRatingRatingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actorRatingsTab = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.actorRatingActorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actorRatingRatingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paymentSectionLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.creditCardNoLabel = new System.Windows.Forms.Label();
            this.currentPlanLabel = new System.Windows.Forms.Label();
            this.paymentCardTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.planSelectDropdown = new System.Windows.Forms.ComboBox();
            this.updatePaymentButton = new System.Windows.Forms.Button();
            this.updateStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.recentActivityControl.SuspendLayout();
            this.recentlyWatchedTab.SuspendLayout();
            this.movieRatingsTab.SuspendLayout();
            this.actorRatingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(5, 18);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(190, 39);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "⚙️ Settings";
            this.settingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // myActivityLabel
            // 
            this.myActivityLabel.AutoSize = true;
            this.myActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myActivityLabel.Location = new System.Drawing.Point(50, 252);
            this.myActivityLabel.Name = "myActivityLabel";
            this.myActivityLabel.Size = new System.Drawing.Size(145, 31);
            this.myActivityLabel.TabIndex = 6;
            this.myActivityLabel.Text = "My Activity";
            // 
            // recentActivityControl
            // 
            this.recentActivityControl.Controls.Add(this.recentlyWatchedTab);
            this.recentActivityControl.Controls.Add(this.movieRatingsTab);
            this.recentActivityControl.Controls.Add(this.actorRatingsTab);
            this.recentActivityControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentActivityControl.Location = new System.Drawing.Point(56, 286);
            this.recentActivityControl.Name = "recentActivityControl";
            this.recentActivityControl.SelectedIndex = 0;
            this.recentActivityControl.Size = new System.Drawing.Size(506, 273);
            this.recentActivityControl.TabIndex = 9;
            // 
            // recentlyWatchedTab
            // 
            this.recentlyWatchedTab.Controls.Add(this.listView1);
            this.recentlyWatchedTab.Location = new System.Drawing.Point(4, 33);
            this.recentlyWatchedTab.Name = "recentlyWatchedTab";
            this.recentlyWatchedTab.Padding = new System.Windows.Forms.Padding(3);
            this.recentlyWatchedTab.Size = new System.Drawing.Size(498, 236);
            this.recentlyWatchedTab.TabIndex = 0;
            this.recentlyWatchedTab.Text = "Recently Watched";
            this.recentlyWatchedTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.watchedDateViewedColumn,
            this.watchedMovieColumn,
            this.watchedUserRatingHeader,
            this.watchedAvgUserRatingHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 230);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // watchedDateViewedColumn
            // 
            this.watchedDateViewedColumn.Text = "Viewed";
            this.watchedDateViewedColumn.Width = 100;
            // 
            // watchedMovieColumn
            // 
            this.watchedMovieColumn.Text = "Title";
            this.watchedMovieColumn.Width = 179;
            // 
            // watchedUserRatingHeader
            // 
            this.watchedUserRatingHeader.Text = "My Rating";
            this.watchedUserRatingHeader.Width = 100;
            // 
            // watchedAvgUserRatingHeader
            // 
            this.watchedAvgUserRatingHeader.Text = "User Rating";
            this.watchedAvgUserRatingHeader.Width = 109;
            // 
            // movieRatingsTab
            // 
            this.movieRatingsTab.Controls.Add(this.listView2);
            this.movieRatingsTab.Location = new System.Drawing.Point(4, 33);
            this.movieRatingsTab.Name = "movieRatingsTab";
            this.movieRatingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.movieRatingsTab.Size = new System.Drawing.Size(498, 236);
            this.movieRatingsTab.TabIndex = 1;
            this.movieRatingsTab.Text = "My Movie Ratings";
            this.movieRatingsTab.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieRatingTitleHeader,
            this.movieRatingRatingHeader});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(492, 230);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // movieRatingTitleHeader
            // 
            this.movieRatingTitleHeader.Text = "Title";
            this.movieRatingTitleHeader.Width = 150;
            // 
            // movieRatingRatingHeader
            // 
            this.movieRatingRatingHeader.Text = "Rating";
            this.movieRatingRatingHeader.Width = 100;
            // 
            // actorRatingsTab
            // 
            this.actorRatingsTab.Controls.Add(this.listView3);
            this.actorRatingsTab.Location = new System.Drawing.Point(4, 33);
            this.actorRatingsTab.Name = "actorRatingsTab";
            this.actorRatingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.actorRatingsTab.Size = new System.Drawing.Size(498, 236);
            this.actorRatingsTab.TabIndex = 2;
            this.actorRatingsTab.Text = "My Actor Ratings";
            this.actorRatingsTab.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.actorRatingActorHeader,
            this.actorRatingRatingHeader});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(492, 230);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // actorRatingActorHeader
            // 
            this.actorRatingActorHeader.Text = "Actor";
            this.actorRatingActorHeader.Width = 150;
            // 
            // actorRatingRatingHeader
            // 
            this.actorRatingRatingHeader.Text = "Rating";
            this.actorRatingRatingHeader.Width = 100;
            // 
            // paymentSectionLabel
            // 
            this.paymentSectionLabel.AutoSize = true;
            this.paymentSectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentSectionLabel.Location = new System.Drawing.Point(54, 66);
            this.paymentSectionLabel.Name = "paymentSectionLabel";
            this.paymentSectionLabel.Size = new System.Drawing.Size(264, 31);
            this.paymentSectionLabel.TabIndex = 10;
            this.paymentSectionLabel.Text = "Payment Information";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(56, 109);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(94, 20);
            this.firstNameLabel.TabIndex = 11;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(56, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // creditCardNoLabel
            // 
            this.creditCardNoLabel.AutoSize = true;
            this.creditCardNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardNoLabel.Location = new System.Drawing.Point(56, 157);
            this.creditCardNoLabel.Name = "creditCardNoLabel";
            this.creditCardNoLabel.Size = new System.Drawing.Size(117, 20);
            this.creditCardNoLabel.TabIndex = 13;
            this.creditCardNoLabel.Text = "Payment Card: ";
            this.creditCardNoLabel.Click += new System.EventHandler(this.creditCardNoLabel_Click);
            // 
            // currentPlanLabel
            // 
            this.currentPlanLabel.AutoSize = true;
            this.currentPlanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlanLabel.Location = new System.Drawing.Point(56, 181);
            this.currentPlanLabel.Name = "currentPlanLabel";
            this.currentPlanLabel.Size = new System.Drawing.Size(48, 20);
            this.currentPlanLabel.TabIndex = 14;
            this.currentPlanLabel.Text = "Plan: ";
            // 
            // paymentCardTextBox
            // 
            this.paymentCardTextBox.Location = new System.Drawing.Point(179, 157);
            this.paymentCardTextBox.Name = "paymentCardTextBox";
            this.paymentCardTextBox.Size = new System.Drawing.Size(139, 20);
            this.paymentCardTextBox.TabIndex = 15;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 133);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.lastNameTextBox.TabIndex = 16;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 109);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // planSelectDropdown
            // 
            this.planSelectDropdown.FormattingEnabled = true;
            this.planSelectDropdown.Items.AddRange(new object[] {
            "One Movie",
            "Two Movies",
            "Three Movies",
            "Unlimited Movies"});
            this.planSelectDropdown.Location = new System.Drawing.Point(179, 180);
            this.planSelectDropdown.Name = "planSelectDropdown";
            this.planSelectDropdown.Size = new System.Drawing.Size(139, 21);
            this.planSelectDropdown.TabIndex = 18;
            // 
            // updatePaymentButton
            // 
            this.updatePaymentButton.Location = new System.Drawing.Point(56, 204);
            this.updatePaymentButton.Name = "updatePaymentButton";
            this.updatePaymentButton.Size = new System.Drawing.Size(94, 23);
            this.updatePaymentButton.TabIndex = 19;
            this.updatePaymentButton.Text = "Update";
            this.updatePaymentButton.UseVisualStyleBackColor = true;
            this.updatePaymentButton.Click += new System.EventHandler(this.updatePaymentButton_Click);
            // 
            // updateStatusLabel
            // 
            this.updateStatusLabel.AutoSize = true;
            this.updateStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.updateStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStatusLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.updateStatusLabel.Location = new System.Drawing.Point(406, 18);
            this.updateStatusLabel.Name = "updateStatusLabel";
            this.updateStatusLabel.Size = new System.Drawing.Size(0, 24);
            this.updateStatusLabel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1005, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateStatusLabel);
            this.Controls.Add(this.updatePaymentButton);
            this.Controls.Add(this.planSelectDropdown);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.paymentCardTextBox);
            this.Controls.Add(this.currentPlanLabel);
            this.Controls.Add(this.creditCardNoLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.paymentSectionLabel);
            this.Controls.Add(this.recentActivityControl);
            this.Controls.Add(this.myActivityLabel);
            this.Controls.Add(this.settingsLabel);
            this.Name = "UserSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.UserSettings_Load);
            this.recentActivityControl.ResumeLayout(false);
            this.recentlyWatchedTab.ResumeLayout(false);
            this.movieRatingsTab.ResumeLayout(false);
            this.actorRatingsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label myActivityLabel;
        private System.Windows.Forms.TabControl recentActivityControl;
        private System.Windows.Forms.TabPage recentlyWatchedTab;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader watchedMovieColumn;
        private System.Windows.Forms.ColumnHeader watchedDateViewedColumn;
        private System.Windows.Forms.ColumnHeader watchedUserRatingHeader;
        private System.Windows.Forms.ColumnHeader watchedAvgUserRatingHeader;
        private System.Windows.Forms.TabPage movieRatingsTab;
        private System.Windows.Forms.TabPage actorRatingsTab;
        private System.Windows.Forms.Label paymentSectionLabel;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader movieRatingTitleHeader;
        private System.Windows.Forms.ColumnHeader movieRatingRatingHeader;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader actorRatingActorHeader;
        private System.Windows.Forms.ColumnHeader actorRatingRatingHeader;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label creditCardNoLabel;
        private System.Windows.Forms.Label currentPlanLabel;
        private System.Windows.Forms.TextBox paymentCardTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox planSelectDropdown;
        private System.Windows.Forms.Button updatePaymentButton;
        private System.Windows.Forms.Label updateStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

