using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using StoreXManagement.DataStoreTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace StoreXManagement
{
    public partial class frmReport : Form
    {
        SqlConnection connection;
        private User GetUser;
        public frmReport(User getUser)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            GetUser = getUser;
        }

        //Fill data function
        private void FillData(string query, ReportViewer reportViewer)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            ReportDataSource rds = new ReportDataSource("DataTable", dt);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            // Refresh Report
            reportViewer.RefreshReport();
        }

        //Search function
        private void SearchTimeData(string query, ReportViewer reportViewer)
        {
            string from = this.dtmStart.Value.ToString("MM/dd/yyyy");
            string to = this.dtmEnd.Value.ToString("MM/dd/yyyy");

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@start", from);
            adapter.SelectCommand.Parameters.AddWithValue("@end", to);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            ReportDataSource rds = new ReportDataSource("DataTable", dt);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            // Refresh Report
            reportViewer.RefreshReport();
        }
        private void Searchname(string query, ReportViewer reportViewer) 
        {
            string name = txtSearch.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@name", name);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            ReportDataSource rds = new ReportDataSource("DataTable", dt);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            // Refresh Report
            reportViewer.RefreshReport();
        }

        //Function From
        private void frmReport_Load(object sender, System.EventArgs e)
        {
            connection.Open();

            switch (GetUser.Access)
            {
                case "Admin":
                    string queryPro = @"
                            SELECT 
                                'PD' + RIGHT('00000' + CAST(p.ProductID AS VARCHAR(5)), 5) AS ID, 
                                p.ProductName, 
                                SUM(id.QuantityPurchase) AS QuantityTotal, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            GROUP BY 
                                p.ProductID, p.ProductName";

                    tabStatistics.SelectedIndex = 0;                    
                    FillData(queryPro, ReportProduct);
                    break;
                case "Warehouse staff":
                case "Sales staff":
                case "Employees":
                default:
                    connection.Close();
                    break;
            }

           
        }

        private void tabStatistics_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string queryPro = @"
                            SELECT 
                                'PD' + RIGHT('00000' + CAST(p.ProductID AS VARCHAR(5)), 5) AS ID, 
                                p.ProductName, 
                                SUM(id.QuantityPurchase) AS QuantityTotal, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            GROUP BY 
                                p.ProductID, p.ProductName";
            string queryEmp = @"
                            SELECT 
                                'EP' + RIGHT('00000' + CAST(e.EmployeeID AS VARCHAR(5)), 5) AS ID, 
                                e.EmployeeName AS Name, 
                                COUNT(i.InvoiceID) AS TotalInvoice, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Employee e ON id.EmployeeID = e.EmployeeID
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            GROUP BY 
                                e.EmployeeID, e.EmployeeName";
            string queryCus = @"
                            SELECT 
                                'CT' + RIGHT('00000' + CAST(c.CustomerID AS VARCHAR(5)), 5) AS ID, 
                                c.CustomerName AS Name, 
                                COUNT(i.InvoiceID) AS TotalInvoice, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Customer c ON c.CustomerID = i.CustomerID
                            GROUP BY 
                                c.CustomerID, c.CustomerName";

            connection.Open();
            switch (tabStatistics.SelectedIndex) 
            {
                case 0:
                    FillData(queryPro, ReportProduct);
                    break;
                case 1:
                    FillData(queryEmp, ReportEmployee);
                    break;
                case 2:
                    FillData(queryCus, ReportCustomer);
                    break;
                default:
                    connection.Close();
                    break;                    
            }
        }

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            string queryPro = @"
                        SELECT  'PD' + RIGHT('00000' + CAST(p.ProductID AS VARCHAR(5)), 5) AS ID, p.ProductName, SUM(id.QuantityPurchase) AS QuantityTotal, SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                        FROM  InvoiceDetails AS id INNER JOIN
                              Product AS p ON id.ProductID = p.ProductID 
                        INNER JOIN  Invoice AS i ON id.InvoiceID = i.InvoiceID
                        WHERE  (p.ProductName LIKE @name)
                        GROUP  BY p.ProductID, p.ProductName";
            string queryEmp = @"
                            SELECT 'EP' + RIGHT('00000' + CAST(e.EmployeeID AS VARCHAR(5)), 5) AS ID, e.EmployeeName AS Name, COUNT(i.InvoiceID) AS TotalInvoice, SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM  InvoiceDetails AS id INNER JOIN
                                  Product AS p ON id.ProductID = p.ProductID INNER JOIN
                                  Employee AS e ON id.EmployeeID = e.EmployeeID INNER JOIN
                                  Invoice AS i ON id.InvoiceID = i.InvoiceID
                            WHERE  (e.EmployeeName LIKE @name)
                            GROUP BY e.EmployeeID, e.EmployeeName";
            string queryCus = @"
                            SELECT 
                                'CT' + RIGHT('00000' + CAST(c.CustomerID AS VARCHAR(5)), 5) AS ID, 
                                c.CustomerName AS Name, 
                                COUNT(i.InvoiceID) AS TotalInvoice, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Customer c ON c.CustomerID = i.CustomerID
                            WHERE  (c.CustomerName LIKE @name)
                            GROUP BY 
                                c.CustomerID, c.CustomerName";

            connection.Open();
            switch (tabStatistics.SelectedIndex)
            {
                case 0:
                    Searchname(queryPro, ReportProduct);
                    break;
                case 1:
                    Searchname(queryEmp, ReportEmployee);
                    break;
                case 2:
                    Searchname(queryCus, ReportCustomer);
                    break;
                default:
                    connection.Close();
                    break;
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {            
            tabStatistics_SelectedIndexChanged(sender, e);
        }

        private void dtmMonth_ValueChanged(object sender, EventArgs e)
        {
            string queryPro = @"
                        SELECT  'PD' + RIGHT('00000' + CAST(p.ProductID AS VARCHAR(5)), 5) AS ID, p.ProductName, SUM(id.QuantityPurchase) AS QuantityTotal, SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                        FROM  InvoiceDetails AS id INNER JOIN
                              Product AS p ON id.ProductID = p.ProductID 
                        INNER JOIN  Invoice AS i ON id.InvoiceID = i.InvoiceID
                        WHERE  (i.InvoicingDate BETWEEN @start AND @end)
                        GROUP  BY p.ProductID, p.ProductName";
            string queryEmp = @"
                            SELECT 'EP' + RIGHT('00000' + CAST(e.EmployeeID AS VARCHAR(5)), 5) AS ID, e.EmployeeName AS Name, COUNT(i.InvoiceID) AS TotalInvoice, SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM  InvoiceDetails AS id INNER JOIN
                                  Product AS p ON id.ProductID = p.ProductID INNER JOIN
                                  Employee AS e ON id.EmployeeID = e.EmployeeID INNER JOIN
                                  Invoice AS i ON id.InvoiceID = i.InvoiceID
                            WHERE  (i.InvoicingDate BETWEEN @start AND @end)
                            GROUP BY e.EmployeeID, e.EmployeeName";
            string queryCus = @"
                            SELECT 
                                'CT' + RIGHT('00000' + CAST(c.CustomerID AS VARCHAR(5)), 5) AS ID, 
                                c.CustomerName AS Name, 
                                COUNT(i.InvoiceID) AS TotalInvoice, 
                                SUM(id.QuantityPurchase * p.Price) AS TotalPrice
                            FROM 
                                InvoiceDetails id
                            JOIN 
                                Invoice i ON id.InvoiceID = i.InvoiceID
                            JOIN 
                                Product p ON id.ProductID = p.ProductID
                            JOIN 
                                Customer c ON c.CustomerID = i.CustomerID
                            WHERE  (i.InvoicingDate BETWEEN @start AND @end)
                            GROUP BY 
                                c.CustomerID, c.CustomerName";

            connection.Open();
            switch (tabStatistics.SelectedIndex)
            {
                case 0:
                    SearchTimeData(queryPro, ReportProduct);
                    break;
                case 1:
                    SearchTimeData(queryEmp, ReportEmployee);
                    break;
                case 2:
                    SearchTimeData(queryCus, ReportCustomer);
                    break;
                default:
                    connection.Close();
                    break;
            }
        }

        private void dtmEnd_ValueChanged(object sender, EventArgs e)
        {
            dtmMonth_ValueChanged(sender, e);
        }
    }
}
