using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CMPT_291_Project
{
	public partial class ActorSearch : Form

	{
		public SqlConnection myConnection;
		public SqlCommand myCommand;
		public SqlDataReader myReader;
		protected List<Actor> actorSet = new List<Actor>();

		public ActorSearch()
		{
			
			InitializeComponent();
			HideAll();

			String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            System.Data.SqlClient.SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

			try
			{
				myConnection.Open(); // Open connection
				myCommand = new SqlCommand();
				myCommand.Connection = myConnection; // Link the command stream to the connection
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString(), "Error");
				this.Close();
			}
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
			myCommand.CommandText = "select * from actors where name like '%"+getNameBox.Text+"%'";
			try
			{
				myReader = myCommand.ExecuteReader();

				actorGrid.Rows.Clear();
				while (myReader.Read())
				{
					actorGrid.Rows.Add(myReader["id"].ToString(), myReader["name"].ToString(), myReader["age"].ToString());
				}
				myReader.Close();

				getActorName.Text = "";
				getActorAge.Text = "";
				getActorID.Text = "";
				getAppearances.Text = "";

				myCommand.ExecuteNonQuery();
			}
			catch (Exception e2)
			{


				MessageBox.Show(e2.ToString(), "Error");
			}


		}


		private void HideAll()
		{
			actorName.Visible = false;
			ratingText.Visible = false;
			ratingBox.Visible = false;
			appearsIn.Visible = false;
			moviesListStr.Visible = false;
			actorName.Visible = false;
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
			/*
			var currentActor = new Actor(getActorName.Text, Int32.Parse(getActorAge.Text), Int32.Parse(getActorID.Text), getAppearances.Text);
			actorSet.Add(currentActor);
			Console.WriteLine(currentActor);
			getActorName.Text = "";
			getActorAge.Text = "";
			getActorID.Text = "";
			getAppearances.Text = "";
			Console.WriteLine("test");
			*/
			try
			{
				

				myCommand.CommandText = "SET IDENTITY_INSERT [dbo].[actors] ON insert into [dbo].[actors] ( [age], [name], [id] ) values (" + getActorID.Text + ",'" + getActorName.Text + "'," + getActorAge.Text + ")";
				MessageBox.Show(myCommand.CommandText);

				getActorName.Text = "";
				getActorAge.Text = "";
				getActorID.Text = "";
				getAppearances.Text = "";

				myCommand.ExecuteNonQuery();
			}
			catch (Exception e2)
			{


				MessageBox.Show(e2.ToString(), "Error");
			}

		}

        private void searchByIDButton_Click(object sender, EventArgs e)
		{
			myCommand.CommandText = "select * from actors";
			try
			{
				myReader = myCommand.ExecuteReader();

				actorGrid.Rows.Clear();
				while (myReader.Read())
                {
					actorGrid.Rows.Add(myReader["id"].ToString(), myReader["name"].ToString(), myReader["age"].ToString());
                }
				myReader.Close();

				getActorName.Text = "";
				getActorAge.Text = "";
				getActorID.Text = "";
				getAppearances.Text = "";

				myCommand.ExecuteNonQuery();
			}
			catch (Exception e2)
			{


				MessageBox.Show(e2.ToString(), "Error");
			}



		}




        private void returnBtn_Click(object sender, EventArgs e)
        {
			this.Hide();
			UserAndEmployee2 main = new UserAndEmployee2();
			main.Show();
        }
    }
}
