using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmProductManagement : Form
    {
        SqlConnection connection;
        private User GetUser;
        public frmProductManagement(User access)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            GetUser = access;
        }

        //Load data into datagridview
        public void FillData()
        {
            string query = @"
                            SELECT 
                                'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                ProductName,
                                Price,
                                InventoryQuantity,
                                Product.CategoryID,
                                CategoryList.CategoryName,
                                Image 
                            FROM 
                                Product 
                            JOIN 
                                CategoryList ON Product.CategoryID = CategoryList.CategoryID;";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvProduct.DataSource = tbl;
            connection.Close();
        }

        public void AddIcon()
        {
            btnAdd.Text = "Add";
            btnAdd.Image = StoreXManagement.Properties.Resources.add_lightColor;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
        }
        public void BackIcon() 
        {
            btnAdd.Text = "Back";
            btnAdd.Image = StoreXManagement.Properties.Resources.back_lightColor;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
        }
        public void EditIcon() 
        {
            btnAdd.Image = StoreXManagement.Properties.Resources.edit_lightColor;
            btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAdd.Text = "Edit";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add") || btnAdd.Text.Equals("Edit"))
            {
                pnlAdd.Visible = true;
                BackIcon();
            }
            else
            {
                pnlAdd.Visible = false;
                AddIcon();
                dgvProduct.ClearSelection();
            }
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            FillCategories(cboCategory);
            FillCategories(cboSearchCategory);

            switch (GetUser.Access)
            {
                case "Admin":
                case "Warehouse staff":
                    btnAdd.Visible = true;
                    break;
                case "Sales staff":
                case "Employees":
                    btnAdd.Visible = false;
                    break;
                default:
                    dgvProduct.Visible = false;
                    break;
            }


        }

        //Check value input function
        private void CheckValue(out string name, out string price, out string quantity, out string category, out int error)
        {
            name = txtName.Text;
            price = txtPrice.Text;
            quantity = txtQuantity.Text;
            category = cboCategory.SelectedValue.ToString();

            error = 0;
            //Quantity
            if (string.IsNullOrEmpty(quantity)|| quantity.Equals("0"))
            {
                lblQuantityError.Text = "Quantity can't be blank";
                error += 1;
                txtQuantity.Focus();
            }
            else 
            {
                if (int.TryParse(quantity, out int check))
                {
                    if (check < 0)
                    {
                        lblQuantityError.Text = "Quantity can't be negative number";
                        error += 1;
                        txtQuantity.Text = string.Empty;
                        txtQuantity.Focus();
                    }
                }
                else
                {
                    lblQuantityError.Text = string.Empty;
                }
            }

            //Price
            if (string.IsNullOrEmpty(price) || price.Equals("0"))
            {
                lblPriceError.Text = "Price can't be blank";
                error += 1;
                txtPrice.Focus();
            }
            else
            {
                if (decimal.TryParse(price, out decimal check))
                {
                    if (check < 0)
                    {
                        lblPriceError.Text = "Price can't be negative number";
                        error += 1;
                        txtPrice.Text = string.Empty;
                        txtPrice.Focus();
                    }
                }
                else
                {
                    lblPriceError.Text = string.Empty;
                }
            }

            //Name
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Product name can't be blank";
                error += 1;
                txtName.Focus();
            }
            else
            {
                lblNameError.Text = string.Empty;
            }
        }

        //Insert category into combobox
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    txtImage.Text = path;
                    picImage.ImageLocation = openFileDialog.FileName;
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string price, out string quantity, out string category, out int error);
            if (error == 0)
            {
                //query insert in SQL
                string input = "INSERT INTO Product OUTPUT INSERTED.ProductID VALUES (@name,@price,@quantity,@category,@image)";
                connection.Open(); 

                SqlCommand cmd = new SqlCommand(input, connection);
                cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@category", SqlDbType.Int).Value = category;

                //Convert Image to byte
                if (picImage.Image != null)
                {
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary);
                        cmd.Parameters["@Image"].Value = imageBytes;
                    }
                }
                else
                {
                    cmd.Parameters.Add("@Image", SqlDbType.VarBinary);
                    cmd.Parameters["@Image"].Value = DBNull.Value;
                }
                
                int proID = (int)cmd.ExecuteScalar();
                string transType = "Import";

                string transInput = "INSERT INTO InventoryTransactions VALUES (@ProID,@TransType,@quantity,@TransDate,@EmpID)";
                SqlCommand cmd1 = new SqlCommand(transInput, connection);
                cmd1.Parameters.Add("@ProID", SqlDbType.Int).Value = proID;
                cmd1.Parameters.Add("@TransType", SqlDbType.NVarChar).Value = transType;
                cmd1.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                cmd1.Parameters.Add("@TransDate", SqlDbType.Date).Value = DateTime.Now.Date;
                cmd1.Parameters.Add("@EmpID", SqlDbType.Int).Value = GetUser.EmpID;
                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }

                FillData();
                lblNotification.Text = "Insert successfully";
                timeNotification.Start();
                btnCancel_Click(sender, e);
            }

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Change button Add -> Edit            
            if (pnlAdd.Visible == false)
            {
                EditIcon();
            }
            btnInsert.Visible = false;
            btnUpdate.Visible = true;

            try
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtID.ReadOnly = true;
                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtQuantity.Text = row.Cells[3].Value.ToString();
                cboCategory.Text = row.Cells[5].Value.ToString();
                picImage.Image = row.Cells[6].FormattedValue as Image;
            }
            catch 
            {
                return;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string price, out string quantity, out string category, out int error);
            string id = txtID.Text.Replace("PD", "");
            //Check if it has error
            if (error == 0)
            {
                if (MessageBox.Show("Do you want to update this product?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //query update in SQL
                    string update = "UPDATE Product SET ProductName =@name, Price = @price, InventoryQuantity = @quantity, CategoryID = @categoryid, Image = @image"
                    + " where ProductID = @id";

                    connection.Open();

                    //Update in to SQL
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                    cmd.Parameters.Add("@categoryid", SqlDbType.Int).Value = category;

                    //Convert Image to byte
                    if (picImage.Image != null)
                    {
                        byte[] imageBytes;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageBytes = ms.ToArray();
                            cmd.Parameters.Add("@Image", SqlDbType.VarBinary);
                            cmd.Parameters["@Image"].Value = imageBytes;
                        }
                    }
                    else
                    {
                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary);
                        cmd.Parameters["@Image"].Value = DBNull.Value;
                    }


                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        int q = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Quantity"].Value);
                        int Q = Convert.ToInt32(quantity);
                        int classify = q - Q;
                        string transInput = "INSERT INTO InventoryTransactions VALUES (@ProID,@TransType,@quantity,@TransDate,@EmpID)";

                        string type = "";
                        if(classify > 0)
                        {
                            type = "Import";

                        }
                        else if(classify < 0)
                        {
                            type = "Export";
                        }
                        SqlCommand cmd1 = new SqlCommand(transInput, connection);
                        cmd1.Parameters.Add("@ProID", SqlDbType.Int).Value = id;
                        cmd1.Parameters.Add("@TransType", SqlDbType.NVarChar).Value = type;
                        cmd1.Parameters.Add("@quantity", SqlDbType.Int).Value = classify;
                        cmd1.Parameters.Add("@TransDate", SqlDbType.Date).Value = DateTime.Now.Date;
                        cmd1.Parameters.Add("@EmpID", SqlDbType.Int).Value = GetUser.EmpID;

                        cmd1.ExecuteNonQuery();

                        lblNotification.Text = "Update successfully";
                        timeNotification.Start();

                        btnCancel_Click(sender, e);
                    }
                    else
                    {
                        lblNotification.Text = "Update fail";
                        timeNotification.Start();
                    }
                    FillData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "Automatic ID";
            txtID.ForeColor = Color.Silver;
            txtID.ReadOnly = false;

            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtImage.Text = string.Empty;
            picImage.Image = null;
            dgvProduct.ClearSelection();

            if (btnUpdate.Visible != false || btnAdd.Text == "Edit")
            {
                btnUpdate.Visible = false;
                btnInsert.Visible = true;
                pnlAdd.Visible = false;
                pnlAdd.Visible = false;
                AddIcon();
                dgvProduct.ClearSelection();
            }
        }

        private void timeNotification_Tick(object sender, EventArgs e)
        {
            lblNotification.Text = string.Empty;
            timeNotification.Stop();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            frmEditCategory C = new frmEditCategory();
            C.FormClosed += (s, args) =>
            {
                FillCategories(cboCategory);
                FillCategories(cboSearchCategory);
            };
            C.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtSearchName.Text;
            string searchName = @"
                                SELECT 'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                    ProductName,
                                    Price,
                                    Quantity,
                                    Product.CategoryID,
                                    CategoryList.CategoryName,
                                    Image
                                FROM
                                    Product
                                JOIN
                                    CategoryList
                                    ON Product.CategoryID = CategoryList.CategoryID
                                WHERE
                                    ProductName LIKE @searchName";
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(searchName, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@searchName", "%" + Name + "%");
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvProduct.DataSource = tbl;
            if (tbl != null && tbl.Rows.Count > 0)
            {                  
                lblSearchNotification.Text = ""; 
            }
            else
            {
                lblSearchNotification.Text = "Not found";
            }

            connection.Close();

        }

        private void dgvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (!GetUser.Access.Equals("Admin"))
            {
                return;
            }
            else if (e.KeyCode == Keys.Delete && dgvProduct.SelectedCells.Count > 0 ) //Delete key to delete
            {
                if (MessageBox.Show("Are you sure want to delete this? \n It will delete in inventory transactions", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(txtID.Text.Replace("PD", ""));

                    connection.Open();
                    string deQuery = "DELETE FROM InventoryTransactions WHERE ProductID = @ID";
                    SqlCommand cmdTrans = new SqlCommand(deQuery, connection);
                    cmdTrans.Parameters.AddWithValue("@ID", id);
                    string deleteQuery = "DELETE FROM Product WHERE ProductID = @id";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@id", id);


                    cmdTrans.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    FillData(); // Refresh data after deletion
                    MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvProduct.ClearSelection();
                AddIcon();
                btnCancel_Click(sender, e);
            }
        }

        private void cboSearchCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cboSearchCategory.SelectedValue.ToString());
            string searchCategory = @"
                                    SELECT 
                                        'PD' + RIGHT('00000' + CAST(ProductID AS VARCHAR(5)), 5) AS formattedProduct_id,
                                        ProductName,
                                        Price,
                                        Quantity,
                                        Product.CategoryID,
                                        CategoryList.CategoryName,
                                        Image 
                                    FROM 
                                        Product 
                                    JOIN 
                                        CategoryList ON Product.CategoryID = CategoryList.CategoryID 
                                    WHERE 
                                        CategoryList.CategoryID = @searchCategory;";
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(searchCategory, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@searchCategory", id);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvProduct.DataSource = tbl;
            connection.Close();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            btnCancel_Click(sender, e);
            lblSearchNotification.Text = string.Empty;
            txtSearchName.Text = string.Empty;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text.Equals(""))
            {
                picRefresh_Click(sender,e);
            }
        }
    }
}
