
namespace CMP307Project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnViewHardware = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstSystemHardware = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.flpInsertAsset = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInsertSysName = new System.Windows.Forms.Label();
            this.txtInsertSysName = new System.Windows.Forms.TextBox();
            this.lblInsertModel = new System.Windows.Forms.Label();
            this.txtInsertModel = new System.Windows.Forms.TextBox();
            this.lblInsertManufacturer = new System.Windows.Forms.Label();
            this.txtInsertManufacturer = new System.Windows.Forms.TextBox();
            this.lblInsertAssType = new System.Windows.Forms.Label();
            this.txtInsertAssType = new System.Windows.Forms.TextBox();
            this.lblInsertIPAddr = new System.Windows.Forms.Label();
            this.txtInsertIPAddr = new System.Windows.Forms.TextBox();
            this.lblInsertPurchDate = new System.Windows.Forms.Label();
            this.txtInsertPurchDate = new System.Windows.Forms.TextBox();
            this.lblInsertNotes = new System.Windows.Forms.Label();
            this.txtInsertNotes = new System.Windows.Forms.TextBox();
            this.flpInsertButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInsertSubmit = new System.Windows.Forms.Button();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.flpLogin = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnViewSoftware = new System.Windows.Forms.Button();
            this.btnViewSystem = new System.Windows.Forms.Button();
            this.lstHardwareData = new System.Windows.Forms.ListBox();
            this.lstSoftwareData = new System.Windows.Forms.ListBox();
            this.lstSystemSoftware = new System.Windows.Forms.ListBox();
            this.flpSystemData = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInsertAsset.SuspendLayout();
            this.flpInsertButtons.SuspendLayout();
            this.flpLogin.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpSystemData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(294, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(798, 139);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ScottishGlen";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(12, 10);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(248, 136);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnViewHardware
            // 
            this.btnViewHardware.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewHardware.Enabled = false;
            this.btnViewHardware.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnViewHardware.Location = new System.Drawing.Point(12, 197);
            this.btnViewHardware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewHardware.Name = "btnViewHardware";
            this.btnViewHardware.Size = new System.Drawing.Size(248, 148);
            this.btnViewHardware.TabIndex = 2;
            this.btnViewHardware.Text = "View Hardware Data";
            this.btnViewHardware.UseVisualStyleBackColor = true;
            this.btnViewHardware.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(1177, 358);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(248, 139);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(1177, 514);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(248, 139);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(1177, 202);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(248, 139);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstSystemHardware
            // 
            this.lstSystemHardware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSystemHardware.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSystemHardware.FormattingEnabled = true;
            this.lstSystemHardware.HorizontalScrollbar = true;
            this.lstSystemHardware.ItemHeight = 19;
            this.lstSystemHardware.Location = new System.Drawing.Point(3, 2);
            this.lstSystemHardware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSystemHardware.Name = "lstSystemHardware";
            this.lstSystemHardware.Size = new System.Drawing.Size(433, 460);
            this.lstSystemHardware.TabIndex = 6;
            this.lstSystemHardware.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1177, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(248, 139);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close Program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flpInsertAsset
            // 
            this.flpInsertAsset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpInsertAsset.AutoSize = true;
            this.flpInsertAsset.BackColor = System.Drawing.Color.White;
            this.flpInsertAsset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpInsertAsset.Controls.Add(this.lblInsertSysName);
            this.flpInsertAsset.Controls.Add(this.txtInsertSysName);
            this.flpInsertAsset.Controls.Add(this.lblInsertModel);
            this.flpInsertAsset.Controls.Add(this.txtInsertModel);
            this.flpInsertAsset.Controls.Add(this.lblInsertManufacturer);
            this.flpInsertAsset.Controls.Add(this.txtInsertManufacturer);
            this.flpInsertAsset.Controls.Add(this.lblInsertAssType);
            this.flpInsertAsset.Controls.Add(this.txtInsertAssType);
            this.flpInsertAsset.Controls.Add(this.lblInsertIPAddr);
            this.flpInsertAsset.Controls.Add(this.txtInsertIPAddr);
            this.flpInsertAsset.Controls.Add(this.lblInsertPurchDate);
            this.flpInsertAsset.Controls.Add(this.txtInsertPurchDate);
            this.flpInsertAsset.Controls.Add(this.lblInsertNotes);
            this.flpInsertAsset.Controls.Add(this.txtInsertNotes);
            this.flpInsertAsset.Controls.Add(this.flpInsertButtons);
            this.flpInsertAsset.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInsertAsset.Location = new System.Drawing.Point(453, 149);
            this.flpInsertAsset.Name = "flpInsertAsset";
            this.flpInsertAsset.Size = new System.Drawing.Size(504, 544);
            this.flpInsertAsset.TabIndex = 8;
            this.flpInsertAsset.Visible = false;
            // 
            // lblInsertSysName
            // 
            this.lblInsertSysName.AutoSize = true;
            this.lblInsertSysName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertSysName.Location = new System.Drawing.Point(3, 0);
            this.lblInsertSysName.Name = "lblInsertSysName";
            this.lblInsertSysName.Size = new System.Drawing.Size(342, 23);
            this.lblInsertSysName.TabIndex = 0;
            this.lblInsertSysName.Text = "Enter the System Name (REQUIRED)";
            // 
            // txtInsertSysName
            // 
            this.txtInsertSysName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertSysName.Location = new System.Drawing.Point(3, 26);
            this.txtInsertSysName.Name = "txtInsertSysName";
            this.txtInsertSysName.Size = new System.Drawing.Size(494, 30);
            this.txtInsertSysName.TabIndex = 1;
            // 
            // lblInsertModel
            // 
            this.lblInsertModel.AutoSize = true;
            this.lblInsertModel.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertModel.Location = new System.Drawing.Point(3, 59);
            this.lblInsertModel.Name = "lblInsertModel";
            this.lblInsertModel.Size = new System.Drawing.Size(273, 23);
            this.lblInsertModel.TabIndex = 2;
            this.lblInsertModel.Text = "Enter the Model (REQUIRED)";
            // 
            // txtInsertModel
            // 
            this.txtInsertModel.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertModel.Location = new System.Drawing.Point(3, 85);
            this.txtInsertModel.Name = "txtInsertModel";
            this.txtInsertModel.Size = new System.Drawing.Size(494, 30);
            this.txtInsertModel.TabIndex = 3;
            // 
            // lblInsertManufacturer
            // 
            this.lblInsertManufacturer.AutoSize = true;
            this.lblInsertManufacturer.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertManufacturer.Location = new System.Drawing.Point(3, 118);
            this.lblInsertManufacturer.Name = "lblInsertManufacturer";
            this.lblInsertManufacturer.Size = new System.Drawing.Size(335, 23);
            this.lblInsertManufacturer.TabIndex = 4;
            this.lblInsertManufacturer.Text = "Enter the Manufacturer (REQUIRED)";
            // 
            // txtInsertManufacturer
            // 
            this.txtInsertManufacturer.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertManufacturer.Location = new System.Drawing.Point(3, 144);
            this.txtInsertManufacturer.Name = "txtInsertManufacturer";
            this.txtInsertManufacturer.Size = new System.Drawing.Size(494, 30);
            this.txtInsertManufacturer.TabIndex = 5;
            // 
            // lblInsertAssType
            // 
            this.lblInsertAssType.AutoSize = true;
            this.lblInsertAssType.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertAssType.Location = new System.Drawing.Point(3, 177);
            this.lblInsertAssType.Name = "lblInsertAssType";
            this.lblInsertAssType.Size = new System.Drawing.Size(317, 23);
            this.lblInsertAssType.TabIndex = 6;
            this.lblInsertAssType.Text = "Enter the Asset Type (REQUIRED)";
            // 
            // txtInsertAssType
            // 
            this.txtInsertAssType.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertAssType.Location = new System.Drawing.Point(3, 203);
            this.txtInsertAssType.Name = "txtInsertAssType";
            this.txtInsertAssType.Size = new System.Drawing.Size(494, 30);
            this.txtInsertAssType.TabIndex = 7;
            // 
            // lblInsertIPAddr
            // 
            this.lblInsertIPAddr.AutoSize = true;
            this.lblInsertIPAddr.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertIPAddr.Location = new System.Drawing.Point(3, 236);
            this.lblInsertIPAddr.Name = "lblInsertIPAddr";
            this.lblInsertIPAddr.Size = new System.Drawing.Size(316, 23);
            this.lblInsertIPAddr.TabIndex = 8;
            this.lblInsertIPAddr.Text = "Enter the IP Address (REQUIRED)";
            // 
            // txtInsertIPAddr
            // 
            this.txtInsertIPAddr.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertIPAddr.Location = new System.Drawing.Point(3, 262);
            this.txtInsertIPAddr.Name = "txtInsertIPAddr";
            this.txtInsertIPAddr.Size = new System.Drawing.Size(494, 30);
            this.txtInsertIPAddr.TabIndex = 9;
            // 
            // lblInsertPurchDate
            // 
            this.lblInsertPurchDate.AutoSize = true;
            this.lblInsertPurchDate.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertPurchDate.Location = new System.Drawing.Point(3, 295);
            this.lblInsertPurchDate.Name = "lblInsertPurchDate";
            this.lblInsertPurchDate.Size = new System.Drawing.Size(445, 23);
            this.lblInsertPurchDate.TabIndex = 10;
            this.lblInsertPurchDate.Text = "Enter the Purchase Date (Format YYYY-MM-DD)";
            // 
            // txtInsertPurchDate
            // 
            this.txtInsertPurchDate.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertPurchDate.Location = new System.Drawing.Point(3, 321);
            this.txtInsertPurchDate.Name = "txtInsertPurchDate";
            this.txtInsertPurchDate.Size = new System.Drawing.Size(494, 30);
            this.txtInsertPurchDate.TabIndex = 11;
            // 
            // lblInsertNotes
            // 
            this.lblInsertNotes.AutoSize = true;
            this.lblInsertNotes.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInsertNotes.Location = new System.Drawing.Point(3, 354);
            this.lblInsertNotes.Name = "lblInsertNotes";
            this.lblInsertNotes.Size = new System.Drawing.Size(148, 23);
            this.lblInsertNotes.TabIndex = 12;
            this.lblInsertNotes.Text = "Enter any notes";
            // 
            // txtInsertNotes
            // 
            this.txtInsertNotes.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInsertNotes.Location = new System.Drawing.Point(3, 380);
            this.txtInsertNotes.Name = "txtInsertNotes";
            this.txtInsertNotes.Size = new System.Drawing.Size(494, 30);
            this.txtInsertNotes.TabIndex = 13;
            // 
            // flpInsertButtons
            // 
            this.flpInsertButtons.Controls.Add(this.btnInsertSubmit);
            this.flpInsertButtons.Controls.Add(this.btnInsertCancel);
            this.flpInsertButtons.Location = new System.Drawing.Point(3, 416);
            this.flpInsertButtons.Name = "flpInsertButtons";
            this.flpInsertButtons.Size = new System.Drawing.Size(494, 123);
            this.flpInsertButtons.TabIndex = 14;
            // 
            // btnInsertSubmit
            // 
            this.btnInsertSubmit.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSubmit.Location = new System.Drawing.Point(3, 3);
            this.btnInsertSubmit.Name = "btnInsertSubmit";
            this.btnInsertSubmit.Size = new System.Drawing.Size(242, 120);
            this.btnInsertSubmit.TabIndex = 0;
            this.btnInsertSubmit.Text = "Submit";
            this.btnInsertSubmit.UseVisualStyleBackColor = true;
            this.btnInsertSubmit.Click += new System.EventHandler(this.btnInsertSubmit_Click);
            // 
            // btnInsertCancel
            // 
            this.btnInsertCancel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCancel.Location = new System.Drawing.Point(251, 3);
            this.btnInsertCancel.Name = "btnInsertCancel";
            this.btnInsertCancel.Size = new System.Drawing.Size(240, 120);
            this.btnInsertCancel.TabIndex = 1;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            this.btnInsertCancel.Click += new System.EventHandler(this.btnInsertCancel_Click);
            // 
            // flpLogin
            // 
            this.flpLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpLogin.BackColor = System.Drawing.Color.White;
            this.flpLogin.Controls.Add(this.lblUsername);
            this.flpLogin.Controls.Add(this.txtUsername);
            this.flpLogin.Controls.Add(this.lblPassword);
            this.flpLogin.Controls.Add(this.txtPassword);
            this.flpLogin.Controls.Add(this.flowLayoutPanel2);
            this.flpLogin.Location = new System.Drawing.Point(453, 294);
            this.flpLogin.Name = "flpLogin";
            this.flpLogin.Size = new System.Drawing.Size(498, 253);
            this.flpLogin.TabIndex = 11;
            this.flpLogin.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(257, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Please enter your username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUsername.Location = new System.Drawing.Point(3, 26);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(494, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPassword.Location = new System.Drawing.Point(3, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(257, 23);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Please enter your password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPassword.Location = new System.Drawing.Point(3, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(494, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSubmitLogin);
            this.flowLayoutPanel2.Controls.Add(this.btnCancelLogin);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 121);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(494, 123);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitLogin.Location = new System.Drawing.Point(3, 3);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(242, 120);
            this.btnSubmitLogin.TabIndex = 0;
            this.btnSubmitLogin.Text = "Submit";
            this.btnSubmitLogin.UseVisualStyleBackColor = true;
            this.btnSubmitLogin.Click += new System.EventHandler(this.btnSubmitLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Location = new System.Drawing.Point(251, 3);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(240, 120);
            this.btnCancelLogin.TabIndex = 1;
            this.btnCancelLogin.Text = "Cancel";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnViewSoftware
            // 
            this.btnViewSoftware.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewSoftware.Enabled = false;
            this.btnViewSoftware.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnViewSoftware.Location = new System.Drawing.Point(12, 353);
            this.btnViewSoftware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSoftware.Name = "btnViewSoftware";
            this.btnViewSoftware.Size = new System.Drawing.Size(248, 148);
            this.btnViewSoftware.TabIndex = 12;
            this.btnViewSoftware.Text = "View Software Data";
            this.btnViewSoftware.UseVisualStyleBackColor = true;
            this.btnViewSoftware.Click += new System.EventHandler(this.btnViewSoftware_Click);
            // 
            // btnViewSystem
            // 
            this.btnViewSystem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewSystem.Enabled = false;
            this.btnViewSystem.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnViewSystem.Location = new System.Drawing.Point(12, 509);
            this.btnViewSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSystem.Name = "btnViewSystem";
            this.btnViewSystem.Size = new System.Drawing.Size(248, 148);
            this.btnViewSystem.TabIndex = 13;
            this.btnViewSystem.Text = "View System Data";
            this.btnViewSystem.UseVisualStyleBackColor = true;
            this.btnViewSystem.Click += new System.EventHandler(this.btnViewSystem_Click);
            // 
            // lstHardwareData
            // 
            this.lstHardwareData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHardwareData.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHardwareData.FormattingEnabled = true;
            this.lstHardwareData.ItemHeight = 19;
            this.lstHardwareData.Location = new System.Drawing.Point(294, 202);
            this.lstHardwareData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstHardwareData.Name = "lstHardwareData";
            this.lstHardwareData.Size = new System.Drawing.Size(846, 460);
            this.lstHardwareData.TabIndex = 14;
            this.lstHardwareData.Visible = false;
            // 
            // lstSoftwareData
            // 
            this.lstSoftwareData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSoftwareData.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSoftwareData.FormattingEnabled = true;
            this.lstSoftwareData.ItemHeight = 19;
            this.lstSoftwareData.Location = new System.Drawing.Point(294, 202);
            this.lstSoftwareData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSoftwareData.Name = "lstSoftwareData";
            this.lstSoftwareData.Size = new System.Drawing.Size(846, 460);
            this.lstSoftwareData.TabIndex = 15;
            this.lstSoftwareData.Visible = false;
            // 
            // lstSystemSoftware
            // 
            this.lstSystemSoftware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSystemSoftware.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSystemSoftware.FormattingEnabled = true;
            this.lstSystemSoftware.HorizontalScrollbar = true;
            this.lstSystemSoftware.ItemHeight = 19;
            this.lstSystemSoftware.Location = new System.Drawing.Point(442, 2);
            this.lstSystemSoftware.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSystemSoftware.Name = "lstSystemSoftware";
            this.lstSystemSoftware.Size = new System.Drawing.Size(433, 460);
            this.lstSystemSoftware.TabIndex = 16;
            this.lstSystemSoftware.Visible = false;
            // 
            // flpSystemData
            // 
            this.flpSystemData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpSystemData.BackColor = System.Drawing.Color.White;
            this.flpSystemData.Controls.Add(this.lstSystemHardware);
            this.flpSystemData.Controls.Add(this.lstSystemSoftware);
            this.flpSystemData.Location = new System.Drawing.Point(277, 197);
            this.flpSystemData.Name = "flpSystemData";
            this.flpSystemData.Size = new System.Drawing.Size(884, 465);
            this.flpSystemData.TabIndex = 17;
            this.flpSystemData.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1477, 714);
            this.Controls.Add(this.flpSystemData);
            this.Controls.Add(this.lstSoftwareData);
            this.Controls.Add(this.lstHardwareData);
            this.Controls.Add(this.btnViewSystem);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnViewSoftware);
            this.Controls.Add(this.flpLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnViewHardware);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flpInsertAsset);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpInsertAsset.ResumeLayout(false);
            this.flpInsertAsset.PerformLayout();
            this.flpInsertButtons.ResumeLayout(false);
            this.flpLogin.ResumeLayout(false);
            this.flpLogin.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpSystemData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnViewHardware;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstSystemHardware;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpInsertAsset;
        private System.Windows.Forms.Label lblInsertSysName;
        private System.Windows.Forms.TextBox txtInsertSysName;
        private System.Windows.Forms.Label lblInsertModel;
        private System.Windows.Forms.TextBox txtInsertModel;
        private System.Windows.Forms.Label lblInsertManufacturer;
        private System.Windows.Forms.TextBox txtInsertManufacturer;
        private System.Windows.Forms.Label lblInsertAssType;
        private System.Windows.Forms.TextBox txtInsertAssType;
        private System.Windows.Forms.Label lblInsertIPAddr;
        private System.Windows.Forms.TextBox txtInsertIPAddr;
        private System.Windows.Forms.Label lblInsertPurchDate;
        private System.Windows.Forms.TextBox txtInsertPurchDate;
        private System.Windows.Forms.Label lblInsertNotes;
        private System.Windows.Forms.TextBox txtInsertNotes;
        private System.Windows.Forms.FlowLayoutPanel flpInsertButtons;
        private System.Windows.Forms.Button btnInsertSubmit;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.FlowLayoutPanel flpLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnViewSoftware;
        private System.Windows.Forms.Button btnViewSystem;
        private System.Windows.Forms.ListBox lstHardwareData;
        private System.Windows.Forms.ListBox lstSoftwareData;
        private System.Windows.Forms.ListBox lstSystemSoftware;
        private System.Windows.Forms.FlowLayoutPanel flpSystemData;
    }
}