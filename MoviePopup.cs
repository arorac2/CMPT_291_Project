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
    public partial class MoviePopup : Form
    {

        public MoviePopup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // return true if all fields have legal values
        public Boolean AllFieldsFilled()
        {
            return addMovieTitleTextbox.Text != null && addMovieGenreDropdown.SelectedIndex != -1 && addMovieCopiesInput.Value >= 0;
        }

        public void ShowErrorLabel()
        {
            addMoviePopupStatusLabel.Text = "Please ensure all fields have been filled";
        }

        public string GetMovieTitle()
        {
            return addMovieTitleTextbox.Text;
        }

        public string GetMovieGenre()
        {
            return addMovieGenreDropdown.SelectedItem.ToString();
        }

        public int GetMovieCopies()
        {
            return (int) addMovieCopiesInput.Value;
        }

        private void AddMoviePopup_Load(object sender, EventArgs e)
        {

        }

        public void SetMovieTitle(string title)
        {
            addMovieTitleTextbox.Text = title;
        }

        public void SetMovieGenre(string genre)
        {
            addMovieGenreDropdown.SelectedItem = genre;
        }

        public void SetMovieCopies(int copies)
        {
            addMovieCopiesInput.Value = copies;
        }

        private void addMoviePopupAddBtn_Click(object sender, EventArgs e)
        {
            if (!AllFieldsFilled())
            {
                this.DialogResult = DialogResult.None;
                ShowErrorLabel();
            }
        }
    }
}
