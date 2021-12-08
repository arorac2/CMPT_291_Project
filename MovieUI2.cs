using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CMPT_291_Project
{
    public partial class MovieUI2 : Form
    {



        protected List<Movie> movieSet = new List<Movie>(); //movies get added to this list here
        List<string> movieID = new List<string>();  //this should contain the indexes of the row correlating it to the movie ID


        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;


        public MovieUI2()
        {
            InitializeComponent();
            labelnot.Visible = false;
            dataGridView1.ReadOnly = true;
            dropDown.Items.Add("Show All");
            comboBox1.Items.Add("Comedy");
            comboBox1.Items.Add("Action");
            comboBox1.Items.Add("Drama");
            comboBox1.Items.Add("Foreign");


            string connectionString = "Server = AURORA; Database = MovieRental; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

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


        public class Movie
        {


            // Initialize the movie descriptions
            public string Name { get; set; }
            public int ID { get; set; }
            public string Genre { get; set; } // Comedy, Drama, Action or Foreign 
            public int Fee { get; set; }
            public int Rating { get; set; }  // 1 - 5

            public Movie(int ID, String Name, String Genre, int Rating, int Fee)
            {
                this.Name = Name;
                this.ID = ID;
                this.Fee = Fee;
                this.Genre = Genre;
                this.Rating = Rating;

            }


            public class MovieSet
            {
                // INITILIZE LIST OF Movie Obj
                protected List<Movie> movieList { get; set; }

                // CREATE OBJECT
                public MovieSet()
                {
                    movieList = new List<Movie>();
                }

                //add movies to movie list 



            }

        }



        private void Search_Click(object sender, EventArgs e)
        {


            if (dropDown.Text == "Show All")
            {
                myCommand.CommandText = "select * from movies";
            }


            else
            {
                myCommand.CommandText = "SELECT * from movies where title =" + "'" + dropDown.Text + "'"; // stores the query + searches through user input to see if input exists in database. 
            }


            try
            {
                // MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader(); //reads bytes gets the sql printout execute the commandtext

                dataGridView1.Rows.Clear();
                while (myReader.Read()) //runs till eof myReader contains a dictionary formatted  thing so essentially the dictionary looking for the value of the key
                {
                    //
                    // MessageBox.Show(myReader["genre"].ToString());
                    // MessageBox.Show(myReader["copies_in_stock"].ToString());
                    dataGridView1.Rows.Add(myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString(), myReader["id"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            if (dataGridView1.Rows.Count == 1)
            {
                labelnot.Visible = true;
                labelnot.Update();
            }

            else
            {
                labelnot.Visible = false;
            }
        }



        private void SearchGenre_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Comedy")
                myCommand.CommandText = "SELECT * FROM movies WHERE genre = 'Comedy'";


            if (comboBox1.Text == "Action")
                myCommand.CommandText = "SELECT * FROM movies WHERE genre = 'Action'";

            if (comboBox1.Text == "Drama")
                myCommand.CommandText = "SELECT * FROM movies WHERE genre = 'Drama'";

            if (comboBox1.Text == "Foreign")
                myCommand.CommandText = "SELECT * FROM movies WHERE genre = 'Foreign'";


            try
            {
                // MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader(); //reads bytes gets the sql printout

                dataGridView1.Rows.Clear();
                while (myReader.Read())
                {/*
                    MessageBox.Show(myReader["title"].ToString());
                    MessageBox.Show(myReader["genre"].ToString());
                    MessageBox.Show(myReader["copies_in_stock"].ToString());*/

                    dataGridView1.Rows.Add(myReader["title"].ToString(), myReader["genre"].ToString(), myReader["copies_in_stock"].ToString(), myReader["id"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when user enters my UI the DATAGRIDVIEW should automatically show all in the table 
           


        }

    

        private void AddButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];  //indexing through the rows 

            if (selectedRow.Cells[3].Value != null)  //if the id is not null
            {
                textBox1.Text = selectedRow.Cells[3].Value.ToString();  //then sh
                myCommand.CommandText = "select * from movies where title = " + selectedRow.Cells[3].Value.ToString(); //where it equals to the movie name?
                MessageBox.Show(myCommand.CommandText);

                try
                {
                   // MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();
                    dataGridView1.Rows.Clear();

                    while (myReader.Read())
                    {
                        textBox1.Text = myReader["id"].ToString();
                        dataGridView1.Rows.Add(myReader["title"].ToString(), myReader["id"].ToString());
                        MessageBox.Show(myCommand.CommandText);

                    }

                    myReader.Close();
                }

                catch
                {
                    return;
                    //MessageBox.Show(e3.ToString(), "Error");
                }


            }

            else { return; }
        }
    }
}






