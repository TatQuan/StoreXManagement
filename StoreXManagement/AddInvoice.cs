using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmAddInvoice : Form
    {
        SqlConnection connection;
        private User staff;
        List<ProductAdd> productAdd = new List<ProductAdd>();
        public frmAddInvoice(User user)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            staff = user;
            txtStaff.Text = staff.EmpName;

            FillCustomers(cboCustomer);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {
            
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

        //Get Data soucre into table from liss products class
        private DataTable GetSelectedProduct(List<ProductAdd> products)
        {
            DataTable tbl = new DataTable();

            tbl.Columns.Add("ProductID");
            tbl.Columns.Add("ProductName");
            tbl.Columns.Add("Quantity");
            tbl.Columns.Add("TotalAmount");

            foreach (var product in products)
            {
                if (product == null) continue;
                tbl.Rows.Add(product.ProID, product.ProName, product.QuantityAdd, product.TotalAmount);
                
            }
            return tbl;
     
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductcs addProductcs = new frmAddProductcs();
            addProductcs.ShowDialog();

            productAdd.Add(addProductcs.SelectedProduct);
 
            DataTable table = GetSelectedProduct(productAdd);
            dgvInvoiceProduct.DataSource = table;

                
        }

        private int InsertQuery()
        {
            int error = 0;
            string insertInvoice = @"
                                    INSERT INTO Invoice (CustomerID, InvoicingDate) OUTPUT INSERTED.InvoiceID
                                    VALUES (@cusid, @date)";
            string insertDetails = @"
                                    INSERT INTO InvoiceDetails (InvoiceID, EmployeeID, ProductID, QuantityPurchase)
                                    VALUES (@id, @empid, @proid, @quantity)";

            SqlTransaction transaction = null;
            try
            {
                //Start transaction make sure if one of them error will be cancel insert all
                connection.Open();
                transaction = connection.BeginTransaction();

                //insert into table invoice first
                SqlCommand cmd1 = new SqlCommand(insertInvoice, connection, transaction);
                cmd1.Parameters.Add("@cusid", SqlDbType.Int).Value = cboCustomer.SelectedValue.ToString();
                cmd1.Parameters.Add("@date", SqlDbType.Date).Value = dtmInvoice.Value;

                //Get ID Invoice just insert to insert table invoice details
                int invoiceID = (int)cmd1.ExecuteScalar();

                //Insert into invoice details
                SqlCommand cmd2 = new SqlCommand(insertDetails, connection, transaction);
                foreach (var product in productAdd)
                {
                    if (product == null) continue;
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.Add("@id", SqlDbType.Int).Value = invoiceID;
                    cmd2.Parameters.Add("@empid", SqlDbType.Int).Value = staff.EmpID;
                    cmd2.Parameters.Add("@proid", SqlDbType.Int).Value = product.ProID;
                    cmd2.Parameters.Add("@quantity", SqlDbType.Int).Value = product.QuantityAdd;
                    cmd2.ExecuteNonQuery();
                    
                }
                transaction.Commit();



                MessageBox.Show("successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error: " + ex.Message);

                error++;
            }
            finally
            {
                connection.Close();
            }
            return error;
        }

        private void UpdateInventoryAndInventoryTransactions()
        {
            string TransType = "Export";
            string queryTrans = @"INSERT INTO InventoryTransactions OUTPUT INSERTED.Quantity
                             VALUES (@ProID,@TransType,@quantity,@TransDate,@EmpID)";
            string query = "UPDATE Product SET InventoryQuantity = InventoryQuantity + @quantity WHERE ProductID = @proID";

            connection.Open();
            SqlCommand cmd1 = new SqlCommand(queryTrans , connection);
            SqlCommand cmd2 = new SqlCommand(query, connection);
            try
            {
                foreach (var product in productAdd)
                {
                    if(product == null) continue;
                    cmd1.Parameters.Clear();
                    cmd1.Parameters.Add("@ProID", SqlDbType.Int).Value = product.ProID;
                    cmd1.Parameters.Add("@TransType", SqlDbType.NVarChar).Value = TransType;
                    cmd1.Parameters.Add("@quantity", SqlDbType.Int).Value = -product.QuantityAdd;
                    cmd1.Parameters.Add("@TransDate", SqlDbType.Date).Value = dtmInvoice.Value;
                    cmd1.Parameters.Add("@EmpID", SqlDbType.Int).Value = staff.EmpID;

                    int quantitiy = 0;
                    var result = cmd1.ExecuteScalar();
                    if (result != null)
                    {
                        quantitiy = Convert.ToInt32(result);
                    }

                    cmd2.Parameters.Clear();
                    cmd2.Parameters.Add("@proID", SqlDbType.Int).Value = product.ProID;
                    cmd2.Parameters.Add("@quantity", SqlDbType.Int).Value= quantitiy;
                    cmd2.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            connection.Close();
        }

        private void btnSaveOrAdd_Click(object sender, EventArgs e)
        {
            string errorMess = "";
            if (cboCustomer.SelectedValue == null)
            {
                errorMess += " Customer";              
            }

            if (string.IsNullOrEmpty(dtmInvoice.Text))
            {
                errorMess += " Invoice date";
            }   
            if (string.IsNullOrEmpty(txtStaff.Text))
            {
                errorMess += "Invoicing Staff";
            }

            if (!string.IsNullOrEmpty(errorMess))
            {
                MessageBox.Show(errorMess + " can't be blank");
                return;
            }

            foreach(var product in productAdd)
            {
                if(product != null)
                {

                }
            }
            if (productAdd.Count == 0)
            {
                MessageBox.Show("No products have been added yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int error = InsertQuery();
            if (error == 0)
            {
                UpdateInventoryAndInventoryTransactions();
                btnCancel_Click(sender, e);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            productAdd.Clear();
            btnClose_Click(sender, e);
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("Automatic ID"))
            {
                txtID.Text = string.Empty;
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.Text = "Automatic ID";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void dgvInvoiceProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvInvoiceProduct.SelectedRows.Count == 0)
            { 
                return; 
            }
            if(e.KeyCode == Keys.Delete)
            {
                int id = Convert.ToInt32(dgvInvoiceProduct.CurrentRow.Cells["ProductID"].Value.ToString());
                ProductAdd removeProduct = productAdd.Find(p => p.ProID == id);
                if(removeProduct != null)
                {
                    productAdd.Remove(removeProduct);
                }
            }
            DataTable dt = GetSelectedProduct(productAdd);
            dgvInvoiceProduct.DataSource = dt;
        }

        private void dgvInvoiceProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInvoiceProduct.Rows[e.RowIndex].Selected = true;
        }
    }
}
