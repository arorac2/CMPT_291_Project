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
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
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

        private void UserSettings_Load(object sender, EventArgs e)
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
            var timer = new Timer();
            updateStatusLabel.Text = "Payment information saved!";
            updateStatusLabel.BackColor = Color.LightGreen;
            timer.Interval = 2000;

            // solution based on Mike Perrenoud's code from https://stackoverflow.com/questions/15951689/show-label-text-as-warning-message-and-hide-it-after-a-few-seconds
            timer.Tick += (senderObject, eventArg) =>
            {
                updateStatusLabel.Hide();
                timer.Stop();
            };
            timer.Start();
            
            var user = new User();

            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.CreditCardNumber = long.Parse(paymentCardTextBox.Text);
            user.AccountType = (short)(planSelectDropdown.SelectedIndex + 1);

            //SQL update with actor object
            label1.Text = user.ToString();
        }

        private void showAndHideUpdateStatusLabel(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }
    }


}
