namespace StoreXManagement
{
    partial class frmEmployeeManagement
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
            this.components = new System.ComponentModel.Container();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.lblSearchNotification = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.lblNotification = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblPassError = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblUserNameError = new System.Windows.Forms.Label();
            this.lblPositionError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblIdError = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.timeNotification = new System.Windows.Forms.Timer(this.components);
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picHideShow = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCustom.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHideShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustom
            // 
            this.pnlCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustom.Controls.Add(this.lblSearchNotification);
            this.pnlCustom.Controls.Add(this.picRefresh);
            this.pnlCustom.Controls.Add(this.btnSearch);
            this.pnlCustom.Controls.Add(this.btnAdd);
            this.pnlCustom.Controls.Add(this.lblSearchName);
            this.pnlCustom.Controls.Add(this.txtSearchName);
            this.pnlCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustom.Location = new System.Drawing.Point(0, 0);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(1293, 56);
            this.pnlCustom.TabIndex = 2;
            // 
            // lblSearchNotification
            // 
            this.lblSearchNotification.AutoSize = true;
            this.lblSearchNotification.ForeColor = System.Drawing.Color.Red;
            this.lblSearchNotification.Location = new System.Drawing.Point(96, 8);
            this.lblSearchNotification.Name = "lblSearchNotification";
            this.lblSearchNotification.Size = new System.Drawing.Size(0, 16);
            this.lblSearchNotification.TabIndex = 24;
            // 
            // lblSearchName
            // 
            this.lblSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(3, 8);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(87, 16);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Search name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.Location = new System.Drawing.Point(3, 27);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(258, 22);
            this.txtSearchName.TabIndex = 2;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.picHideShow);
            this.pnlAdd.Controls.Add(this.lblNotification);
            this.pnlAdd.Controls.Add(this.cboPosition);
            this.pnlAdd.Controls.Add(this.lblPassError);
            this.pnlAdd.Controls.Add(this.txtPassword);
            this.pnlAdd.Controls.Add(this.lblPassword);
            this.pnlAdd.Controls.Add(this.btnUpdate);
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnInsert);
            this.pnlAdd.Controls.Add(this.lblUserNameError);
            this.pnlAdd.Controls.Add(this.lblPositionError);
            this.pnlAdd.Controls.Add(this.lblNameError);
            this.pnlAdd.Controls.Add(this.lblIdError);
            this.pnlAdd.Controls.Add(this.txtUserName);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblUserName);
            this.pnlAdd.Controls.Add(this.lblPosition);
            this.pnlAdd.Controls.Add(this.lblName);
            this.pnlAdd.Controls.Add(this.lblID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(977, 56);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(316, 619);
            this.pnlAdd.TabIndex = 3;
            this.pnlAdd.Visible = false;
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotification.AutoSize = true;
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(10, 530);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 16);
            this.lblNotification.TabIndex = 22;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Employees",
            "Sales staff",
            "Warehouse staff",
            "Admin"});
            this.cboPosition.Location = new System.Drawing.Point(116, 98);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(185, 24);
            this.cboPosition.TabIndex = 6;
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.ForeColor = System.Drawing.Color.Red;
            this.lblPassError.Location = new System.Drawing.Point(3, 218);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(0, 16);
            this.lblPassError.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Location = new System.Drawing.Point(3, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(231, 583);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 31);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(123, 582);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInsert.Location = new System.Drawing.Point(13, 582);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 31);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblUserNameError
            // 
            this.lblUserNameError.AutoSize = true;
            this.lblUserNameError.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameError.Location = new System.Drawing.Point(3, 171);
            this.lblUserNameError.Name = "lblUserNameError";
            this.lblUserNameError.Size = new System.Drawing.Size(0, 16);
            this.lblUserNameError.TabIndex = 11;
            // 
            // lblPositionError
            // 
            this.lblPositionError.AutoSize = true;
            this.lblPositionError.ForeColor = System.Drawing.Color.Red;
            this.lblPositionError.Location = new System.Drawing.Point(3, 125);
            this.lblPositionError.Name = "lblPositionError";
            this.lblPositionError.Size = new System.Drawing.Size(0, 16);
            this.lblPositionError.TabIndex = 10;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(3, 77);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 16);
            this.lblNameError.TabIndex = 9;
            // 
            // lblIdError
            // 
            this.lblIdError.AutoSize = true;
            this.lblIdError.ForeColor = System.Drawing.Color.Red;
            this.lblIdError.Location = new System.Drawing.Point(3, 29);
            this.lblIdError.Name = "lblIdError";
            this.lblIdError.Size = new System.Drawing.Size(0, 16);
            this.lblIdError.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(116, 146);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 22);
            this.txtUserName.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(116, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 22);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "Automatic ID";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserName.Location = new System.Drawing.Point(3, 151);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 102);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 16);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(112, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Employee Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Employee ID:";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Position,
            this.UserName,
            this.Password});
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 56);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1293, 619);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmployee_KeyDown);
            // 
            // timeNotification
            // 
            this.timeNotification.Interval = 5000;
            this.timeNotification.Tick += new System.EventHandler(this.timeNotification_Tick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "formattedEmployee_id";
            this.EmployeeID.FillWeight = 35F;
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.FillWeight = 60F;
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // picHideShow
            // 
            this.picHideShow.Image = global::StoreXManagement.Properties.Resources.show_darkColor;
            this.picHideShow.Location = new System.Drawing.Point(280, 193);
            this.picHideShow.Name = "picHideShow";
            this.picHideShow.Size = new System.Drawing.Size(21, 22);
            this.picHideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHideShow.TabIndex = 23;
            this.picHideShow.TabStop = false;
            this.picHideShow.Click += new System.EventHandler(this.picHideShow_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::StoreXManagement.Properties.Resources.refresh_darkColor;
            this.picRefresh.Location = new System.Drawing.Point(297, 26);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(27, 25);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 21;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::StoreXManagement.Properties.Resources.search_darkColor1;
            this.btnSearch.Location = new System.Drawing.Point(267, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Image = global::StoreXManagement.Properties.Resources.add_lightColor;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1209, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 675);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.pnlCustom);
            this.Name = "frmEmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHideShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblUserNameError;
        private System.Windows.Forms.Label lblPositionError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblIdError;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label lblPassError;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.PictureBox picHideShow;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchNotification;
        private System.Windows.Forms.Timer timeNotification;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}