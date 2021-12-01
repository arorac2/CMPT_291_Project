using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT_291_Project
{
    public partial class MovieUI : Form
    {

        public MovieUI()
        {
            InitializeComponent();
            InitializeDictionary();
            HideAll();
        }


        public class Movie
        {
            /* private string text1;
             private int v1;
             private int v2;
             private string text2;*/

            // Initialize the movie characterstics
            public string Name { get; set; }
            public int ID { get; set; }
            public Type Genre { get; set; } // Comedy, Drama, Action or Foreign 
            public int Fee { get; set; }
            public int Rating { get; set; }  // 1 - 5

            public Movie(int ID, String Name, Type Genre, int Rating, int Fee)
            {
                this.Name = Name;
                this.ID = ID;
                this.Fee = Fee;
                this.Genre = Genre;
                this.Rating = Rating;

            }

            /*public Movie(string text1, int v1, int v2, string text2)
            {
                this.text1 = text1;
                this.v1 = v1;
                this.v2 = v2;
                this.text2 = text2;
            }*/

            public override string ToString()
            {
                return "Name: " + Name + " Genre: " + Genre + " ID: " + ID + "Rating" + Rating + "Fee: " + Fee;

            }


            /*public bool Match(Movie movieToFind)
             {

                 movieToFind.Name && 

             }*/

        }
        public enum Type
        {
            Comedy,
            Drama,
            Foreign,
            Action,
        }


        // initialize movie objects
        public Dictionary<Type, List<Movie>> MovieSet = new Dictionary<Type, List<Movie>>();
        //does type exist? then if it doesnt exist then create the new indent with a new initialised list 
        // INITIALIZES MOVIESET
        void InitializeDictionary()
        {
            foreach (Type type in Enum.GetValues(typeof(Type)))
            {
                MovieSet[type] = new List<Movie>(); // connect to database initialises dictionary everytime code is runned. 
            }
        }





        private void MovieInput_TextChanged(object sender, EventArgs e) //if movie entered is in the list 
        {

        }

        private void HideAll()
        {
            AddMovieNameLabel.Visible = false;
            AddGenreLabel.Visible = false;
            AddID.Visible = false;
            AddRatingLabel.Visible = false;
            AddFeeLabel.Visible = false;
            MovieLabel.Visible = false;
            SearchGenreLabel.Visible = false;
            MovieInput.Visible = false;
            GenreInput.Visible = false;
            AddButton.Visible = false;
            SearchButton.Visible = false;
            AddMovieInput.Visible = false;
            AddGenreBox.Visible = false;
            AddRatingBox.Visible = false;
            AddFeeBox.Visible = false;
            AddIDInput.Visible = false;
            SearchIDLabel.Visible = false;
            SearchIDInput.Visible = false;
            // NotFound.Visible = false;
            MovieName.Visible = false;
            Genre.Visible = false;
            ID.Visible = false;
            Rating.Visible = false;
            Fee.Visible = false;
            label1.Visible = false;
            label2.Visible = false;


        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (AddCheck.Checked)   // IF the user chooses to add a movie to the list. 
            {
                HideAll();
                //AddMovieLabel.Text = "Add a movie name:";
                //AddIDInput.Text = "Enter Movie ID:";
                AddIDInput.Visible = true;
                //AddRatingBox.Text = "Enter a Rating:";
                AddRatingBox.Visible = true;
                AddGenreLabel.Visible = true;
                // AddGenreLabel.Text = "Enter a genre:";
                AddID.Visible = true;
                AddMovieNameLabel.Visible = true;
                AddGenreLabel.Visible = true;
                AddFeeLabel.Visible = true;
                AddMovieInput.Visible = true;
                AddID.Visible = true;
                AddGenreBox.Visible = true;
                AddRatingLabel.Visible = true;
                AddFeeBox.Visible = true;
                AddButton.Visible = true;

            }

            if (SearchCheck.Checked)  // If client chooses to search movie this is what will show up 
            {
                HideAll();
                // MovieInput.Text = "Search for a Movie:";
                MovieLabel.Visible = true;
                MovieInput.Visible = true;
                SearchGenreLabel.Visible = true;
                GenreInput.Visible = true;
                SearchButton.Visible = true;
                SearchIDLabel.Visible = true;
                SearchIDInput.Visible = true;
                label1.Visible = true;
                label2.Visible = true;


            }

            if (!AddCheck.Checked & !SearchCheck.Checked)
            {
                HideAll();

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            int x = AddGenreBox.SelectedIndex;
            //Console.WriteLine(x);
            Type type = (Type)x;
            // public Movie(int ID, String Name, Type Genre, int Rating, int Fee)

            Movie newMovie = new Movie(Int32.Parse(AddIDInput.Text), AddMovieInput.Text, type, Int32.Parse(AddRatingBox.Text), Int32.Parse(AddFeeBox.Text));

            AddMovieInput.Text = " ";
            AddIDInput.Text = " ";
            AddRatingBox.Text = " ";
            // AddGenreBox.Text = " ";
            AddFeeBox.Text = " ";


            MovieSet[type].Add(newMovie);
            Console.WriteLine(newMovie.Name);


            // has mulitple components ch




        }


        private void SearchButton_Click(object sender, EventArgs e) // ID, genre, and Movie Name
        {

            MovieName.Text = "Movie Not Found";
            MovieName.Visible = true;
            //Movie movieToFind = new Movie(Int32.Parse(AddIDInput.Text), AddMovieInput.Text, (Type)AddGenreBox.SelectedIndex, Int32.Parse(AddRatingBox.Text), Int32.Parse(AddFeeBox.Text));
            List<List<Movie>> movieList = MovieSet.Values.ToList();
            List<Movie> allMovie = new List<Movie>();

            foreach (Movie m in allMovie) //movieset is a dictionary and we want the mvoies in that dictionary, roght now its trying to get the types
                
            {
                if (m.ID.Equals(Int32.Parse(SearchIDInput.Text)))  //search by ID
                {
                    MovieName.Visible = true;
                    Genre.Visible = true;
                    ID.Visible = true;
                    Rating.Visible = true;
                    Fee.Visible = true;


                    MovieName.Text = m.Name;

                }

                if (m.Genre.Equals(GenreInput.Text))  //search by Genre
                {
                    MovieName.Visible = true;
                    Genre.Visible = true;
                    ID.Visible = true;
                    Rating.Visible = true;
                    Fee.Visible = true;


                    //GenreInput.Text = m.Genre;
                }

                if (m.Name.Equals(MovieInput.Text))  //search by Name
                {
                    MovieName.Visible = true;
                    Genre.Visible = true;
                    ID.Visible = true;
                    Rating.Visible = true;
                    Fee.Visible = true;


                    MovieName.Text = m.Name;
                    /*

                                Movie movieToFind = new Movie(Int32.Parse(AddIDInput.Text), AddMovieInput.Text, (Type)AddGenreBox.SelectedIndex, Int32.Parse(AddRatingBox.Text), Int32.Parse(AddFeeBox.Text));
                                List<List<Movie>> movieList = MovieSet.Values.ToList();
                                List<Movie> allMovie = new List<Movie>();



                                foreach (List<Movie> listsOfMovie in movieList)
                                {
                                    allMovie.AddRange(listsOfMovie);
                                }*/

                    /* foreach (Movie movie in allMovie)
                     {
                         if (movie.Match(movieToFind))
                         {
                             SeeMovie();
                             return;
                         }
                     }

                 }*/


                    //get list for the id and name . with genre dict uses a key for genre to get the list just print the lisst of movies

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }
    }
}



