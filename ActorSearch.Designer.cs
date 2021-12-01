
namespace CMPT_291_Project
{
	partial class ActorSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMPT_291_Project.ActorSearch));
            this.actorName = new System.Windows.Forms.Label();
            this.appearsIn = new System.Windows.Forms.Label();
            this.ratingBox = new System.Windows.Forms.ComboBox();
            this.ratingText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getInfo = new System.Windows.Forms.Button();
            this.moviesListStr = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.checkBoxAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxSearch = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.getActorName = new System.Windows.Forms.TextBox();
            this.getAgeLabel = new System.Windows.Forms.Label();
            this.getActorAge = new System.Windows.Forms.TextBox();
            this.actorIDLabel = new System.Windows.Forms.Label();
            this.getActorID = new System.Windows.Forms.TextBox();
            this.getAppearancesLabel = new System.Windows.Forms.Label();
            this.getAppearances = new System.Windows.Forms.TextBox();
            this.addActorButton = new System.Windows.Forms.Button();
            this.searchByIDButton = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // actorName
            // 
            this.actorName.AutoSize = true;
            this.actorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.actorName.Location = new System.Drawing.Point(31, 27);
            this.actorName.Name = "actorName";
            this.actorName.Size = new System.Drawing.Size(171, 31);
            this.actorName.TabIndex = 0;
            this.actorName.Text = "Actors Name";
            this.actorName.Visible = false;
            // 
            // appearsIn
            // 
            this.appearsIn.AutoSize = true;
            this.appearsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appearsIn.Location = new System.Drawing.Point(33, 85);
            this.appearsIn.Name = "appearsIn";
            this.appearsIn.Size = new System.Drawing.Size(93, 20);
            this.appearsIn.TabIndex = 2;
            this.appearsIn.Text = "Appears in: ";
            this.appearsIn.Visible = false;
            // 
            // ratingBox
            // 
            this.ratingBox.FormattingEnabled = true;
            this.ratingBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ratingBox.Location = new System.Drawing.Point(37, 157);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(121, 21);
            this.ratingBox.TabIndex = 3;
            this.ratingBox.Visible = false;
            this.ratingBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ratingText
            // 
            this.ratingText.AutoSize = true;
            this.ratingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ratingText.Location = new System.Drawing.Point(33, 124);
            this.ratingText.Name = "ratingText";
            this.ratingText.Size = new System.Drawing.Size(97, 20);
            this.ratingText.TabIndex = 5;
            this.ratingText.Text = "Rating (1-5):";
            this.ratingText.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 296);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // getNameBox
            // 
            this.getNameBox.Location = new System.Drawing.Point(37, 366);
            this.getNameBox.Name = "getNameBox";
            this.getNameBox.Size = new System.Drawing.Size(305, 20);
            this.getNameBox.TabIndex = 8;
            this.getNameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "FOR TESTING, ENTER ACTOR NAME HERE";
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(37, 392);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(111, 23);
            this.getInfo.TabIndex = 11;
            this.getInfo.Text = "Search by Name";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.getInfo_Click_1);
            // 
            // moviesListStr
            // 
            this.moviesListStr.AutoSize = true;
            this.moviesListStr.Location = new System.Drawing.Point(121, 90);
            this.moviesListStr.Name = "moviesListStr";
            this.moviesListStr.Size = new System.Drawing.Size(156, 13);
            this.moviesListStr.TabIndex = 12;
            this.moviesListStr.Text = "Spider-Man, Anti-Christ, Platoon";
            this.moviesListStr.Visible = false;
            // 
            // modeText
            // 
            this.modeText.AutoSize = true;
            this.modeText.Location = new System.Drawing.Point(417, 44);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(37, 13);
            this.modeText.TabIndex = 13;
            this.modeText.Text = "Mode:";
            // 
            // checkBoxAdd
            // 
            this.checkBoxAdd.AutoSize = true;
            this.checkBoxAdd.Location = new System.Drawing.Point(478, 43);
            this.checkBoxAdd.Name = "checkBoxAdd";
            this.checkBoxAdd.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAdd.TabIndex = 15;
            this.checkBoxAdd.Text = "Add Actor";
            this.checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            this.checkBoxSearch.AutoSize = true;
            this.checkBoxSearch.Location = new System.Drawing.Point(558, 44);
            this.checkBoxSearch.Name = "checkBoxSearch";
            this.checkBoxSearch.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSearch.TabIndex = 16;
            this.checkBoxSearch.Text = "Search Actor";
            this.checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(689, 37);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterNameLabel.Location = new System.Drawing.Point(33, 105);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(140, 20);
            this.enterNameLabel.TabIndex = 18;
            this.enterNameLabel.Text = "Enter Actor Name:";
            this.enterNameLabel.Visible = false;
            // 
            // getActorName
            // 
            this.getActorName.Location = new System.Drawing.Point(237, 107);
            this.getActorName.Name = "getActorName";
            this.getActorName.Size = new System.Drawing.Size(217, 20);
            this.getActorName.TabIndex = 19;
            this.getActorName.Visible = false;
            // 
            // getAgeLabel
            // 
            this.getAgeLabel.AutoSize = true;
            this.getAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.getAgeLabel.Location = new System.Drawing.Point(33, 131);
            this.getAgeLabel.Name = "getAgeLabel";
            this.getAgeLabel.Size = new System.Drawing.Size(127, 20);
            this.getAgeLabel.TabIndex = 20;
            this.getAgeLabel.Text = "Enter Actor Age:";
            this.getAgeLabel.Visible = false;
            // 
            // getActorAge
            // 
            this.getActorAge.Location = new System.Drawing.Point(237, 133);
            this.getActorAge.Name = "getActorAge";
            this.getActorAge.Size = new System.Drawing.Size(217, 20);
            this.getActorAge.TabIndex = 21;
            this.getActorAge.Visible = false;
            // 
            // actorIDLabel
            // 
            this.actorIDLabel.AutoSize = true;
            this.actorIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.actorIDLabel.Location = new System.Drawing.Point(33, 158);
            this.actorIDLabel.Name = "actorIDLabel";
            this.actorIDLabel.Size = new System.Drawing.Size(115, 20);
            this.actorIDLabel.TabIndex = 22;
            this.actorIDLabel.Text = "Enter Actor ID:";
            this.actorIDLabel.Visible = false;
            // 
            // getActorID
            // 
            this.getActorID.Location = new System.Drawing.Point(237, 157);
            this.getActorID.Name = "getActorID";
            this.getActorID.Size = new System.Drawing.Size(217, 20);
            this.getActorID.TabIndex = 23;
            this.getActorID.Visible = false;
            // 
            // getAppearancesLabel
            // 
            this.getAppearancesLabel.AutoSize = true;
            this.getAppearancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.getAppearancesLabel.Location = new System.Drawing.Point(33, 184);
            this.getAppearancesLabel.Name = "getAppearancesLabel";
            this.getAppearancesLabel.Size = new System.Drawing.Size(193, 20);
            this.getAppearancesLabel.TabIndex = 24;
            this.getAppearancesLabel.Text = "Enter Actor Appearances:";
            this.getAppearancesLabel.Visible = false;
            // 
            // getAppearances
            // 
            this.getAppearances.Location = new System.Drawing.Point(237, 184);
            this.getAppearances.Name = "getAppearances";
            this.getAppearances.Size = new System.Drawing.Size(217, 20);
            this.getAppearances.TabIndex = 25;
            this.getAppearances.Visible = false;
            // 
            // addActorButton
            // 
            this.addActorButton.Location = new System.Drawing.Point(37, 224);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(75, 23);
            this.addActorButton.TabIndex = 26;
            this.addActorButton.Text = "Add Actor";
            this.addActorButton.UseVisualStyleBackColor = true;
            this.addActorButton.Visible = false;
            this.addActorButton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // searchByIDButton
            // 
            this.searchByIDButton.Location = new System.Drawing.Point(152, 392);
            this.searchByIDButton.Name = "searchByIDButton";
            this.searchByIDButton.Size = new System.Drawing.Size(111, 23);
            this.searchByIDButton.TabIndex = 27;
            this.searchByIDButton.Text = "Search by ID";
            this.searchByIDButton.UseVisualStyleBackColor = true;
            this.searchByIDButton.Visible = false;
            this.searchByIDButton.Click += new System.EventHandler(this.searchByIDButton_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(713, 415);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBtn.TabIndex = 28;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.searchByIDButton);
            this.Controls.Add(this.addActorButton);
            this.Controls.Add(this.getAppearances);
            this.Controls.Add(this.getAppearancesLabel);
            this.Controls.Add(this.getActorID);
            this.Controls.Add(this.actorIDLabel);
            this.Controls.Add(this.getActorAge);
            this.Controls.Add(this.getAgeLabel);
            this.Controls.Add(this.getActorName);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.checkBoxSearch);
            this.Controls.Add(this.checkBoxAdd);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.moviesListStr);
            this.Controls.Add(this.getInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getNameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ratingText);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.appearsIn);
            this.Controls.Add(this.actorName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label actorName;
		private System.Windows.Forms.Label appearsIn;
		private System.Windows.Forms.ComboBox ratingBox;
		private System.Windows.Forms.Label ratingText;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox getNameBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button getInfo;
		private System.Windows.Forms.Label moviesListStr;
		private System.Windows.Forms.Label modeText;
		private System.Windows.Forms.CheckBox checkBoxAdd;
		private System.Windows.Forms.CheckBox checkBoxSearch;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label enterNameLabel;
		private System.Windows.Forms.TextBox getActorName;
		private System.Windows.Forms.Label getAgeLabel;
		private System.Windows.Forms.TextBox getActorAge;
		private System.Windows.Forms.Label actorIDLabel;
		private System.Windows.Forms.TextBox getActorID;
		private System.Windows.Forms.Label getAppearancesLabel;
		private System.Windows.Forms.TextBox getAppearances;
		private System.Windows.Forms.Button addActorButton;
		private System.Windows.Forms.Button searchByIDButton;
        private System.Windows.Forms.Button returnBtn;
    }
}

