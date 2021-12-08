﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Globalization;

namespace CMPT_291_Project
{
    public partial class MovieManagement : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public TextInfo TI;

        public MovieManagement()
        {
            InitializeComponent();
            string connectionString = "Server = AURORA; Database = MovieRental; Trusted_Connection = yes;";

            TI = new CultureInfo("en-US", false).TextInfo;
            conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
                this.Close();
            }
        }

        public class User
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public int account_number { get; set; }
            public short account_type { get; set; }
            public DateTime account_creation_date { get; set; }
            public string email_address { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip_code { get; set; }
            public long phone_no { get; set; }
            public long credit_card_no { get; set; }

            public User(
                string first_name, 
                string last_name, 
                int account_number, 
                short account_type, 
                DateTime account_creation_date, 
                string email_address, 
                string address, 
                string city, 
                string state, 
                string zip_code, 
                long phone_no, 
                long credit_card_no
            )
            {
                this.first_name = first_name;
                this.last_name = last_name;
                this.account_number = account_number;
                this.account_type = account_type;
                this.account_creation_date = account_creation_date;
                this.email_address = email_address;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip_code = zip_code;
                this.phone_no = phone_no;
                this.credit_card_no = credit_card_no;

            }
        }

            private void MovieManagement_Load(object sender, EventArgs e)
        {
            LoadMovieData();
        }

        public void LoadMovieData()
        {
            cmd.CommandText = "SELECT * FROM movies";
            try
            {
                reader = cmd.ExecuteReader();
                moviesListView.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["id"].ToString());
                    item.SubItems.Add(reader["title"].ToString());
                    item.SubItems.Add(reader["genre"].ToString());
                    item.SubItems.Add(reader["copies_in_stock"].ToString());

                    moviesListView.Items.Add(item);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addMovieBtn_Click(object sender, EventArgs e)
        {
            MoviePopup addMoviePopup = new MoviePopup();
            DialogResult result = addMoviePopup.ShowDialog();

            cmd.CommandText = "INSERT INTO movies(title, genre, copies_in_stock) VALUES(@title, @genre, @copies)";
            if (result == DialogResult.OK)
            {
               try
               {
                    cmd.Parameters.Clear();
                    SqlParameter[] parameters = new SqlParameter[3];
                    parameters[0] = new SqlParameter("@title", TI.ToTitleCase(addMoviePopup.GetMovieTitle()));
                    cmd.Parameters.Add(parameters[0]);
                    parameters[1] = new SqlParameter("@genre", addMoviePopup.GetMovieGenre());
                    cmd.Parameters.Add(parameters[1]);
                    parameters[2] = new SqlParameter("copies", addMoviePopup.GetMovieCopies());
                    cmd.Parameters.Add(parameters[2]);

                    cmd.ExecuteNonQuery();
                    LoadMovieData();
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "ERROR");
               }
                }
            else if (result == DialogResult.Cancel)
            {
                addMoviePopup.Dispose();
            }
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM movies WHERE id = @id";

            try
            {
                ListViewItem item = moviesListView.SelectedItems[0];
                int itemId = Int32.Parse(item.SubItems[0].Text);
                string title = item.SubItems[1].Text;
                SqlParameter id = new SqlParameter("@id", itemId);
                cmd.Parameters.Add(id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                LoadMovieData();
                MessageBox.Show("Deleted movie with ID " + itemId + " (" + title + ") from the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }
    }
}
