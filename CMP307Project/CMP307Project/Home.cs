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
            lstView.Items.Add("AssNum\tSystem Name\tModel\tManufacturer\tType\tIP\t\tPurchase Date\t\tNotes");
            while (data.Read())
            {
                //  Inserts data into the list box lstView
                lstView.Items.Add(data[0] + "\t" + data[1] + "\t" + data[2] + "\t" + data[3] + "\t" + data[4] + "\t" + data[5] + "\t" + data[6] + "\t" + data[7]);
            }
            data.Close();

            conn.Close();
            Console.WriteLine("\nConnection successfully terminated.");
        }

        private void GetComponent(string hwclass, string syntax)
        {
            //  Implemented from Youtube https://www.youtube.com/watch?v=rou471Evuzc
            lstViewAutoData.Visible = true;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                lstViewAutoData.Items.Add((Convert.ToString(mj[syntax])) + "\r\n");
            }
        }

        private void btnViewAutoData_Click(object sender, EventArgs e)
        {
            btnViewAutoData.Visible = false;
            int i = 0;  //  Declares counter initially 0;

            lstViewAutoData.Visible = true;
            lstViewAutoData.Items.Add("AssNum\tSystem Name\tManufacturer\tType");
            GetComponent("Win32_Processor", "Name");
            GetComponent("Win32_VideoController", "Name");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   //  Closes the program when button is pressed
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstViewAutoData.Visible = false;
            flpInsertAsset.Visible = false; //  Ensures that the form is closed if it isn't already
            lstView.Visible = true; //  Shows the list box containing all the data from the database
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            flpInsertAsset.Visible = true;  //  Shows the form that allows the user to insert data
            lstView.Visible = false;    //  Hides the list box lstView
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

            //  Hides form after data has been submitted
            flpInsertAsset.Visible = false;

            //  Clears the list box lstView, ready to receive the new data
            lstView.Items.Clear();

            //  Runs the insert data function again so that the
            //  new data will be present in the list box when viewed
            InsertData();

            //  Pop-up alert stating Data was successfully added
            System.Windows.Forms.MessageBox.Show("Your data was successfully inputted into the database");
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

            //  Hides form after cancel button has been pressed
            flpInsertAsset.Visible = false;
        }
    }
}