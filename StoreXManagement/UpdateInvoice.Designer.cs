namespace StoreXManagement
{
    partial class frmUpdateInvoice
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInvoiceProduct = new System.Windows.Forms.DataGridView();
            this.lblListProduct = new System.Windows.Forms.Label();
            this.lblUpdateInvoice = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.lblInvoiceStaff = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.InvoiceDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).BeginInit();
            this.SuspendLayout();
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
            this.pnlControl.Size = new System.Drawing.Size(827, 37);
            this.pnlControl.TabIndex = 17;
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
            this.btnClose.Location = new System.Drawing.Point(787, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvInvoiceProduct
            // 
            this.dgvInvoiceProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInvoiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceDetailsID,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price,
            this.CustomerID});
            this.dgvInvoiceProduct.Location = new System.Drawing.Point(305, 106);
            this.dgvInvoiceProduct.Name = "dgvInvoiceProduct";
            this.dgvInvoiceProduct.ReadOnly = true;
            this.dgvInvoiceProduct.RowHeadersWidth = 51;
            this.dgvInvoiceProduct.RowTemplate.Height = 24;
            this.dgvInvoiceProduct.Size = new System.Drawing.Size(520, 282);
            this.dgvInvoiceProduct.TabIndex = 18;
            this.dgvInvoiceProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInvoiceProduct_KeyDown);
            // 
            // lblListProduct
            // 
            this.lblListProduct.AutoSize = true;
            this.lblListProduct.Location = new System.Drawing.Point(302, 87);
            this.lblListProduct.Name = "lblListProduct";
            this.lblListProduct.Size = new System.Drawing.Size(130, 16);
            this.lblListProduct.TabIndex = 19;
            this.lblListProduct.Text = "List product selected";
            // 
            // lblUpdateInvoice
            // 
            this.lblUpdateInvoice.AutoSize = true;
            this.lblUpdateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateInvoice.Location = new System.Drawing.Point(298, 41);
            this.lblUpdateInvoice.Name = "lblUpdateInvoice";
            this.lblUpdateInvoice.Size = new System.Drawing.Size(200, 38);
            this.lblUpdateInvoice.TabIndex = 20;
            this.lblUpdateInvoice.Text = "View Invoice";
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(121, 144);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(166, 22);
            this.txtStaff.TabIndex = 21;
            // 
            // lblInvoiceStaff
            // 
            this.lblInvoiceStaff.AutoSize = true;
            this.lblInvoiceStaff.Location = new System.Drawing.Point(20, 147);
            this.lblInvoiceStaff.Name = "lblInvoiceStaff";
            this.lblInvoiceStaff.Size = new System.Drawing.Size(92, 16);
            this.lblInvoiceStaff.TabIndex = 28;
            this.lblInvoiceStaff.Text = "Invoicing Staff:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(12, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(212, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Location = new System.Drawing.Point(212, 220);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 48);
            this.btnAddProduct.TabIndex = 25;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(121, 106);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(166, 24);
            this.cboCustomer.TabIndex = 23;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 106);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 16);
            this.lblCustomer.TabIndex = 22;
            this.lblCustomer.Text = "Customer:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalAmount.Location = new System.Drawing.Point(121, 181);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(166, 22);
            this.txtTotalAmount.TabIndex = 22;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 184);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(86, 16);
            this.lblTotalAmount.TabIndex = 29;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // InvoiceDetailsID
            // 
            this.InvoiceDetailsID.DataPropertyName = "InvoiceDetailsID";
            this.InvoiceDetailsID.HeaderText = "InvoiceDetailsID";
            this.InvoiceDetailsID.MinimumWidth = 6;
            this.InvoiceDetailsID.Name = "InvoiceDetailsID";
            this.InvoiceDetailsID.ReadOnly = true;
            this.InvoiceDetailsID.Visible = false;
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
            this.Quantity.DataPropertyName = "QuantityPurchase";
            this.Quantity.FillWeight = 50F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "TotalPrice";
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // frmUpdateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 393);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.lblInvoiceStaff);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblUpdateInvoice);
            this.Controls.Add(this.lblListProduct);
            this.Controls.Add(this.dgvInvoiceProduct);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateInvoice";
            this.Text = "UpdateInvoice";
            this.Load += new System.EventHandler(this.frmUpdateInvoice_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInvoiceProduct;
        private System.Windows.Forms.Label lblListProduct;
        private System.Windows.Forms.Label lblUpdateInvoice;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label lblInvoiceStaff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
    }
}