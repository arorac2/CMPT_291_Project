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
    public partial class AddMoviePopup : Form
    {
        public MovieManagement mm;

        public AddMoviePopup(MovieManagement mm)
        {
            InitializeComponent();
            this.mm = mm;
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
