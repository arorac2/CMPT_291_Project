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
    public partial class UserSettings2 : Form
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public TextInfo TI;

        public UserSettings2()
        {
            InitializeComponent();

            TI = new CultureInfo("en-US", false).TextInfo;

            String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental; Trusted_Connection = yes;";

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
                           + "first_name = (@first)"
                           + ", last_name = (@last)"
                           + ", credit_card_no = (@credit)"
                           + ", account_type = (@plan)"
                           + ", address = (@address)"
                           + ", city = (@city)"
                           + ", state = (@state)"
                           + ", zip_code = (@zip)"
                           + ", phone_no = (@phone)"
                           + " WHERE account_number = 1"; // TODO: Add in functionality for pulling user id from users page
                try
                {
                    SqlParameter[] parameters = new SqlParameter[9];
                    parameters[0] = new SqlParameter("@first", TI.ToTitleCase(firstNameTextBox.Text));
                    cmd.Parameters.Add(parameters[0]);
                    parameters[1] = new SqlParameter("@last", TI.ToTitleCase(lastNameTextBox.Text));
                    cmd.Parameters.Add(parameters[1]);
                    parameters[2] = new SqlParameter("@credit", paymentCardTextBox.Text);
                    cmd.Parameters.Add(parameters[2]);
                    parameters[3] = new SqlParameter("@plan", (planSelectDropdown.SelectedIndex + 1));
                    cmd.Parameters.Add(parameters[3]);
                    parameters[4] = new SqlParameter("@address", TI.ToTitleCase(addressTextBox.Text));
                    cmd.Parameters.Add(parameters[4]);
                    parameters[5] = new SqlParameter("@city", TI.ToTitleCase(cityTextBox.Text));
                    cmd.Parameters.Add(parameters[5]);
                    parameters[6] = new SqlParameter("@state", TI.ToUpper(stateTextBox.Text));
                    cmd.Parameters.Add(parameters[6]);
                    parameters[7] = new SqlParameter("@zip", TI.ToUpper(zipTextBox.Text));
                    cmd.Parameters.Add(parameters[7]);
                    parameters[8] = new SqlParameter("@phone", phoneNumberTextBox.Text);
                    cmd.Parameters.Add(parameters[8]);
                    cmd.ExecuteNonQuery();

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
    }


}
