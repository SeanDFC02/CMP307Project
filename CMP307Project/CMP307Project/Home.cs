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

        public void InsertData() // Receives the data from the database and inserts it into the necessary list boxes
        {
            //  Clears the list boxes to avoid duplication
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
                //  Inserts data into the list box lstHardwareData
                lstHardwareData.Items.Add(data[0] + "\t" + data[1] + "\t\t" + data[2] + "\t" + data[3] + "\t" + data[4] + "\t" + data[5] + "\t" + data[6] + "\t" + data[7]);
            }
            data.Close();

            //  Second Select Query
            string SWQuery = "SELECT * FROM SCOT.SOFTWARE";

            SqlCommand Comm = new SqlCommand(SWQuery);

            Comm.Connection = conn;

            SqlDataReader SWData = Comm.ExecuteReader();
            lstSoftwareData.Items.Add("AssNum\tOS Name\tVersion\tManufacturer");
            while (SWData.Read())
            {
                //  Inserts data into the list box lstSoftwareData
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

            //  Message box that provides the user with two options
            DialogResult AddData = MessageBox.Show("Press Yes to Add Hardware Data, Press No to Add Software Data", "Add Data", MessageBoxButtons.YesNo);
            if (AddData == DialogResult.Yes)
            {
                changeVisibility();
                //  Brings up the Add Hardware flp
                flpAddHardware.Visible = true;                
            }
            else
            {
                changeVisibility();
                //  Brings up the Add Software flp
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

            //  Error testing ensuring that all required inputs are inputted
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

                //  Inserts hardware data into the database
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
            //  Brings up the login flp
            flpLogin.Visible = true;
        }

        private void changeVisibility()
        {
            //  Hides everything whenever the changeVisibility function is run
            //  to avoid having more than one list box or flp on screen at a time
            flpLogin.Visible = false;
            flpAddHardware.Visible = false;
            lstSystemHardware.Visible = false;
            lstHardwareData.Visible = false;
            lstSoftwareData.Visible = false;
            flpSystemData.Visible = false;
            flpAddSoftware.Visible = false;
            flpEditHardware.Visible = false;
            flpEditSoftware.Visible = false;
            flpDelSW.Visible = false;
            flpDelHW.Visible = false;
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            //  Declares local variables with the info received from the text input boxes
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();
            string userPass;

            //  Select Query
            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);
            conn.Open();

            string query = "SELECT * FROM SCOT.STAFF WHERE UserName = '" + username + "';";
            SqlCommand  command = new SqlCommand(query, conn);
            SqlDataReader data = command.ExecuteReader();

            //  if the username and/or password is blank then this is run
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                txtUsername.Clear();
                txtPassword.Clear();
                //  Shows a message stating that the username and/or password cant be left blank
                MessageBox.Show("A username and password must be inputted to log in.");
            }
            //  If data matching the username is found in the table
            else if (data.HasRows)
            {
                while (data.Read())
                {
                    userPass = Convert.ToString(data[1]);
                    //  Runs if the passwords match
                    // Example password and user if needed is Admin and Admin
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

                        //  Shows the user a success message
                        MessageBox.Show("User has successfully logged in!");
                    }
                    else
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        //  Shows the user a message that the password or username is incorrect
                        MessageBox.Show("Incorrect username or password. Please try again");
                    }
                }
            }
            else
            //  If the username doesnt match to the data in the table
            {
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("Incorrect username or password. Please try again.");
            }
        }

        private void btnViewSystem_Click(object sender, EventArgs e)
        {
            changeVisibility();
            InsertData();

            flpSystemData.Visible = true;
            lstSystemHardware.Visible = true;
            lstSystemSoftware.Visible = true;
        }

        private void getSystemData()
        {
            //  gets the hardware data using the Win32 classes
            getHardwareData("Win32_Processor");
            getHardwareData("Win32_DiskDrive");
            getHardwareData("Win32_SoundDevice");
            getHardwareData("Win32_VideoController");
            getHardwareData("Win32_Keyboard");
            getHardwareData("Win32_PointingDevice");
            getHardwareData("Win32_NetworkAdapter");

            //  Gets the software data using the Win32 classes
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
                //  Gets the info needed for each item in the Win32 class
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
                //  Gets the info needed for each item in the Win32 class
                lstSystemSoftware.Items.Add("Software Name: " + Convert.ToString(mj["Name"]));
                lstSystemSoftware.Items.Add("Software Description: " + Convert.ToString(mj["Description"]));
                lstSystemSoftware.Items.Add("Software Status: " + Convert.ToString(mj["Status"]));
                lstSystemSoftware.Items.Add("");
            }
        }

        private void btnViewSoftware_Click(object sender, EventArgs e)
        {
            //  shows the software data list box
            changeVisibility();
            InsertData();

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

            //  Gives the user a choice to select to edit the hardware data or the software data
            DialogResult AddData = MessageBox.Show("Press Yes to Edit Hardware Data, Press No to Edit Software Data", "Edit Data", MessageBoxButtons.YesNo);
            if (AddData == DialogResult.Yes)
            {
                changeVisibility();
                txtEditHWAN.Clear();
                txtEditHWField.Clear();
                txtEditHWDataInput.Enabled = false;
                txtEditHWDataInput.Clear();
                flpEditHardware.Visible = true;
            }
            else
            {
                changeVisibility();
                txtEditSWAN.Clear();
                txtEditSWField.Clear();
                txtEditSWDataInput.Enabled = false;
                txtEditSWDataInput.Clear();
                flpEditSoftware.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            changeVisibility();
            //  Gives the user a choice to select to delete the hardware data or the software data
            DialogResult AddData = MessageBox.Show("Press Yes to Delete Hardware Data, Press No to Delete Software Data", "Delete Data", MessageBoxButtons.YesNo);
            if (AddData == DialogResult.Yes)
            {
                changeVisibility();
                txtDelHWAN.Clear();
                flpDelHW.Visible = true;
            }
            else
            {
                changeVisibility();
                txtDelSWAN.Clear();
                flpDelSW.Visible = true;
            }

        }

        private void btnEditHWCancel_Click(object sender, EventArgs e)
        {
            //  Hides form after cancel button has been pressed
            flpEditHardware.Visible = false;
        }

        private void btnEditHWSubmit_Click(object sender, EventArgs e)
        {
            //  Declares local variables using info from the text input boxes
            int EditHWAN = int.Parse(txtEditHWAN.Text);
            string EditHWDataInput = txtEditHWDataInput.Text.ToString();
            string EditHWField = txtEditHWField.Text.ToString();

            //  Update query
            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");

            string query = "UPDATE SCOT.HARDWARE SET Model = '" + EditHWDataInput + "' WHERE AssetNum = '" + EditHWAN + "';";
            SqlCommand Command = new SqlCommand(query);
            Command.Connection = conn;

            MessageBox.Show("Hardware table updated successfully!");

            int result = Command.ExecuteNonQuery();
            
            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            changeVisibility();
        }

        private void btnbtnEditHWSubmitFields_Click(object sender, EventArgs e)
        {
            txtEditHWDataInput.Enabled = true;
        }

        private void btnEditSWFieldSubmit_Click(object sender, EventArgs e)
        {
            txtEditSWDataInput.Enabled = true;
        }

        private void btnEditSWSubmit_Click(object sender, EventArgs e)
        {
            //  Declares local variables with the input from the text input boxes
            int EditSWAN = int.Parse(txtEditSWAN.Text);
            string EditSWDataInput = txtEditSWDataInput.Text.ToString();
            string EditSWField = txtEditSWField.Text.ToString();

            //  Update query
            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");
                        
            string query = "UPDATE SCOT.SOFTWARE SET Manufacturer = '" + EditSWDataInput + "' WHERE AssetNum = '" + EditSWAN + "';";
            SqlCommand Command = new SqlCommand(query);
            Command.Connection = conn;

            MessageBox.Show("Software table updated successfully!");

            int result = Command.ExecuteNonQuery();

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            changeVisibility();

        }

        private void btnEditSWCancel_Click(object sender, EventArgs e)
        {
            //  Hides form after cancel button has been pressed
            flpEditSoftware.Visible = false;
        }

        //  btnDelHWSubmit_Click
        private void btnDelSWSubmit_Click(object sender, EventArgs e)
        {
            int DelHWAN = int.Parse(txtDelHWAN.Text);

            //  Delete query
            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");

            string query = "DELETE FROM SCOT.HARDWARE WHERE AssetNum = '" + DelHWAN + "';";
            SqlCommand Command = new SqlCommand(query);
            Command.Connection = conn;

            MessageBox.Show("Software table updated successfully!");

            int result = Command.ExecuteNonQuery();

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            changeVisibility();
        }

        //  btnDeleteSWData
        private void button1_Click(object sender, EventArgs e)
        {
            int DelSWAN = int.Parse(txtDelSWAN.Text);


            //  Delete query
            SqlConnection conn;
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql2002590; User ID = mssql2002590; Password = huG72W6hwB";
            conn = new SqlConnection(connString);

            conn.Open();
            Console.WriteLine("Connection Successfully established.\n");

            string query = "DELETE FROM SCOT.SOFTWARE WHERE AssetNum = '" + DelSWAN + "';";
            SqlCommand Command = new SqlCommand(query);
            Command.Connection = conn;

            MessageBox.Show("Software table updated successfully!");

            int result = Command.ExecuteNonQuery();

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");

            changeVisibility();
        }

        private void btnDelSWCancel_Click(object sender, EventArgs e)
        {
            flpDelSW.Visible = false;
        }

        private void btnDelHWCancel_Click(object sender, EventArgs e)
        {
            flpDelHW.Visible = false;
        }
    }
}