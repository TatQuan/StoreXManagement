namespace StoreXManagement
{
    partial class frmReport
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
            this.tabStatistics = new System.Windows.Forms.TabControl();
            this.Product = new System.Windows.Forms.TabPage();
            this.ReportProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Employee = new System.Windows.Forms.TabPage();
            this.ReportEmployee = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Customer = new System.Windows.Forms.TabPage();
            this.dtmStart = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.dtmEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.ReportCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabStatistics.SuspendLayout();
            this.Product.SuspendLayout();
            this.Employee.SuspendLayout();
            this.Customer.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStatistics
            // 
            this.tabStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStatistics.Controls.Add(this.Product);
            this.tabStatistics.Controls.Add(this.Employee);
            this.tabStatistics.Controls.Add(this.Customer);
            this.tabStatistics.Location = new System.Drawing.Point(0, 97);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.SelectedIndex = 0;
            this.tabStatistics.Size = new System.Drawing.Size(1293, 578);
            this.tabStatistics.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabStatistics.TabIndex = 5;
            this.tabStatistics.SelectedIndexChanged += new System.EventHandler(this.tabStatistics_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.Controls.Add(this.ReportProduct);
            this.Product.Location = new System.Drawing.Point(4, 25);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(1285, 549);
            this.Product.TabIndex = 0;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // ReportProduct
            // 
            this.ReportProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportProduct.LocalReport.ReportEmbeddedResource = "StoreXManagement.StatisticProduct.rdlc";
            this.ReportProduct.Location = new System.Drawing.Point(3, 3);
            this.ReportProduct.Name = "ReportProduct";
            this.ReportProduct.ServerReport.BearerToken = null;
            this.ReportProduct.Size = new System.Drawing.Size(1279, 543);
            this.ReportProduct.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.ReportEmployee);
            this.Employee.Location = new System.Drawing.Point(4, 25);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(1285, 549);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // ReportEmployee
            // 
            this.ReportEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportEmployee.LocalReport.ReportEmbeddedResource = "StoreXManagement.StatisticEmployee.rdlc";
            this.ReportEmployee.Location = new System.Drawing.Point(3, 3);
            this.ReportEmployee.Name = "ReportEmployee";
            this.ReportEmployee.ServerReport.BearerToken = null;
            this.ReportEmployee.Size = new System.Drawing.Size(1279, 543);
            this.ReportEmployee.TabIndex = 1;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.ReportCustomer);
            this.Customer.Location = new System.Drawing.Point(4, 25);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(1285, 549);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // dtmStart
            // 
            this.dtmStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmStart.CustomFormat = "dd/MM/yyyy";
            this.dtmStart.Location = new System.Drawing.Point(1003, 21);
            this.dtmStart.Name = "dtmStart";
            this.dtmStart.Size = new System.Drawing.Size(109, 22);
            this.dtmStart.TabIndex = 2;
            this.dtmStart.Value = new System.DateTime(2024, 12, 17, 0, 0, 0, 0);
            this.dtmStart.ValueChanged += new System.EventHandler(this.dtmMonth_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(954, 23);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 16);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "From";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(1003, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.picRefresh);
            this.groupBox.Controls.Add(this.dtmEnd);
            this.groupBox.Controls.Add(this.dtmStart);
            this.groupBox.Controls.Add(this.txtSearch);
            this.groupBox.Controls.Add(this.lblSearch);
            this.groupBox.Controls.Add(this.lblTo);
            this.groupBox.Controls.Add(this.lblFrom);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1293, 76);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filter";
            // 
            // picRefresh
            // 
            this.picRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRefresh.Image = global::StoreXManagement.Properties.Resources.refresh_darkColor;
            this.picRefresh.Location = new System.Drawing.Point(1260, 19);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(27, 25);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 21;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // dtmEnd
            // 
            this.dtmEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmEnd.CustomFormat = "dd/MM/yyyy";
            this.dtmEnd.Location = new System.Drawing.Point(1148, 21);
            this.dtmEnd.Name = "dtmEnd";
            this.dtmEnd.Size = new System.Drawing.Size(106, 22);
            this.dtmEnd.TabIndex = 3;
            this.dtmEnd.Value = new System.DateTime(2024, 12, 17, 0, 0, 0, 0);
            this.dtmEnd.ValueChanged += new System.EventHandler(this.dtmEnd_ValueChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(947, 57);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(1118, 23);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To";
            // 
            // ReportCustomer
            // 
            this.ReportCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportCustomer.LocalReport.ReportEmbeddedResource = "StoreXManagement.StatisticCustomer.rdlc";
            this.ReportCustomer.Location = new System.Drawing.Point(0, 0);
            this.ReportCustomer.Name = "ReportCustomer";
            this.ReportCustomer.ServerReport.BearerToken = null;
            this.ReportCustomer.Size = new System.Drawing.Size(1285, 549);
            this.ReportCustomer.TabIndex = 2;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 675);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.tabStatistics);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.tabStatistics.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.Employee.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStatistics;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtmStart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.DateTimePicker dtmEnd;
        private System.Windows.Forms.Label lblTo;
        private Microsoft.Reporting.WinForms.ReportViewer ReportProduct;
        private Microsoft.Reporting.WinForms.ReportViewer ReportEmployee;
        private Microsoft.Reporting.WinForms.ReportViewer ReportCustomer;
    }
}