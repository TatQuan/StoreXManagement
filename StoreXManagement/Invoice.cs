using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmInvoice : Form
    {
        public User user;
        SqlConnection connection;

        public frmInvoice(User user)
        {
            this.user = user;
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
        }
        public void AddIcon()
        {
            btnAdd.Text = "Add";
            btnAdd.Image = StoreXManagement.Properties.Resources.add_lightColor;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
        }
        public void EditIcon()
        {
            btnAdd.Image = StoreXManagement.Properties.Resources.edit_lightColor;
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdd.Text = "Edit";
        }


        public void FillData()
        {
            string query = @"
                    SELECT 
                        'IV' + RIGHT('00000' + CAST(MIN(Invoice.InvoiceID) AS VARCHAR(5)), 5) AS formattedInvoice_id,
                        Customer.CustomerName,
                        Employee.EmployeeName,
                        MIN(Invoice.InvoicingDate) AS InvoicingDate,
                        SUM(InvoiceDetails.QuantityPurchase * Product.Price) AS TotalPrice
                    FROM 
                        InvoiceDetails
                    JOIN
                        Invoice ON Invoice.InvoiceID = InvoiceDetails.InvoiceID
                    JOIN
                        Product ON Product.ProductID = InvoiceDetails.ProductID
                    JOIN
                        Customer ON Customer.CustomerID = Invoice.CustomerID
                    JOIN
                        Employee ON Employee.EmployeeID = InvoiceDetails.EmployeeID
                    GROUP BY 
                        Customer.CustomerID, Employee.EmployeeID, Customer.CustomerName, Employee.EmployeeName ";
                    
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvInvoice.DataSource = tbl;
            connection.Close();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();

            switch (user.Access)
            {
                case "Admin":
                case "Sales staff":
                    btnAdd.Visible = true;
                    break;
                case "Warehouse staff":
                case "Employees":
                    btnAdd.Visible = false;
                    break;
                default:
                    dgvInvoice.Visible = false;
                    break;
            }

        }

        public string cusName;
        public string staff;
        public int invoiceID;
        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoice.Rows.Count)
            {
                cusName = dgvInvoice.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
                staff = dgvInvoice.Rows[e.RowIndex].Cells["EmployeeName"].Value.ToString();
                invoiceID = Convert.ToInt32(dgvInvoice.Rows[e.RowIndex].Cells["InvoiceID"].Value.ToString().Replace("IV", ""));
                
                EditIcon();
            }
            else 
            {
                dgvInvoice.ClearSelection();
                AddIcon();
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Edit"))
            {
                frmUpdateInvoice update = new frmUpdateInvoice(invoiceID, staff, cusName);

                update.FormClosed += (s, args) =>
                {
                    connection.Open();
                    try
                    {
                        this.FillData();

                    }
                    catch
                    {
                        connection.Close();
                        return;
                    }
                };
                update.ShowDialog();
            }
            else
            {
                frmAddInvoice frmAdd = new frmAddInvoice(user);

                //When frmAddInvoice is close, datagridview in this form will load again
                frmAdd.FormClosed += (s, args) =>
                {
                    connection.Open();
                    try
                    {
                        this.FillData();

                    }
                    catch
                    {
                        connection.Close();
                        return;
                    }
                };
                frmAdd.ShowDialog();
            }
        }

        private void dgvInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dgvInvoice.ClearSelection();
                AddIcon();
            }
            else if (e.KeyCode == Keys.Delete)
            {

            }
        }
    }
}
