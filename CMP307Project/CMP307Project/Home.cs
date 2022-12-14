using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    //  When accessing the database
using System.Data.SqlTypes;     //  when retrieving from database
using System.Data;  //  for different data containers
using System.Management;
using System.Management.Instrumentation;
using System.Security.Cryptography;

namespace CMP307Project
{
    public partial class Home : Form
    {
        public Home()
        {
            //  On programme start these functions will be run
            InitializeComponent();
            InsertData();

            getSystemData();
        }

        public void InsertData() // Receives the data from the database and inserts it into lstView
        {
            //  Select query
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";

            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT * FROM dbo.ASSETS";

            SqlCommand Command = new SqlCommand(query);

            Command.Connection = conn;

            SqlDataReader data = Command.ExecuteReader();
            lstHardwareData.Items.Add("AssNum\tSystem Name\tModel\tManufacturer\tType\tIP\t\tPurchase Date\t\tNotes");
            while (data.Read())
            {
                //  Inserts data into the list box lstView
                lstHardwareData.Items.Add(data[0] + "\t" + data[1] + "\t" + data[2] + "\t" + data[3] + "\t" + data[4] + "\t" + data[5] + "\t" + data[6] + "\t" + data[7]);
            }
            data.Close();

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //  Closes the program when button is pressed
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            changeVisibility();
            lstHardwareData.Visible = true; //  Shows the list box containing all the data from the database
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            changeVisibility();
            flpInsertAsset.Visible = true;  //  Shows the form that allows the user to insert data
        }

        private void btnInsertSubmit_Click(object sender, EventArgs e)
        {
            //  Declares local variables with user text input
            string InsertSysName = txtInsertSysName.Text.ToString();
            string InsertModel = txtInsertModel.Text.ToString();
            string InsertManufacturer = txtInsertManufacturer.Text.ToString();
            string InsertAssType = txtInsertAssType.Text.ToString();
            string InsertIP = txtInsertIPAddr.Text.ToString();
            string InsertPurchDate = txtInsertPurchDate.Text.ToString();
            string InsertNotes = txtInsertNotes.Text.ToString();

            //  Insert query
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";

            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection successfully established.\n");

            string insertQuery = "INSERT INTO dbo.ASSETS (SystemName, Model, Manufacturer, AssetType, IPAddress, PurchaseDate, Notes) VALUES " +
                "('" + InsertSysName + "', '" + InsertModel + "', '" + InsertManufacturer + "', '" + InsertAssType + "', '" + InsertIP + "', '" + InsertPurchDate + "', '" + InsertNotes + "');";

            SqlCommand Insertcommand = new SqlCommand(insertQuery, conn);
            int n = Insertcommand.ExecuteNonQuery();
            Console.WriteLine(n + " rows affected");

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            //  Clears all text boxes after data has been submitted
            txtInsertSysName.Clear();
            txtInsertModel.Clear();
            txtInsertManufacturer.Clear();
            txtInsertAssType.Clear();
            txtInsertIPAddr.Clear();
            txtInsertPurchDate.Clear();
            txtInsertNotes.Clear();

            changeVisibility();

            //  Clears the list box lstView, ready to receive the new data
            lstSystemData.Items.Clear();

            //  Runs the insert data function again so that the
            //  new data will be present in the list box when viewed
            InsertData();

            //  Pop-up alert stating Data was successfully added
            MessageBox.Show("Your data was successfully inputted into the database");
        }

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            //  Clears all text boxes after the cancel button has been pressed
            txtInsertSysName.Clear();
            txtInsertModel.Clear();
            txtInsertManufacturer.Clear();
            txtInsertAssType.Clear();
            txtInsertIPAddr.Clear();
            txtInsertPurchDate.Clear();
            txtInsertNotes.Clear();

            changeVisibility();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            //  Clears all text boxes after the cancel button has been pressed
            txtPassword.Clear();
            txtUsername.Clear();

            //  Hides form after cancel button has been pressed
            flpLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            flpLogin.Visible = true;
        }

        private void changeVisibility()
        {
            flpLogin.Visible = false;
            flpInsertAsset.Visible = false;
            lstSystemData.Visible = false;
            lstHardwareData.Visible = false;
            lstSoftwareData.Visible = false;
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            string userPass;

            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);
            conn.Open();

            string query = "SELECT * FROM SCOT.STAFF WHERE UserName = '" + username + "';";
            SqlCommand  command = new SqlCommand(query, conn);
            SqlDataReader data = command.ExecuteReader();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("A username and password must be inputted to log in.");
            }
            else if (data.HasRows)
            {
                while (data.Read())
                {
                    userPass = Convert.ToString(data[1]);

                    if (password == userPass)
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        btnViewHardware.Enabled = true;
                        btnViewSoftware.Enabled = true;
                        btnViewSystem.Enabled = true;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnLogin.Enabled = false;
                        btnLogin.Text = "Logged in";
                        changeVisibility();

                        MessageBox.Show("User has successfully logged in!");
                    }
                    else
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        MessageBox.Show("Incorrect username or password. Please try again");
                    }
                }
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }

        private void btnViewSystem_Click(object sender, EventArgs e)
        {
            changeVisibility();

            lstSystemData.Visible = true;
        }

        private void getSystemData()
        {
            getHardwareData("Win32_Processor");
            getHardwareData("Win32_DiskDrive");
            getHardwareData("Win32_SoundDevice");
            getHardwareData("Win32_VideoController");
            getHardwareData("Win32_Keyboard");
            getHardwareData("Win32_PointingDevice");
            getHardwareData("Win32_NetworkAdapter");
        }

        private void getHardwareData(string hwclass)
        {
            //  Implemented from https://www.youtube.com/watch?v=rou471Evuzc
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                lstSystemData.Items.Add("Hardware Name: " + Convert.ToString(mj["Name"]));
                lstSystemData.Items.Add("Hardware Description: " + Convert.ToString(mj["Description"]));
                lstSystemData.Items.Add("Hardware System Name: " + Convert.ToString(mj["SystemName"]));
                lstSystemData.Items.Add("");
            }
        }

        private void btnViewSoftware_Click(object sender, EventArgs e)
        {
            changeVisibility();

            lstSoftwareData.Visible = true;
        }
    }
}