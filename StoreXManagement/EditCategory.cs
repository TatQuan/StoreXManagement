using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreXManagement
{
    public partial class frmEditCategory : Form
    {
        SqlConnection connection;
        public frmEditCategory()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=LAPTOP-17URO859;Database=StoreXManagement;Integrated Security = true");

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void FillData()
        {
            string query = "SELECT * FROM CategoryList;";
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(tbl);
            dgvCategory.DataSource = tbl;
            connection.Close();
        }
        private void EditCategory_Load(object sender, EventArgs e)
        {
            connection.Open();
            FillData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string category = txtAdđ.Text;
            if (category != "")
            {
                string insert = "INSERT INTO CategoryList VALUES (@name)";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);

                cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = category;
                cmd.ExecuteNonQuery();
                FillData();
                txtAdđ.Text = string.Empty;
            }
        }

        private void dgvCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvCategory.CurrentCell != null) 
            {
                int categoryId = (int)dgvCategory.CurrentRow.Cells[0].Value;

                // check product has category
                string checkSql = "SELECT COUNT(*) FROM Product WHERE CategoryID = @id";
                SqlCommand checkCmd = new SqlCommand(checkSql, connection);
                checkCmd.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;

                connection.Open();
                int productCount = (int)checkCmd.ExecuteScalar();  // counts product has CategoryID

                if (productCount > 0)
                {
                    MessageBox.Show("This category still has products", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string delete = "DELETE FROM CategoryList WHERE CategoryID = @id";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(delete, connection);
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = dgvCategory.CurrentRow.Cells[0].Value;
                    cmd.ExecuteNonQuery();
                    FillData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
