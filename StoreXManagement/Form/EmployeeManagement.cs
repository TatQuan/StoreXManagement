using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StoreXManagement
{
    public partial class frmEmployeeManagement : Form
    {
        SqlConnection connection;
        private string permission;
        public frmEmployeeManagement(string access)
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");
            permission = access;
        }

        public void FillData()
        {
            string query = @"
                            SELECT 
                                'EP' + RIGHT('00000' + CAST(EmployeeID AS VARCHAR(5)), 5) AS formattedEmployee_id,
                                EmployeeName,
                                Position,
                                Username,
                                Password                              
                            FROM 
                                Employee";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvEmployee.DataSource = tbl;
            connection.Close();
        }

        //Change button Add/Back/Edit icon
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
                dgvEmployee.ClearSelection();
            }
        }

        //Form Load
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();

            switch (permission)
            {
                case "Admin":
                    btnAdd.Visible = true;
                    cboPosition.Text = "Employees";
                    break;
                case "Sales staff":
                case "Warehouse staff":
                case "Employees":
                    btnAdd.Visible = false;
                    break;
                default:
                    dgvEmployee.Visible = false;
                    break;
            }
        }

        private void timeNotification_Tick(object sender, EventArgs e)
        {
            lblNotification.Text = string.Empty;
            timeNotification.Stop();
        }

        //Check value input function
        private void CheckValue(out string name, out string position, out string username, out string password, out int error)
        {
            name = txtName.Text;
            position = cboPosition.Text;
            username = txtUserName.Text;
            password = txtPassword.Text;

            error = 0;
            //Password
            if (string.IsNullOrEmpty(password))
            {
                lblPassError.Text = "Password can't be blank";
                error += 1;
                txtPassword.Focus();
            }
            else if (password.Length < 8)
            {
                lblPassError.Text = "Password must more than 8 characters";
                error += 1;
                txtPassword.Text = string.Empty;
                txtPassword.Focus();
            }              
            else
            {
                lblPassError.Text = string.Empty;
            }           

            //username
            if (string.IsNullOrEmpty(username) || username.Equals("0"))
            {
                lblUserNameError.Text = "User name can't be blank";
                error += 1;
                txtUserName.Focus();
            }
            else
            {
                lblUserNameError.Text = string.Empty;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string position, out string username, out string password, out int error);
            if (error == 0)
            {
                //query insert in SQL
                string input = "INSERT INTO Employee VALUES (@name,@position,@user,@password)";
                connection.Open();

                SqlCommand cmd = new SqlCommand(input, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = position;
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                cmd.ExecuteNonQuery();
                FillData();
                lblNotification.Text = "Insert successfully";
                timeNotification.Start();
                btnCancel_Click(sender, e);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Text = "Automatic ID";
            txtID.ForeColor = Color.Silver;
            txtID.ReadOnly = false;
            txtName.Text = string.Empty;
            cboPosition.Text = "Employees";
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;

            if (btnUpdate.Visible != false)
            {
                btnUpdate.Visible = false;
                btnInsert.Visible = true;
                pnlAdd.Visible = false;
                pnlAdd.Visible = false;
                AddIcon();
                dgvEmployee.ClearSelection();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
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
                DataGridViewRow row = this.dgvEmployee.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtID.ReadOnly = true;
                txtName.Text = row.Cells[1].Value.ToString();
                cboPosition.Text = row.Cells[2].Value.ToString();
                txtUserName.Text = row.Cells[3].Value.ToString();
                txtPassword.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckValue(out string name, out string position, out string username, out string password, out int error);
            string id = txtID.Text.Replace("EP", "");
            //Check if it has error
            if (error == 0)
            {
                if (MessageBox.Show("Are you sure to update this product?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //query update in SQL
                    string update = "UPDATE Employee SET EmployeeName =@name, Position = @position, Username = @user, Password = @password"
                    + " where EmployeeID = @id";

                    connection.Open();

                    //Update in to SQL
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = position;
                    cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

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

        //Change button show/hide icon and show or hide password
        private void picHideShow_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar != true)
            {
                picHideShow.Image = StoreXManagement.Properties.Resources.show_darkColor;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                picHideShow.Image = StoreXManagement.Properties.Resources.hide_darkColor;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void dgvEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (!permission.Equals("Admin"))
            {
                return;
            }
            else if (e.KeyCode == Keys.Delete && dgvEmployee.SelectedCells.Count > 0) //Delete key to delete
            {
                if (MessageBox.Show("Are you sure want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(txtID.Text.Replace("EP", ""));

                    connection.Open();
                    string deleteQuery = "DELETE FROM Employee WHERE EmployeeID = @id";
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
                dgvEmployee.ClearSelection();
                AddIcon();
                btnCancel_Click(sender, e);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
            btnCancel_Click(sender, e);
            lblSearchNotification.Text = string.Empty;
            txtSearchName.Text = string.Empty;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtSearchName.Text;
            string searchName = @"
                                SELECT 
                                'EP' + RIGHT('00000' + CAST(EmployeeID AS VARCHAR(5)), 5) AS formattedEmployee_id,
                                EmployeeName,
                                Position,
                                Username,
                                Password                              
                            FROM 
                                Employee
                            WHERE
                                EmployeeName LIKE @searchName";
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(searchName, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@searchName", "%" + Name + "%");
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dgvEmployee.DataSource = tbl;
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
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text.Equals(""))
            {
                picRefresh_Click(sender, e);
            }
        }
    }
}
