namespace StoreXManagement
{
    partial class frmAddProductcs
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.lblListProduct = new System.Windows.Forms.Label();
            this.lblSearchNotification = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbInformation = new System.Windows.Forms.GroupBox();
            this.lblErrorQuantity = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.pnlCustom.SuspendLayout();
            this.grbInformation.SuspendLayout();
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
            this.pnlControl.Size = new System.Drawing.Size(677, 37);
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
            this.btnClose.Location = new System.Drawing.Point(637, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.CategoryID,
            this.CategoryName});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduct.Location = new System.Drawing.Point(0, 109);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(677, 345);
            this.dgvProduct.TabIndex = 18;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // pnlCustom
            // 
            this.pnlCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustom.Controls.Add(this.lblSearchCategory);
            this.pnlCustom.Controls.Add(this.cboSearchCategory);
            this.pnlCustom.Controls.Add(this.lblListProduct);
            this.pnlCustom.Controls.Add(this.lblSearchNotification);
            this.pnlCustom.Controls.Add(this.lblSearchName);
            this.pnlCustom.Controls.Add(this.txtSearchName);
            this.pnlCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustom.Location = new System.Drawing.Point(0, 37);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(677, 72);
            this.pnlCustom.TabIndex = 19;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(264, 8);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(62, 16);
            this.lblSearchCategory.TabIndex = 27;
            this.lblSearchCategory.Text = "Category";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSearchCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(267, 27);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(172, 24);
            this.cboSearchCategory.TabIndex = 26;
            this.cboSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.cboSearchCategory_SelectionChangeCommitted);
            this.cboSearchCategory.TextChanged += new System.EventHandler(this.cboSearchCategory_TextChanged);
            this.cboSearchCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSearchCategory_KeyDown);
            // 
            // lblListProduct
            // 
            this.lblListProduct.AutoSize = true;
            this.lblListProduct.Location = new System.Drawing.Point(3, 54);
            this.lblListProduct.Name = "lblListProduct";
            this.lblListProduct.Size = new System.Drawing.Size(72, 16);
            this.lblListProduct.TabIndex = 25;
            this.lblListProduct.Text = "Product list";
            // 
            // lblSearchNotification
            // 
            this.lblSearchNotification.AutoSize = true;
            this.lblSearchNotification.ForeColor = System.Drawing.Color.Red;
            this.lblSearchNotification.Location = new System.Drawing.Point(478, 30);
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
            this.lblSearchName.Size = new System.Drawing.Size(50, 16);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Search";
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(10, 621);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbInformation
            // 
            this.grbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbInformation.Controls.Add(this.lblErrorQuantity);
            this.grbInformation.Controls.Add(this.txtTotalAmount);
            this.grbInformation.Controls.Add(this.lblTotalAmount);
            this.grbInformation.Controls.Add(this.txtQuantity);
            this.grbInformation.Controls.Add(this.lblQuantity);
            this.grbInformation.Controls.Add(this.txtInventory);
            this.grbInformation.Controls.Add(this.lblInventory);
            this.grbInformation.Controls.Add(this.txtPrice);
            this.grbInformation.Controls.Add(this.txtName);
            this.grbInformation.Controls.Add(this.lblPrice);
            this.grbInformation.Controls.Add(this.lblName);
            this.grbInformation.Location = new System.Drawing.Point(0, 460);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(677, 155);
            this.grbInformation.TabIndex = 20;
            this.grbInformation.TabStop = false;
            this.grbInformation.Text = "Selected product information";
            // 
            // lblErrorQuantity
            // 
            this.lblErrorQuantity.AutoSize = true;
            this.lblErrorQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQuantity.Location = new System.Drawing.Point(331, 101);
            this.lblErrorQuantity.Name = "lblErrorQuantity";
            this.lblErrorQuantity.Size = new System.Drawing.Size(0, 16);
            this.lblErrorQuantity.TabIndex = 10;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(103, 126);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(222, 22);
            this.txtTotalAmount.TabIndex = 9;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(4, 129);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(88, 16);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total amount:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(103, 98);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(222, 22);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(4, 101);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(103, 70);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.Size = new System.Drawing.Size(222, 22);
            this.txtInventory.TabIndex = 5;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(7, 73);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(64, 16);
            this.lblInventory.TabIndex = 4;
            this.lblInventory.Text = "Inventory:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(222, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(222, 22);
            this.txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 48);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(82, 621);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 29);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "formattedProduct_id";
            this.ProductID.FillWeight = 30F;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "InventoryQuantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Visible = false;
            // 
            // frmAddProductcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 659);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbInformation);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pnlCustom);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddProductcs";
            this.Text = "AddProductcs";
            this.Load += new System.EventHandler(this.frmAddProductcs_Load);
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.grbInformation.ResumeLayout(false);
            this.grbInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Label lblSearchNotification;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblListProduct;
        private System.Windows.Forms.GroupBox grbInformation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblErrorQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSearchCategory;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}