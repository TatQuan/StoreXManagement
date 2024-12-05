using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StoreXManagement
{
    public partial class frmCustomerManagement : Form
    {
        SqlConnection connection;
        private string permission;
        public frmCustomerManagement(string access)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            permission = access;
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();

            switch (permission)
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
                    dgvCustomer.Visible = false;
                    break;
            }
        }

        //Load data into datagridview
        public void FillData()
        {
            string query = @"
                            SELECT 'CT' + RIGHT('00000' + CAST(CustomerID AS VARCHAR(5)), 5) AS formattedCustomer_id,
                                CustomerName,
                                PhoneNumber,
                                Address                              
                            FROM 
                                Customer";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvCustomer.DataSource = tbl;
            connection.Close();
        }

        //Chang icon button
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

        //Check value input function
        private void CheckValue(out string name, out string phoneNumber, out string address, out int error)
        {
            name = txtName.Text;
            phoneNumber = txtPhoneNumber.Text;
            address = txtAddress.Text;

            error = 0;
            //Address
            if (string.IsNullOrEmpty(address))
            {
                lblAddressError.Text = "Address can't be blank";
                error += 1;
                txtAddress.Focus();
            }
            else
            {
                lblAddressError.Text = string.Empty;
            }

            int check = 0;
            //PhoneNumber
            if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Equals("0"))
            {
                lblPhoneError.Text = "Phone number can't be blank";
                error += 1;
                txtPhoneNumber.Focus();
            }
            else if (int.TryParse(phoneNumber, out check))
            {
                if (check < 0)
                {
                    lblPhoneError.Text = "Phone number can't be negative number";
                    error += 1;
                    txtPhoneNumber.Text = string.Empty;
                    txtPhoneNumber.Focus();
                }
                else
                {
                    lblPhoneError.Text = string.Empty;
                }
            }
            else
            {
                error += 1;
                lblPhoneError.Text = "Phone number must be a number";
            }

            //Name
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Customer name can't be blank";
                error += 1;
                txtName.Focus();
            }
            else
            {
                lblNameError.Text = string.Empty;
            }
        }

        //Setup textbox id
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string phoneNumber, out string address, out int error);
            if (error == 0)
            {
                //query insert in SQL
                string insert = "INSERT INTO Customer VALUES (@name,@phone,@address)";
                connection.Open();

                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phoneNumber;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                int i = cmd.ExecuteNonQuery();
                if (i > 0) 
                {
                    FillData();
                    lblNotification.Text = "Insert successfully";
                    timeNotification.Start();

                    btnCancel_Click(sender, e);
                }
                else
                {
                    btnCancel_Click(sender, e);
                    lblNotification.Text = "Insert fail";
                    timeNotification.Start();
                }
            }
        }

        private void timeNotification_Tick(object sender, EventArgs e)
        {
            lblNotification.Text = string.Empty;
            timeNotification.Stop();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "Automatic ID";
            txtID.ForeColor = Color.Silver;
            txtID.ReadOnly = false;

            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;

            if (btnUpdate.Visible != false)
            {
                btnUpdate.Visible = false;
                btnInsert.Visible = true;
                pnlAdd.Visible = false;
                pnlAdd.Visible = false;
                AddIcon();
                dgvCustomer.ClearSelection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string phoneNumber, out string address, out int error);
            string id = txtID.Text.Replace("CT", "");
            //Check if it has error
            if (error == 0)
            {
                if (MessageBox.Show("Are you sure to update this product?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //query update in SQL
                    string update = "UPDATE Customer SET CustomerName =@name, PhoneNumber = @phoneNumber, Address = @address"
                    + " where CustomerID = @id";
                    connection.Open();

                    //Update in to SQL
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phoneNumber;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        FillData();
                        lblNotification.Text = "Update successfully";
                        timeNotification.Start();

                        btnCancel_Click(sender, e);
                    }
                    else
                    {
                        lblNotification.Text = "Update fail";
                        timeNotification.Start();
                    }
                }
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow row = this.dgvCustomer.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtID.ReadOnly = true;
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhoneNumber.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtSearchName.Text;
            string searchName = @"
                                SELECT 'CT' + RIGHT('00000' + CAST(CustomerID AS VARCHAR(5)), 5) AS formattedCustomer_id,
                                    CustomerName,
                                    PhoneNumber,
                                    Address 
                                FROM
                                    Customer
                                WHERE
                                    CustomerName LIKE @searchName";
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(searchName, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@searchName", "%" + Name + "%");
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvCustomer.DataSource = tbl;
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

        private void picRefresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            btnCancel_Click(sender, e);
            lblSearchNotification.Text = string.Empty;
            txtSearchName.Text = string.Empty;
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
                dgvCustomer.ClearSelection();
            }
        }

        private void dgvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (!permission.Equals("Admin"))
            {
                return;
            }
            else if (e.KeyCode == Keys.Delete && dgvCustomer.SelectedCells.Count > 0) //Delete key to delete
            {
                if (MessageBox.Show("Are you sure want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(txtID.Text.Replace("CT", ""));

                    connection.Open();
                    string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @id";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    FillData(); // Refresh data after deletion
                    MessageBox.Show(this, "Deleted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                dgvCustomer.ClearSelection();
                AddIcon();
                btnCancel_Click(sender, e);
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text.Equals(""))
            {
                picRefresh_Click(sender, e);
            }
        }
    }
}
