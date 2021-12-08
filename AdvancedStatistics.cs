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
    public partial class AdvancedStatistics : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public AdvancedStatistics()
        {
            InitializeComponent();

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


        // REPLACE "option1" etc, WITH WHATEVER TEXT YOU PUT IN THE COMBO BOX FOR SELECTING A QUERY IN THE DESIGNER FILE THEN ADD CODE TO SWITCHES
        private void button1_Click(object sender, EventArgs e)
        {
            String queryOption = queryBox.Text;
            switch (queryOption)
            {
                case "option1":
                    break;

                case "option2":
                    break;

                case "option3":
                    break;

                case "option4":
                    break;

                case "option5":
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAndEmployee2 main = new UserAndEmployee2();
            main.Show();
        }
    }
}
