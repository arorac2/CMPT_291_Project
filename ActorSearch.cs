using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace CMPT_291_Project
{
	public partial class ActorSearch : Form
	{
        protected List<Actor> actorSet = new List<Actor>();

		public ActorSearch()
		{
			
			InitializeComponent();
			HideAll();
		}

		public class Actor
		{
            // INITIALIZE ACTOR CHARACTERISTICS
            public string Name { get; set; }
			public int Age { get; set; }
			public int ID { get; set; }
			public string Appearances { get; set; }

			// CONSTRUCTOR METHOD TO CREATE ACTOR OBJECT. EX. var Michael = new Actor("Michael", "22", 001, "Movie Name")
			public Actor(string Name, int Age, int ID, string Appearances)
			{
				this.Name = Name;
				this.Age = Age;
				this.ID = ID;
				this.Appearances = Appearances;
			}

			public override string ToString()
			{
				return "Name: " + Name + " Age: " + Age + " ID: " + ID + " Appears in: " + Appearances;

			}
		}

		public class ActorSet
		{
			// INITILIZE LIST OF ACTOR OBJECTS
			protected List<Actor> actorList { get; set; }

			// CREATE OBJECT
			public ActorSet()
			{
				actorList = new List<Actor>();	
			}

			// METHOD TO ADD ACTOR TO ACTOR LIST
			public void insert(Actor actor)
			{
				actorList.Add(actor);
			}

           
        }

		
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

	
		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}


		private void getInfo_Click_1(object sender, EventArgs e)
		{
			actorName.Text = "Actor Not Found";
			actorName.Visible = true;
			

			foreach (Actor a in actorSet)
            {
				if (a.Name.Equals(getNameBox.Text)) 
				{ 

					actorName.Visible = true;
					ratingText.Visible = true;
					ratingBox.Visible = true;
					appearsIn.Visible = true;
					moviesListStr.Visible = true;
					actorName.Visible = true;
					pictureBox1.Visible = true;

					actorName.Text = a.Name;
					moviesListStr.Text = a.Appearances; 

                }
            }

			getNameBox.Text = "";


		}


		private void HideAll()
		{
			actorName.Visible = false;
			ratingText.Visible = false;
			ratingBox.Visible = false;
			appearsIn.Visible = false;
			moviesListStr.Visible = false;
			actorName.Visible = false;
			pictureBox1.Visible = false;
			label4.Visible = false;
			getNameBox.Visible = false;
			getInfo.Visible = false;
			enterNameLabel.Visible = false;
			getActorName.Visible = false;
			getAgeLabel.Visible = false;
			getActorAge.Visible = false;
			actorIDLabel.Visible = false;
			getActorID.Visible = false;
			getAppearancesLabel.Visible = false;
			getAppearances.Visible = false;
			addActorButton.Visible = false;
			searchByIDButton.Visible = false;


		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			if (checkBoxAdd.Checked) 
			{
				HideAll();
				actorName.Text = "Add an Actor";
				actorName.Visible = true;
				enterNameLabel.Visible = true;
				getActorName.Visible = true;
				getAgeLabel.Visible = true;
				getActorAge.Visible = true;
				actorIDLabel.Visible = true;
				getActorID.Visible = true;
				getAppearancesLabel.Visible = true;
				getAppearances.Visible = true;
				addActorButton.Visible = true;
			}
			

			if (checkBoxSearch.Checked)
			{
				HideAll();
				label4.Visible = true;
				getNameBox.Visible = true;
				getInfo.Visible = true;
				searchByIDButton.Visible = true;
			}

			if (!checkBoxAdd.Checked & !checkBoxSearch.Checked)
			{
				HideAll();
			}
		}

		private void addActorButton_Click(object sender, EventArgs e)
		{
			var currentActor = new Actor(getActorName.Text, Int32.Parse(getActorAge.Text), Int32.Parse(getActorID.Text), getAppearances.Text);
			actorSet.Add(currentActor);
			Console.WriteLine(currentActor);
			getActorName.Text = "";
			getActorAge.Text = "";
			getActorID.Text = "";
			getAppearances.Text = "";
			Console.WriteLine("test");
			
		}

        private void searchByIDButton_Click(object sender, EventArgs e)
		{
			actorName.Text = "Actor Not Found";
			actorName.Visible = true;


			foreach (Actor a in actorSet)
			{
				if (a.ID.Equals(Int32.Parse(getNameBox.Text)))
				{

					actorName.Visible = true;
					ratingText.Visible = true;
					ratingBox.Visible = true;
					appearsIn.Visible = true;
					moviesListStr.Visible = true;
					actorName.Visible = true;
					pictureBox1.Visible = true;

					actorName.Text = a.Name;
					moviesListStr.Text = a.Appearances;

				}
			}

			getNameBox.Text = "";
		}

        private void returnBtn_Click(object sender, EventArgs e)
        {
			this.Hide();
			UserAndEmployee2 main = new UserAndEmployee2();
			main.Show();
        }
    }
}
