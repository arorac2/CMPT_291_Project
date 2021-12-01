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
    public partial class MovieUI2 : Form
    {
        protected List<Movie> movieSet = new List<Movie>();
        public MovieUI2()
        {
            InitializeComponent();
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
                // INITILIZE LIST OF ACTOR OBJECTS
                protected List<Movie> movieList { get; set; }

                // CREATE OBJECT
                public MovieSet()
                {
                    movieList = new List<Movie>();
                }

                // METHOD TO ADD ACTOR TO ACTOR LIST
                /* public void insert(Actor movie)
                 {
                     movieList.Add(movie);
                 }*/

            }
        }

        private void Select_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void SearchGenre_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }
    }
}

