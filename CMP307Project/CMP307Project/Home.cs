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
            lstHardwareData.Items.Clear();
            lstSoftwareData.Items.Clear();

            //  Select query
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";

            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
            string query = "SELECT * FROM SCOT.HARDWARE";

            SqlCommand Command = new SqlCommand(query);

            Command.Connection = conn;

            SqlDataReader data = Command.ExecuteReader();
            lstHardwareData.Items.Add("AssNum\tSystem Name\tModel\tManufacture\tType\tIP\t\tPurchase Date\t\tNotes");
            while (data.Read())
            {
                //  Inserts data into the list box lstView
                lstHardwareData.Items.Add(data[0] + "\t" + data[1] + "\t\t" + data[2] + "\t" + data[3] + "\t" + data[4] + "\t" + data[5] + "\t" + data[6] + "\t" + data[7]);
            }
            data.Close();

            string SWQuery = "SELECT * FROM SCOT.SOFTWARE";

            SqlCommand Comm = new SqlCommand(SWQuery);

            Comm.Connection = conn;

            SqlDataReader SWData = Comm.ExecuteReader();
            lstSoftwareData.Items.Add("AssNum\tOS Name\tVersion\tManufacturer");
            while (SWData.Read())
            {
                //  Inserts data into the list box lstView
                lstSoftwareData.Items.Add(SWData[0] + "\t" + SWData[1] + "\t" + SWData[2] + "\t" + SWData[3]);
            }
            SWData.Close();

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

            DialogResult AddData = MessageBox.Show("Press Yes to Add Hardware Data, Press No to Add Software Data", "Add Data", MessageBoxButtons.YesNo);
            if (AddData == DialogResult.Yes)
            {
                changeVisibility();
                flpAddHardware.Visible = true;                
            }
            else
            {
                changeVisibility();
                flpAddSoftware.Visible = true;
            }
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

            if (InsertSysName == "")
            {
                MessageBox.Show("One or more required text boxes are not filled in");
            }
            else if (InsertModel == "")
            {
                MessageBox.Show("One or more required text boxes are not filled in");
            }
            else if (InsertManufacturer == "")
            {
                MessageBox.Show("One or more required text boxes are not filled in");
            }
            else if (InsertAssType == "")
            {
                MessageBox.Show("One or more required text boxes are not filled in");
            }
            else if (InsertIP == "")
            {
                MessageBox.Show("One or more required text boxes are not filled in");
            }
            else
            {
                //  Insert query
                SqlConnection conn;

                string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";

                conn = new SqlConnection(connString);

                conn.Open();
                Console.WriteLine("Connection successfully established.\n");

                string insertQuery = "INSERT INTO SCOT.HARDWARE (SystemName, Model, Manufacturer, AssetType, IPAddress, PurchaseDate, Notes) VALUES " +
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
                lstHardwareData.Items.Clear();
                lstSoftwareData.Items.Clear();

                //  Runs the insert data function again so that the
                //  new data will be present in the list box when viewed
                InsertData();

                //  Pop-up alert stating Data was successfully added
                MessageBox.Show("Your data was successfully inputted into the database");
            }            
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
            changeVisibility();
            flpLogin.Visible = true;
        }

        private void changeVisibility()
        {
            flpLogin.Visible = false;
            flpAddHardware.Visible = false;
            lstSystemHardware.Visible = false;
            lstHardwareData.Visible = false;
            lstSoftwareData.Visible = false;
            flpSystemData.Visible = false;
            flpAddSoftware.Visible = false;
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

            flpSystemData.Visible = true;
            lstSystemHardware.Visible = true;
            lstSystemSoftware.Visible = true;
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

            getSoftwareData("Win32_ComputerSystem");
            getSoftwareData("Win32_OperatingSystem");
            getSoftwareData("Win32_Registry");
            getSoftwareData("Win32_Service");
        }

        private void getHardwareData(string hwclass)
        {
            //  Implemented from https://www.youtube.com/watch?v=rou471Evuzc
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                lstSystemHardware.Items.Add("Hardware Name: " + Convert.ToString(mj["Name"]));
                lstSystemHardware.Items.Add("Hardware Description: " + Convert.ToString(mj["Description"]));
                lstSystemHardware.Items.Add("Hardware System Name: " + Convert.ToString(mj["SystemName"]));
                lstSystemHardware.Items.Add("");
            }
        }

        private void getSoftwareData(string hwclass)
        {
            //  Implemented from https://www.youtube.com/watch?v=rou471Evuzc
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                lstSystemSoftware.Items.Add("Software Name: " + Convert.ToString(mj["Name"]));
                lstSystemSoftware.Items.Add("Software Description: " + Convert.ToString(mj["Description"]));
                lstSystemSoftware.Items.Add("Software Status: " + Convert.ToString(mj["Status"]));
                lstSystemSoftware.Items.Add("");
            }
        }

        private void btnViewSoftware_Click(object sender, EventArgs e)
        {
            changeVisibility();

            lstSoftwareData.Visible = true;
        }

        private void btnCancelSoftware_Click(object sender, EventArgs e)
        {
            txtSWOSName.Clear();
            txtSWVersion.Clear();
            txtSWManufacturer.Clear();

            changeVisibility();
        }

        private void btnSubmitSoftware_Click(object sender, EventArgs e)
        {
            //  Declares local variables with user text input
            string InsertSWOSName = txtSWOSName.Text.ToString();
            string InsertSWVersion = txtSWVersion.Text.ToString();
            string InsertSWManufacturer = txtSWManufacturer.Text.ToString();

            //  Insert query
            SqlConnection conn;

            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";

            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection successfully established.\n");

            string insertQuery = "INSERT INTO SCOT.SOFTWARE (SystemName, SystemVersion, Manufacturer) VALUES " +
                "('" + InsertSWOSName + "', '" + InsertSWVersion + "', '" + InsertSWManufacturer + "');";

            SqlCommand Insertcommand = new SqlCommand(insertQuery, conn);
            int n = Insertcommand.ExecuteNonQuery();
            Console.WriteLine(n + " rows affected");

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            //  Clears all text boxes after data has been submitted
            txtSWOSName.Clear();
            txtSWManufacturer.Clear();
            txtSWVersion.Clear();

            changeVisibility();

            //  Clears the list box lstView, ready to receive the new data
            lstSoftwareData.Items.Clear();

            //  Runs the insert data function again so that the
            //  new data will be present in the list box when viewed
            InsertData();

            //  Pop-up alert stating Data was successfully added
            MessageBox.Show("Your data was successfully inputted into the database");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            changeVisibility();

            DialogResult AddData = MessageBox.Show("Press Yes to Edit Hardware Data, Press No to Edit Software Data", "Edit Data", MessageBoxButtons.YesNo);
            if (AddData == DialogResult.Yes)
            {
                changeVisibility();
                flpEditHardware.Visible = true;
            }
            else
            {
                changeVisibility();
                //flpEditSoftware.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEditHWCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnEditHWSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}