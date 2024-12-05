namespace StoreXManagement
{
    partial class frmProductManagement
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
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblPriceError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblIdError = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.lblSearchNotification = new System.Windows.Forms.Label();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.timeNotification = new System.Windows.Forms.Timer(this.components);
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdd.Controls.Add(this.btnEditCategory);
            this.pnlAdd.Controls.Add(this.lblNotification);
            this.pnlAdd.Controls.Add(this.btnBrowse);
            this.pnlAdd.Controls.Add(this.picImage);
            this.pnlAdd.Controls.Add(this.txtImage);
            this.pnlAdd.Controls.Add(this.lblImage);
            this.pnlAdd.Controls.Add(this.cboCategory);
            this.pnlAdd.Controls.Add(this.lblCategoryError);
            this.pnlAdd.Controls.Add(this.lblCategory);
            this.pnlAdd.Controls.Add(this.btnUpdate);
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnInsert);
            this.pnlAdd.Controls.Add(this.lblQuantityError);
            this.pnlAdd.Controls.Add(this.lblPriceError);
            this.pnlAdd.Controls.Add(this.lblNameError);
            this.pnlAdd.Controls.Add(this.lblIdError);
            this.pnlAdd.Controls.Add(this.txtQuantity);
            this.pnlAdd.Controls.Add(this.txtPrice);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Controls.Add(this.txtID);
            this.pnlAdd.Controls.Add(this.lblQuantity);
            this.pnlAdd.Controls.Add(this.lblPrice);
            this.pnlAdd.Controls.Add(this.lblName);
            this.pnlAdd.Controls.Add(this.lblID);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAdd.Location = new System.Drawing.Point(977, 56);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(316, 619);
            this.pnlAdd.TabIndex = 3;
            this.pnlAdd.Visible = false;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.Image = global::StoreXManagement.Properties.Resources.edit_darkColor;
            this.btnEditCategory.Location = new System.Drawing.Point(276, 199);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(25, 24);
            this.btnEditCategory.TabIndex = 22;
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotification.AutoSize = true;
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(10, 551);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 16);
            this.lblNotification.TabIndex = 21;
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.Image = global::StoreXManagement.Properties.Resources.open_file_DarkColor;
            this.btnBrowse.Location = new System.Drawing.Point(278, 255);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 22);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(116, 283);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(188, 168);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 19;
            this.picImage.TabStop = false;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(115, 255);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(157, 22);
            this.txtImage.TabIndex = 6;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblImage.Location = new System.Drawing.Point(3, 258);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(48, 16);
            this.lblImage.TabIndex = 16;
            this.lblImage.Text = "Image:";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(116, 199);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(156, 24);
            this.cboCategory.TabIndex = 5;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryError.Location = new System.Drawing.Point(3, 226);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(0, 16);
            this.lblCategoryError.TabIndex = 14;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCategory.Location = new System.Drawing.Point(3, 203);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category:";
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
            this.btnUpdate.TabIndex = 10;
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
            this.btnCancel.TabIndex = 9;
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
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(3, 174);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(0, 16);
            this.lblQuantityError.TabIndex = 11;
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.ForeColor = System.Drawing.Color.Red;
            this.lblPriceError.Location = new System.Drawing.Point(3, 125);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(0, 16);
            this.lblPriceError.TabIndex = 10;
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
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(116, 148);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(187, 22);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(116, 99);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(116, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 22);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Automatic ID";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblQuantity.Location = new System.Drawing.Point(3, 151);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Product Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(72, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Product ID:";
            // 
            // pnlCustom
            // 
            this.pnlCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustom.Controls.Add(this.lblSearchNotification);
            this.pnlCustom.Controls.Add(this.picRefresh);
            this.pnlCustom.Controls.Add(this.btnSearch);
            this.pnlCustom.Controls.Add(this.lblSearchCategory);
            this.pnlCustom.Controls.Add(this.cboSearchCategory);
            this.pnlCustom.Controls.Add(this.btnAdd);
            this.pnlCustom.Controls.Add(this.lblSearch);
            this.pnlCustom.Controls.Add(this.txtSearchName);
            this.pnlCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustom.Location = new System.Drawing.Point(0, 0);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(1293, 56);
            this.pnlCustom.TabIndex = 12;
            // 
            // lblSearchNotification
            // 
            this.lblSearchNotification.AutoSize = true;
            this.lblSearchNotification.ForeColor = System.Drawing.Color.Red;
            this.lblSearchNotification.Location = new System.Drawing.Point(99, 8);
            this.lblSearchNotification.Name = "lblSearchNotification";
            this.lblSearchNotification.Size = new System.Drawing.Size(0, 16);
            this.lblSearchNotification.TabIndex = 23;
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::StoreXManagement.Properties.Resources.refresh_darkColor;
            this.picRefresh.Location = new System.Drawing.Point(472, 27);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(27, 25);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 19;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::StoreXManagement.Properties.Resources.search_darkColor1;
            this.btnSearch.Location = new System.Drawing.Point(266, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(291, 7);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(62, 16);
            this.lblSearchCategory.TabIndex = 17;
            this.lblSearchCategory.Text = "Category";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(294, 27);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(172, 24);
            this.cboSearchCategory.TabIndex = 2;
            this.cboSearchCategory.SelectionChangeCommitted += new System.EventHandler(this.cboSearchCategory_SelectionChangeCommitted);
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
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(90, 16);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.Location = new System.Drawing.Point(3, 27);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(258, 22);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.CategoryID,
            this.Category,
            this.Image});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 56);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1293, 619);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyDown);
            // 
            // timeNotification
            // 
            this.timeNotification.Interval = 5000;
            this.timeNotification.Tick += new System.EventHandler(this.timeNotification_Tick);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "formattedProduct_id";
            this.ProductID.FillWeight = 40F;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 10;
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
            this.Price.FillWeight = 40F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "InventoryQuantity";
            this.Quantity.FillWeight = 40F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
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
            // Category
            // 
            this.Category.DataPropertyName = "CategoryName";
            this.Category.FillWeight = 50F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 675);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.pnlCustom);
            this.Name = "frmProductManagement";
            this.Text = "ProductManagement";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblIdError;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.ComboBox cboSearchCategory;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.Timer timeNotification;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Label lblSearchNotification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}