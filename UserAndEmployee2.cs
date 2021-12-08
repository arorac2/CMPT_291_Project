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

// test commit 

namespace CMPT_291_Project
{

    public partial class UserAndEmployee2 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public UserAndEmployee2()
        {
            InitializeComponent();
            dropDown.Items.Clear();
            dropDown.Items.Add("Show All");
            dropDown.Items.Add("Show employees with SSN");

            userDropdown.Items.Clear();
            userDropdown.Items.Add("Show All");
            userDropdown.Items.Add("Show users with");
            String connectionString = "Server = AURORA; Database = MovieRental; Trusted_Connection = yes;";


            String connectionString = "Server = DESKTOP-1JJOH8H; Database = MovieRental; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

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


        // LIST OF USERS - USED FOR TESTING W/O DATABASE IMPLEMENTED YET
        #region
        private List<User> userArray = new List<User>();
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // USER TAB INTERFACE USERNAME'S LISTVIEW. TEST USERS FOR DEMO (NO DB CONNECTION)
            ListViewItem user1 = new ListViewItem("Aaron", 0);
            user1.SubItems.Add("Alejo");
            user1.SubItems.Add("111");
            ListViewItem user2 = new ListViewItem("Chaahat", 0);
            user2.SubItems.Add("Arora");
            user2.SubItems.Add("112");
            ListViewItem user3 = new ListViewItem("Ian", 0);
            user3.SubItems.Add("Campbell");
            user3.SubItems.Add("113");
            ListViewItem user4 = new ListViewItem("Michael", 0);
            user4.SubItems.Add("Fauht");
            user4.SubItems.Add("114");

            userListUsr.Items.Add(user1);
            userListUsr.Items.Add(user2);
            userListUsr.Items.Add(user3);
            userListUsr.Items.Add(user4);

            // EMPLOYEE TAB INTERFACE USERNAME'S LISTVIEW. TEST USERS FOR DEMO (NO DB CONNECTION)
            ListViewItem user1Emp = new ListViewItem("Aaron", 0);
            user1Emp.SubItems.Add("Alejo");
            user1Emp.SubItems.Add("111");
            ListViewItem user2Emp = new ListViewItem("Chaahat", 0);
            user2Emp.SubItems.Add("Arora");
            user2Emp.SubItems.Add("112");
            ListViewItem user3Emp = new ListViewItem("Ian", 0);
            user3Emp.SubItems.Add("Campbell");
            user3Emp.SubItems.Add("113");
            ListViewItem user4Emp = new ListViewItem("Michael", 0);
            user4Emp.SubItems.Add("Fauht");
            user4Emp.SubItems.Add("114");


            /*
            foreach (User usr in userArray)
            {
                ListViewItem user1 = new ListViewItem(usr.ToString(), 0);
            }
            */
        }

        // CEATES A USER OBJECT
        public class User
        {
            // USER OBJECT PROPERTIES
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

            // USER CONTSRUCTOR METHOD
            public User(string first_name, string last_name, int account_number, short account_type,
                DateTime account_creation_date, string email_address, string address, string city, string state, string zip_code, long phone_no, long credit_card_no)
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

        private void finish_Click(object sender, EventArgs e)
        {

            var newUser = new User(getFirst.Text, getLast.Text, Int16.Parse(getAcctNo.Text), Int16.Parse(getPlan.Text), getDate.Value, getEmail.Text, getAddress.Text, getCity.Text, getState.Text, getZip.Text, Int64.Parse(getPhone.Text), Int64.Parse(getCred.Text));
            userArray.Add(newUser);


            //Console.WriteLine(newUser);
            getFirst.Text = "";
            getLast.Text = "";
            getAcctNo.Text = "";
            getPlan.Text = "";
            getDate.Text = "";
            getEmail.Text = "";
            getAddress.Text = "";
            getCity.Text = "";
            getState.Text = "";
            getZip.Text = "";
            getPhone.Text = "";
            getCred.Text = "";


            addUserEmp1.Visible = true;

            setFirst.Visible = false;
            setLast.Visible = false;
            setAcctNo.Visible = false;
            setPlan.Visible = false;
            setDate.Visible = false;
            setEmail.Visible = false;
            setAddress.Visible = false;
            setCity.Visible = false;
            setState.Visible = false;
            setZip.Visible = false;
            setPhone.Visible = false;
            setCred.Visible = false;

            getFirst.Visible = false;
            getLast.Visible = false;
            getAcctNo.Visible = false;
            getPlan.Visible = false;
            getDate.Visible = false;
            getEmail.Visible = false;
            getAddress.Visible = false;
            getCity.Visible = false;
            getState.Visible = false;
            getZip.Visible = false;
            getPhone.Visible = false;
            getCred.Visible = false;

            finish.Visible = false;
            cancel.Visible = false;
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMovies_Click(object sender, EventArgs e)
        {
            // IF PLAN TYPE = 1 
            // AND IF MOVIE QUEUE = 1
            // SHOW LABEL WITH "FULL QUEUE WARNING"
            // ELSE
            // IF MONTHLY LIMIT < 2 
            // GO TO MOVIE SCREEN
            // ELSE, SHOW LABEL WITH "FULL QUEUE WARNING"

            // IF PLAN TYPE IS 2-4 (COULD HAVE 3 MOVIES AT A TIME)
            // AND IF MOVIE QUEUE = 3 (FULL)
            // SHOW LABEL WITH "FULL QUEUE WARNING"
            // ELSE, GO TO MOVIE SCREEN
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            userTabUserList.Visible = true;
            userListUsr.Visible = true;
            userSearchBar.Visible = true;
            userSearchByName.Visible = true;
            userSearchByAcct.Visible = true;
            selectUser.Visible = true;
            changeUserType.Visible = true;

            userSettings.Visible = false;
            watchList.Visible = false;
            remove.Visible = false;
            addToWatchlist.Visible = false;
            watchListView.Visible = false;
            backButton.Visible = false;
            customerName.Visible = false;
            customerMovieList.Visible = false;
            movieListView.Visible = false;
            settings.Visible = false;
            userPic.Visible = false;
            userActivity.Visible = false;
            addMovies.Visible = false;
            returnMovies.Visible = false;


        }

        private void selectUser_Click(object sender, EventArgs e)
        {

            if (userListUsr.SelectedItems.Count != 0)
            {

                string firstName = userListUsr.SelectedItems[0].SubItems[0].Text;
                string lastName = userListUsr.SelectedItems[0].SubItems[1].Text;
                customerName.Text = firstName + " " + lastName;

                userTabUserList.Visible = false;
                userListUsr.Visible = false;
                userSearchBar.Visible = false;
                userSearchByName.Visible = false;
                userSearchByAcct.Visible = false;
                selectUser.Visible = false;
                changeUserType.Visible = false;

                userSettings.Visible = true;
                watchList.Visible = true;
                remove.Visible = true;
                addToWatchlist.Visible = true;
                watchListView.Visible = true;
                customerName.Visible = true;
                customerMovieList.Visible = true;
                movieListView.Visible = true;
                settings.Visible = true;
                userPic.Visible = true;
                userActivity.Visible = true;
                addMovies.Visible = true;
                returnMovies.Visible = true;
                backButton.Visible = true;
            }
            else { return; }

        }


        private void RentalPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeControls.Visible = true;

            EmployeeUI.Visible = false;
            CustomerUI.Visible = false;
            UserTabs.Visible = false;
            UserType.Visible = false;

        }

        private void CustomerUI_Click(object sender, EventArgs e)
        {
            UserTabs.Visible = true;
            changeUserType.Visible = true;

            EmployeeUI.Visible = false;
            CustomerUI.Visible = false;
            EmployeeControls.Visible = false;
            UserType.Visible = false;

        }

        private void changeUserType_Click(object sender, EventArgs e)
        {
            changeUserType.Visible = false;
            UserTabs.Visible = false;

            UserType.Visible = true;
            EmployeeUI.Visible = true;
            CustomerUI.Visible = true;


        }

        private void userTypeEmp_Click(object sender, EventArgs e)
        {
            changeUserType.Visible = false;
            EmployeeControls.Visible = false;

            UserType.Visible = true;
            EmployeeUI.Visible = true;
            CustomerUI.Visible = true;
        }

        private void watchList_Click(object sender, EventArgs e)
        {

        }

        private void empBack_Click_1(object sender, EventArgs e)
        {

            userTypeEmp.Visible = true;
            userListLabel.Visible = true;
            searchBar.Visible = true;

            addUserEmp1.Visible = true;
            userDropdown.Visible = true;
            userSearchBar.Visible = true;
            userSearchBox.Visible = true;
            userList.Visible = true;

            doneEdit.Visible = false;
            editUser.Visible = false;
            deleteUser.Visible = false;
            userSearchBar.Visible = false;
            userNameEmp.Visible = false;
            userAcctNo.Visible = false;
            userPlan.Visible = false;
            userDate.Visible = false;
            userAddress.Visible = false;
            userCity.Visible = false;
            userState.Visible = false;
            userZip.Visible = false;
            userPhone.Visible = false;
            userCred.Visible = false;

            empBack.Visible = false;
            userNameEmp.Visible = false;
            userAcctNoEmp.Visible = false;
            userPlanEmp.Visible = false;
            userDateEmp.Visible = false;
            userAddressEmp.Visible = false;
            userCityEmp.Visible = false;
            userStateEmp.Visible = false;
            userZipEmp.Visible = false;
            userPhoneEmp.Visible = false;
            userCredEmp.Visible = false;

            changeFirst.Visible = false;
            changeLast.Visible = false;
            changePlan.Visible = false;
            changeDate.Visible = false;
            changeAddress.Visible = false;
            changeCity.Visible = false;
            changeState.Visible = false;
            changeZip.Visible = false;
            changePhone.Visible = false;
            changeCred.Visible = false;
            doneEdit.Visible = false;
            editDeleteMsg.Visible = false;

            userPicEmp.Visible = false;
            userActivityEmp.Visible = false;
        }

        private void addUserEmp1_Click(object sender, EventArgs e)
        {
            addUserEmp1.Visible = false;
            userList.Visible = false;
            userPicEmp.Visible = false;
            userActivityEmp.Visible = false;
            userDropdown.Visible = false;
            searchBar.Visible = false;
            userSearchBox.Visible = false;
            userListLabel.Visible = false;
            userTypeEmp.Visible = false;

            setFirst.Visible = true;
            setLast.Visible = true;
            setAcctNo.Visible = true;
            setPlan.Visible = true;
            setDate.Visible = true;
            setEmail.Visible = true;
            setAddress.Visible = true;
            setCity.Visible = true;
            setState.Visible = true;
            setZip.Visible = true;
            setPhone.Visible = true;
            setCred.Visible = true;

            getFirst.Visible = true;
            getLast.Visible = true;
            getAcctNo.Visible = true;
            getPlan.Visible = true;
            getDate.Visible = true;
            getEmail.Visible = true;
            getAddress.Visible = true;
            getCity.Visible = true;
            getState.Visible = true;
            getZip.Visible = true;
            getPhone.Visible = true;
            getCred.Visible = true;

            finish.Visible = true;
            cancel.Visible = true;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmpFirstName.Visible = true;
            EmpLastName.Visible = true;
            SIN.Visible = true;
            PhoneNo.Visible = true;
            StartDate.Visible = true;
            HourlyRate.Visible = true;
            Address.Visible = true;
            City.Visible = true;
            State.Visible = true;
            Zip.Visible = true;

            EmpFirstNameBox.Visible = true;
            EmpLastNameBox.Visible = true;
            SINBox.Visible = true;
            PhoneNoBox.Visible = true;
            StartDateBox.Visible = true;
            HourlyRateBox.Visible = true;
            AddressBox.Visible = true;
            CityBox.Visible = true;
            StateBox.Visible = true;
            ZipBox.Visible = true;
            CancelAdd.Visible = true;
            AddEmployee.Visible = true;

            employees.Visible = false;
            dropDown.Visible = false;
            value.Visible = false;
            search.Visible = false;

            employeeListLabel.Visible = false;
            employees.Visible = false;
            EmployeeAdd.Visible = false;
            changeUserTypeEmp.Visible = false;

        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {

            EmpFirstName.Visible = false;
            EmpLastName.Visible = false;
            SIN.Visible = false;
            PhoneNo.Visible = false;
            StartDate.Visible = false;
            HourlyRate.Visible = false;
            Address.Visible = false;
            City.Visible = false;
            State.Visible = false;
            Zip.Visible = false;

            addEmpMsg.Visible = false;
            EmpFirstNameBox.Visible = false;
            EmpLastNameBox.Visible = false;
            SINBox.Visible = false;
            PhoneNoBox.Visible = false;
            StartDateBox.Visible = false;
            HourlyRateBox.Visible = false;
            AddressBox.Visible = false;
            CityBox.Visible = false;
            StateBox.Visible = false;
            ZipBox.Visible = false;
            CancelAdd.Visible = false;
            AddEmployee.Visible = false;

            employees.Visible = true;
            dropDown.Visible = true;
            value.Visible = true;
            search.Visible = true;
            employeeListLabel.Visible = true;
            employees.Visible = true;
            EmployeeAdd.Visible = true;
            changeUserTypeEmp.Visible = true;

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                myCommand.CommandText = "insert into employees values (" + SINBox.Text + ",'" + EmpFirstNameBox.Text + "','" + EmpLastNameBox.Text +
                    "','" + AddressBox.Text + "','" + CityBox.Text + "','" + StateBox.Text + "','" + ZipBox.Text + "'," + PhoneNoBox.Text +
                    ",'" + StartDateBox.Text + "'," + HourlyRateBox.Text + ")";
                //MessageBox.Show(myCommand.CommandText);

                EmpFirstNameBox.Text = "";
                EmpLastNameBox.Text = "";
                SINBox.Text = "";
                PhoneNoBox.Text = "";
                StartDateBox.Text = "";
                HourlyRateBox.Text = "";
                AddressBox.Text = "";
                CityBox.Text = "";
                StateBox.Text = "";
                ZipBox.Text = "";

                addEmpMsg.ForeColor = Color.LimeGreen;
                addEmpMsg.Text = "Employee Added";
                addEmpMsg.Visible = true;

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {

                addEmpMsg.Visible = true;
                addEmpMsg.ForeColor = Color.Red;
                addEmpMsg.Text = "Failed to Add";

                MessageBox.Show(e2.ToString(), "Error");
            }
        }


        private void search_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from employees";
            if (dropDown.Text == "Show All") { 
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    employees.Rows.Clear();
                    while (myReader.Read())
                    {
                        employees.Rows.Add(myReader["ssn"].ToString(), myReader["first_name"].ToString(), myReader["last_name"].ToString(), myReader["phone_no"].ToString());
                    }

                    myReader.Close();
                }
                catch (Exception e3)
                {
                    //MessageBox.Show(e3.ToString(), "Error");
                }
            }


            if (dropDown.Text == "Show employees with SSN")
                myCommand.CommandText += " where ssn like %" + value.Text + "%";


            
        }

        private void selsectEmployee_Click(object sender, EventArgs e)
        {

        }

        // OPENING OTHER FORMS

        private void userSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSettings settingsWindow = new UserSettings(int.MaxValue);
            settingsWindow.Show();
        }

        private void searchTitle_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieUI2 searchMovie = new MovieUI2();
            searchMovie.Show();
        }

        private void searchGenre_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieUI2 searchMovie = new MovieUI2();
            searchMovie.Show();
        }

        private void searchActor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActorSearch searchActor = new ActorSearch();
            searchActor.Show();
        }


        private void finish_Click_2(object sender, EventArgs e)
        {   
            try
            {

                myCommand.CommandText = "SET IDENTITY_INSERT [dbo].[customers] ON insert into [dbo].[customers] ([account_number], [account_type], " +
                    "[account_creation_date], [first_name], [last_name], [address], [city], [state], [zip_code], [phone_no], [credit_card_no]) values (" 
                    + getAcctNo.Text + ",'" + getPlan.Text + "','" + getDate.Text + "','" + getFirst.Text + "','" + getLast.Text + "','" + 
                    getAddress.Text + "','" + getCity.Text + "','" + getState.Text + "','" + getZip.Text + "'," + getPhone.Text + "," + getCred.Text + ")";
                //MessageBox.Show(myCommand.CommandText);

                getAcctNo.Text = "";
                getPlan.Text = "";
                getDate.Text = "";
                getFirst.Text = "";
                getLast.Text = "";
                getEmail.Text = "";
                getAddress.Text = "";
                getCity.Text = "";
                getState.Text = "";
                getZip.Text = "";
                getPhone.Text = "";
                getCred.Text = "";

                addUserMessage.ForeColor = Color.LimeGreen;
                addUserMessage.Text = "Employee Added";
                addUserMessage.Visible = true;

                myCommand.ExecuteNonQuery();
            }
            catch (Exception e2)
            {

                addUserMessage.Visible = true;
                addUserMessage.ForeColor = Color.Red;
                addUserMessage.Text = "Failed to Add";

                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void ManageUser_Click(object sender, EventArgs e)
        {

        }

        private void doneEditEmp_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update employees ";

            string[] words4 = empName.Text.Split(' ');
            if (changeEmpFirst.Text == "")
                changeEmpFirst.Text = words4[0];

            if (changeEmpSur.Text == "")
                changeEmpSur.Text = words4[1];

            if (changeEmpPhone.Text == "")
                changeEmpPhone.Text = empPhone.Text;

            if (changeEmpDate.Text == "")
                changeEmpDate.Text = empDate.Text;

            if (changeEmpRate.Text == "")
                changeEmpRate.Text = empRate.Text;

            if (changeEmpAddress.Text == "")
                changeEmpAddress.Text = empAddress.Text;

            if (changeEmpCity.Text == "")
                changeEmpCity.Text = empCity.Text;

            if (changeEmpState.Text == "")
                changeEmpState.Text = empState.Text;

            if (changeEmpZip.Text == "")
                changeEmpZip.Text = empZip.Text;

            if (changeEmpPhone.Text == "")
                changeEmpPhone.Text = empPhone.Text;


            try
            {
                myCommand.CommandText += "set first_name = '" + changeEmpFirst.Text + "', last_name = '"
                    + changeEmpSur.Text + "', start_date = '" + changeEmpDate.Text + "', address = '"
                    + changeEmpAddress.Text + "', city = '" + changeEmpCity.Text + "', state = '"
                    + changeEmpState.Text + "', zip_code = '" + changeEmpZip.Text + "', phone_no = "
                    + changeEmpPhone.Text + ", hourly_rate = " + changeEmpRate.Text;
                myCommand.CommandText += " where ssn = " + empSSN.Text;

                editDeleteEmpMsg.Visible = true;
                editDeleteEmpMsg.Text = "Edit Complete";
                editDeleteEmpMsg.ForeColor = Color.Lime;
                myCommand.ExecuteNonQuery();
            }

            catch(Exception e3)
            {
                editDeleteEmpMsg.Visible = true;
                editDeleteEmpMsg.Text = "Edit Failed";
                editDeleteEmpMsg.ForeColor = Color.Red;
                MessageBox.Show(e3.ToString(), "Error");
            }

            empName.Text = changeEmpFirst.Text + " " + changeEmpSur.Text;
            empPhone.Text = changeEmpPhone.Text;
            empDate.Text = changeEmpDate.Text;
            empAddress.Text = changeEmpAddress.Text;
            empCity.Text = changeEmpCity.Text;
            empState.Text = changeEmpState.Text;
            empZip.Text = changeEmpZip.Text;
            empPhone.Text = changeEmpPhone.Text;
            empRate.Text = changeEmpRate.Text;

            /*
            changeFirst.Visible = false;
            changeLast.Visible = false;
            changePlan.Visible = false;
            changeDate.Visible = false;
            changeAddress.Visible = false;
            changeCity.Visible = false;
            changeState.Visible = false;
            changeZip.Visible = false;
            changePhone.Visible = false;
            changeCred.Visible = false;
            doneEdit.Visible = false;

            userNameEmp.Visible = true;
            userAcctNo.Visible = true;
            userPlan.Visible = true;
            userDate.Visible = true;
            userAddress.Visible = true;
            userCity.Visible = true;
            userState.Visible = true;
            userZip.Visible = true;
            userPhone.Visible = true;
            userCred.Visible = true;
            */
        }

        private void deleteEmp_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "delete from employees where ssn = " + empSSN.Text;
                editDeleteEmpMsg.Visible = true;
                editDeleteEmpMsg.Text = "Employee Terminated";
                editDeleteEmpMsg.ForeColor = Color.Lime;
                myCommand.ExecuteNonQuery();
            }

            catch
            {
                editDeleteEmpMsg.Visible = true;
                editDeleteEmpMsg.Text = "Unable to terminate Employee";
                editDeleteEmpMsg.ForeColor = Color.Red;
            }

            empName.Text = "Employee's Name";
            empSSN.Text = "";
            empPhone.Text = "";
            empDate.Text = "";
            empRate.Text = "";
            empAddress.Text = "";
            empCity.Text = "";
            empState.Text = "";
            empZip.Text = "";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdvancedStatistics stats = new AdvancedStatistics();
            stats.Show();
        }
        /*
private void selsectEmployee_Click(object sender, EventArgs e)
{

myCommand.CommandText = "select * from student";
/*
if (employeeSearchBar.Text == "Show with starting grade: ")
myCommand.CommandText += " where grade >= " + SmallestGrade.Text;


try
{
MessageBox.Show(myCommand.CommandText);
myReader = myCommand.ExecuteReader();

EmployeeList.Rows.Clear();
while (myReader.Read())
{
EmployeeList.Rows.Add(myReader["ssn"].ToString(), myReader["first_name"].ToString(), myReader["last_name"].ToString(), myReader["phone_no"].ToString(), myReader["hourly_rate"].ToString());
}

myReader.Close();
}
catch (Exception e3)
{
MessageBox.Show(e3.ToString(), "Error");
}

}*/
    }

}


