namespace StoreXManagement
{
    partial class frmAddInvoice
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
            this.lblListProduct = new System.Windows.Forms.Label();
            this.dgvInvoiceProduct = new System.Windows.Forms.DataGridView();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.dtmInvoice = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblNewInvoice = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveOrAdd = new System.Windows.Forms.Button();
            this.lblInvoiceStaff = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).BeginInit();
            this.grpInvoice.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListProduct
            // 
            this.lblListProduct.AutoSize = true;
            this.lblListProduct.Location = new System.Drawing.Point(283, 111);
            this.lblListProduct.Name = "lblListProduct";
            this.lblListProduct.Size = new System.Drawing.Size(130, 16);
            this.lblListProduct.TabIndex = 15;
            this.lblListProduct.Text = "List product selected";
            // 
            // dgvInvoiceProduct
            // 
            this.dgvInvoiceProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInvoiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price});
            this.dgvInvoiceProduct.Location = new System.Drawing.Point(286, 130);
            this.dgvInvoiceProduct.Name = "dgvInvoiceProduct";
            this.dgvInvoiceProduct.ReadOnly = true;
            this.dgvInvoiceProduct.RowHeadersWidth = 51;
            this.dgvInvoiceProduct.RowTemplate.Height = 24;
            this.dgvInvoiceProduct.Size = new System.Drawing.Size(520, 282);
            this.dgvInvoiceProduct.TabIndex = 14;
            this.dgvInvoiceProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceProduct_CellClick);
            this.dgvInvoiceProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInvoiceProduct_KeyDown);
            // 
            // grpInvoice
            // 
            this.grpInvoice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpInvoice.Controls.Add(this.dtmInvoice);
            this.grpInvoice.Controls.Add(this.lblInvoiceID);
            this.grpInvoice.Controls.Add(this.txtID);
            this.grpInvoice.Controls.Add(this.lblInvoiceDate);
            this.grpInvoice.Location = new System.Drawing.Point(2, 149);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(273, 102);
            this.grpInvoice.TabIndex = 13;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice information";
            // 
            // dtmInvoice
            // 
            this.dtmInvoice.Location = new System.Drawing.Point(104, 65);
            this.dtmInvoice.Name = "dtmInvoice";
            this.dtmInvoice.Size = new System.Drawing.Size(156, 22);
            this.dtmInvoice.TabIndex = 21;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(6, 35);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(69, 16);
            this.lblInvoiceID.TabIndex = 3;
            this.lblInvoiceID.Text = "Invoice ID:";
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(104, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 22);
            this.txtID.TabIndex = 6;
            this.txtID.Text = "Automatic ID";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(6, 70);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(83, 16);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "Invoice date:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(106, 108);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(160, 24);
            this.cboCustomer.TabIndex = 12;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 111);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 16);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblNewInvoice
            // 
            this.lblNewInvoice.AutoSize = true;
            this.lblNewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewInvoice.Location = new System.Drawing.Point(279, 41);
            this.lblNewInvoice.Name = "lblNewInvoice";
            this.lblNewInvoice.Size = new System.Drawing.Size(262, 38);
            this.lblNewInvoice.TabIndex = 10;
            this.lblNewInvoice.Text = "Add New Invoice";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlControl.Controls.Add(this.lblUser);
            this.pnlControl.Controls.Add(this.btnClose);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(813, 37);
            this.pnlControl.TabIndex = 16;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUser.Location = new System.Drawing.Point(57, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::StoreXManagement.Properties.Resources.close_lightColor;
            this.btnClose.Location = new System.Drawing.Point(773, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Location = new System.Drawing.Point(104, 323);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 48);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(205, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveOrAdd
            // 
            this.btnSaveOrAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveOrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveOrAdd.Location = new System.Drawing.Point(4, 377);
            this.btnSaveOrAdd.Name = "btnSaveOrAdd";
            this.btnSaveOrAdd.Size = new System.Drawing.Size(75, 35);
            this.btnSaveOrAdd.TabIndex = 19;
            this.btnSaveOrAdd.Text = "Add";
            this.btnSaveOrAdd.UseVisualStyleBackColor = false;
            this.btnSaveOrAdd.Click += new System.EventHandler(this.btnSaveOrAdd_Click);
            // 
            // lblInvoiceStaff
            // 
            this.lblInvoiceStaff.AutoSize = true;
            this.lblInvoiceStaff.Location = new System.Drawing.Point(8, 268);
            this.lblInvoiceStaff.Name = "lblInvoiceStaff";
            this.lblInvoiceStaff.Size = new System.Drawing.Size(92, 16);
            this.lblInvoiceStaff.TabIndex = 20;
            this.lblInvoiceStaff.Text = "Invoicing Staff:";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(106, 265);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(156, 22);
            this.txtStaff.TabIndex = 7;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 50F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalAmount";
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Total";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // frmAddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 421);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lblInvoiceStaff);
            this.Controls.Add(this.btnSaveOrAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.lblListProduct);
            this.Controls.Add(this.dgvInvoiceProduct);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblNewInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddInvoice";
            this.Text = "AddInvoice";
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).EndInit();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListProduct;
        private System.Windows.Forms.DataGridView dgvInvoiceProduct;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNewInvoice;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveOrAdd;
        private System.Windows.Forms.Label lblInvoiceStaff;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.DateTimePicker dtmInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}