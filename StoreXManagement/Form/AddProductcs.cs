using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmAddProductcs : Form
    {
        SqlConnection connection;
        public frmAddProductcs()
        {
            InitializeComponent();
            /*_addInvoiceForm = addInvoiceForm;*/
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
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

        private void frmAddProductcs_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            FillCategories(cboSearchCategory);
            cboSearchCategory.Text = string.Empty;
        }

        public void FillData()
        {
            string query = @"
                            SELECT 
                                'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                ProductName,
                                InventoryQuantity,
                                Price,
                                CategoryID
                            FROM 
                                Product
                            WHERE
                                InventoryQuantity != 0;
                                ";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvProduct.DataSource = tbl;
            connection.Close();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
                row.Selected = true;
                txtName.Text = row.Cells["ProductName"].Value.ToString();
                txtInventory.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity_TextChanged(sender, e);
            }
            catch
            {
                return;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                lblErrorQuantity.Text = "";
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int check1))
            {
                lblErrorQuantity.Text = "add number, not alphabet";
                return;
            }

            int quantity = Convert.ToInt32(txtQuantity.Text);
            int inventory = Convert.ToInt32(txtInventory.Text);
            if (quantity > inventory) 
            {
                lblErrorQuantity.Text = "Quantity can't higher than Product";
                return;
            }
            else if(quantity < 0)
            {
                lblErrorQuantity.Text = "Quantity can't be negative number";
                return;
            }

            decimal price = Convert.ToDecimal(txtPrice.Text);

            lblErrorQuantity.Text = string.Empty;
            txtTotalAmount.Text = (quantity * price).ToString();
        }

        public ProductAdd SelectedProduct {  get; private set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtQuantity_TextChanged(sender, e);

            if (dgvProduct.SelectedRows.Count == 0) 
            {
                MessageBox.Show("You aren't choose product yet","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                lblErrorQuantity.Text = "Please add quantity";
                return;
            }

            if (!lblErrorQuantity.Text.Equals(""))
            {
                MessageBox.Show("Still have error from quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try 
            {
                int id = Convert.ToInt32(dgvProduct.CurrentRow.Cells[1].Value.ToString().Replace("PD", ""));
                string name = txtName.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);
                decimal totalAmount = Convert.ToDecimal(txtTotalAmount.Text);

                SelectedProduct = new ProductAdd(id, name, quantity, totalAmount);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {   
            string Name = txtSearchName.Text;

            string searchName = @"
                                SELECT 'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                    ProductName,
                                    InventoryQuantity,
                                    Price,
                                    CategoryID
                                FROM
                                    Product                              
                                WHERE
                                    ProductName LIKE @searchName";          

            connection.Open();

            SqlDataAdapter adapterName = new SqlDataAdapter(searchName, connection);
            adapterName.SelectCommand.Parameters.AddWithValue("@searchName", "%" + Name + "%");
            DataTable tbl = new DataTable();
            adapterName.Fill(tbl);
            if (tbl != null && tbl.Rows.Count > 0)
            {
                lblSearchNotification.Text = "";
                dgvProduct.DataSource = tbl;
            }
            else
            {
                FillData();
                lblSearchNotification.Text = "Not found";
            }
            connection.Close();                        
        }

        public void FillCategories(ComboBox cboCategory)
        {
            string query = "SELECT CategoryID, CategoryName FROM CategoryList";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            cboCategory.DataSource = table;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryID";
        }

        private void cboSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSearchName.Text = string.Empty;
            int id = Convert.ToInt32(cboSearchCategory.SelectedValue.ToString());
            //Query search category
            string searchCategory = @"
                                        SELECT 
                                            'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                            ProductName,
                                            InventoryQuantity,
                                            Price,
                                            CategoryID                                     
                                        FROM 
                                            Product                                   
                                        WHERE 
                                            CategoryID = @searchCategory;";
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(searchCategory, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@searchCategory", id);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            if (tbl != null && tbl.Rows.Count > 0)
            {
                lblSearchNotification.Text = "";
                dgvProduct.DataSource = tbl;
            }
            else
            {
                lblSearchNotification.Text = "Not found";
            }
            connection.Close();
        }

        private void cboSearchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboSearchCategory.SelectedValue == null)
                {
                    lblSearchNotification.Text = "Not found";
                    return;
                }
                cboSearchCategory_SelectionChangeCommitted(sender, e);
            }
        }

        private void cboSearchCategory_TextChanged(object sender, EventArgs e)
        {
            if(cboSearchCategory.SelectedValue == null)
            {
                FillData();
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
