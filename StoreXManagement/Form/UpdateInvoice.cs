using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmUpdateInvoice : Form
    {
        private string staff;
        private string cus;
        private string cusID;
        private int invoiceID;
        SqlConnection connection;
        public frmUpdateInvoice(int invoiceID, string staff, string cus)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            this.staff = staff;
            this.cus = cus;
            this.invoiceID = invoiceID;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private DataTable dt;
        List<ProductAdd> Product = new List<ProductAdd>();
        public DataTable FillData()
        {
            string query = @"
                    SELECT 
                        InvoiceDetails.InvoiceDetailsID,
                        InvoiceDetails.ProductID,
                        Product.ProductName, 
                        InvoiceDetails.QuantityPurchase, 
                        InvoiceDetails.QuantityPurchase * Product.Price AS TotalPrice,
                        Customer.CustomerID
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
                    WHERE 
                        Customer.CustomerName = @CusName
                        AND Employee.EmployeeName = @EmpName";

            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@CusName", SqlDbType.VarChar).Value = cus;
            cmd.Parameters.AddWithValue("@EmpName", SqlDbType.VarChar).Value = staff;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cusID = reader["CustomerID"].ToString();
            }
            reader.Close();

            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(tbl);
            connection.Close();
            return tbl;
        }

        private DataTable GetSelectedProduct(List<ProductAdd> products)
        {
            foreach (var product in products)
            {
                if (product != null)
                {
                    dt.Rows.Add(0, product.ProID, product.ProName, product.QuantityAdd, product.TotalAmount, 0);
                } 
            }
            return dt;
        }

        public void FillCustomers(ComboBox cboCustomer)
        {
            string query = "SELECT CustomerID, CustomerName FROM Customer";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cboCustomer.DataSource = table;
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerID";
        }

        private decimal CalculateSum()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvInvoiceProduct.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    decimal amount = Convert.ToDecimal(row.Cells["Price"].Value);
                    totalAmount += amount;  
                }
            }
            return totalAmount;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Product.Clear();
            this.Close();
        }

        private void frmUpdateInvoice_Load(object sender, EventArgs e)
        {
            connection.Open();
            dt = FillData();
            dgvInvoiceProduct.DataSource = dt;
            FillCustomers(cboCustomer);
            cboCustomer.SelectedValue = cusID;
            txtStaff.Text = staff;
            txtTotalAmount.Text = CalculateSum().ToString();
        }
        private void DeleteInvoiceDetail(List<int> ID)
        {
            try
            {
                string deleteQuery = "DELETE FROM InvoiceDetails WHERE InvoiceDetailsID = @ID";
                connection.Open();
                SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                foreach (var id in ID)
                {
                    if (id == 0) continue;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                return;
            }
            finally { connection.Close(); }
        }

        List<int> listID = new List<int>();
        private void dgvInvoiceProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvInvoiceProduct.SelectedRows.Count == 0)
            {
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                if(MessageBox.Show("Are you sure want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvInvoiceProduct.CurrentRow.Cells["ProductID"].Value.ToString());
                    listID.Add(Convert.ToInt32(dgvInvoiceProduct.CurrentRow.Cells["InvoiceDetailsID"].Value.ToString()));
                    ProductAdd removeProduct = Product.Find(p => p.ProID == id);
                    if (removeProduct != null)
                    {
                        Product.Remove(removeProduct);
                    }            
                }
            }
            DataTable dt = GetSelectedProduct(Product);
            dgvInvoiceProduct.DataSource = dt;
        }

        private void UpdateInvoice()
        {
            try
            {
                string query = "UPDATE Invoice SET CustomerID = @CusID WHERE InvoiceID = @InID";
                connection.Open();
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.Parameters.Add("@InID", SqlDbType.Int).Value = invoiceID;
                cmd1.Parameters.Add("@cusID", SqlDbType.Int).Value = cboCustomer.SelectedValue;
                cmd1.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
                return;
            }
            finally { connection.Close(); }
        }

        private void InsertProductAddIntoInvoiceDetail()
        {
            try
            {
                int idStaff = 0;
                string find = "SELECT * FROM Employee WHERE EmployeeName = @Name";
                connection.Open();
                SqlCommand findid = new SqlCommand(find, connection);
                findid.Parameters.Add("@Name", SqlDbType.NVarChar).Value = staff;
                SqlDataReader reader = findid.ExecuteReader();
                if (reader.Read())
                {
                    idStaff = Convert.ToInt32(reader["EmployeeID"].ToString());
                }
                reader.Close();

                string query = @"
                                INSERT INTO InvoiceDetails (InvoiceID, EmployeeID, ProductID, QuantityPurchase)
                                VALUES (@id, @empid, @proid, @quantity)";
                SqlCommand cmd = new SqlCommand( query, connection);
                foreach (var product in Product)
                {
                    if (product == null) continue;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = invoiceID;
                    cmd.Parameters.Add("@empid", SqlDbType.Int).Value = idStaff;
                    cmd.Parameters.Add("@proid", SqlDbType.Int).Value = product.ProID;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = product.QuantityAdd;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductcs addProductcs = new frmAddProductcs();
            addProductcs.ShowDialog();

            Product.Add(addProductcs.SelectedProduct);

            dgvInvoiceProduct.DataSource = GetSelectedProduct(Product);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            connection.Close();
            DeleteInvoiceDetail(listID);
            UpdateInvoice();
            InsertProductAddIntoInvoiceDetail();

        }
    }
}
