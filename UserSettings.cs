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
using System.Globalization;

namespace CMPT_291_Project
{
    public partial class UserSettings : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public TextInfo TI;
        private int CUSTOMER_ACCOUNT_NUMBER;

        public UserSettings(int CustomerAccountNumber)
        {
            InitializeComponent();
            CUSTOMER_ACCOUNT_NUMBER = CustomerAccountNumber;

            TI = new CultureInfo("en-US", false).TextInfo;

            String connectionString = "Server = IANPC; Database = MovieRental; Trusted_Connection = yes;";

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

        public class Actor
        {
            public string Name { get; set; }
            public int Age { get; set; } 
            public int ID { get; set; }
            public string Appearances { get; set; }
        }

        public class ActorSet
        {
            protected List<Actor> actors { get; set; }

        }

        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int AccountNumber { get; set; }
            public short AccountType { get; set; }
            public DateTime DateAccountCreated { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public long Phone { get; set; }
            public long CreditCardNumber { get; set; }

            public override string ToString()
            {
                return "Name: " + FirstName + " " + LastName + "\nAccount Type: " + AccountNumber + "\nCredit Card #: " + CreditCardNumber + "\nAccount type: " + AccountType;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserSettings2_Load(object sender, EventArgs e)
        {
            LoadRecentlyWatched();
            LoadMovieRatings();
            LoadActorRatings();
        }

        private void oneMovieRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void creditCardNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void updatePaymentButton_Click(object sender, EventArgs e)
        {
            if
                // field was left empty
                (
                    String.IsNullOrEmpty(firstNameTextBox.Text)
                    || String.IsNullOrEmpty(lastNameTextBox.Text)
                    || String.IsNullOrEmpty(paymentCardTextBox.Text)
                    || planSelectDropdown.SelectedIndex == -1
                    || String.IsNullOrEmpty(addressTextBox.Text)
                    || String.IsNullOrEmpty(cityTextBox.Text)
                    || String.IsNullOrEmpty(stateTextBox.Text)
                    || String.IsNullOrEmpty(zipTextBox.Text)
                    || String.IsNullOrEmpty(phoneNumberTextBox.Text)
                )
            {
                updateStatusLabel.Text = "There was an error saving your payment information.";
                updateStatusLabel.BackColor = Color.Red;

            } else
            {
                cmd.CommandText = "UPDATE customers SET "
                           + "first_name = @first"
                           + ", last_name = @last"
                           + ", credit_card_no = @credit"
                           + ", account_type = @plan"
                           + ", address = @address"
                           + ", city = @city"
                           + ", state = @state"
                           + ", zip_code = @zip"
                           + ", phone_no = @phone"
                           + " WHERE account_number = @id"; // TODO: Add in functionality for pulling user id from users page
                try
                {
                    // add parameters to update statement
                    cmd.Parameters.Add(new SqlParameter("@first", TI.ToTitleCase(firstNameTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@last", TI.ToTitleCase(lastNameTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@credit", paymentCardTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@plan", (planSelectDropdown.SelectedIndex + 1)));
                    cmd.Parameters.Add(new SqlParameter("@address", TI.ToTitleCase(addressTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@city", TI.ToTitleCase(cityTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@state", TI.ToUpper(stateTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@zip", TI.ToUpper(zipTextBox.Text)));
                    cmd.Parameters.Add(new SqlParameter("@phone", phoneNumberTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", CUSTOMER_ACCOUNT_NUMBER));
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    // restore fields to empty default values
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    paymentCardTextBox.Text = "";
                    planSelectDropdown.SelectedIndex = -1;
                    addressTextBox.Text = "";
                    cityTextBox.Text = "";
                    stateTextBox.Text = "";
                    zipTextBox.Text = "";
                    phoneNumberTextBox.Text = "";

                    updateStatusLabel.Text = "Payment information saved!";
                    updateStatusLabel.BackColor = Color.LightGreen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                    updateStatusLabel.Text = "There was an error saving your payment information.";
                    updateStatusLabel.BackColor = Color.Red;
                }
            }
            

        }

        private void showAndHideUpdateStatusLabel(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }

        private void myRatingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadRecentlyWatched()
        {
            cmd.CommandText =
                "SELECT time_in, title, rating, average_rating " +
                "FROM orders o " +
                "JOIN movies m ON o.movie_id = m.id " +
                "LEFT JOIN movie_ratings r ON m.id = r.movie_id AND o.customer_id = r.customer_account_number " +
                "JOIN( " +
                    "SELECT m2.id movie_id, AVG(rating) average_rating " +
                    "FROM movie_ratings r2 " +
                    "JOIN movies m2 ON r2.movie_id = m2.id GROUP BY m2.id) average ON average.movie_id = m.id " +
                "GROUP BY customer_id, time_in, title, rating, average_rating " +
                "HAVING customer_id = @id";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", CUSTOMER_ACCOUNT_NUMBER));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["title"].ToString());
                    item.SubItems.Add(reader["time_in"].ToString());
                    item.SubItems.Add(reader["rating"].ToString());
                    item.SubItems.Add(reader["average_rating"].ToString());

                    recentlyWatchedListView.Items.Add(item);
                }
                reader.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void LoadMovieRatings()
        {
            cmd.CommandText =
                "SELECT title, rating " +
                "FROM movies m JOIN movie_ratings r ON m.id = r.movie_id " +
                "WHERE r.customer_account_number = @id";

            try
            {
                cmd.Parameters.Add(new SqlParameter("@id", CUSTOMER_ACCOUNT_NUMBER));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["title"].ToString());
                    item.SubItems.Add(reader["rating"].ToString());

                    movieRatingsListView.Items.Add(item);
                }
                reader.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void LoadActorRatings()
        {
            {
                cmd.CommandText =
                    "SELECT name, rating " +
                    "FROM actors a JOIN actor_ratings r ON a.id = r.actor_id " +
                    "WHERE r.customer_account_number = @id";

                try
                {
                    cmd.Parameters.Add(new SqlParameter("@id", CUSTOMER_ACCOUNT_NUMBER));
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["name"].ToString());
                        item.SubItems.Add(reader["rating"].ToString());

                        actorRatingsListView.Items.Add(item);
                    }
                    reader.Close();
                    cmd.Parameters.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ERROR");
                }
            }
        }
    }


}
