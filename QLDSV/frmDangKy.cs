using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
            txtHo.Enabled = false;
            txtMAGV.Enabled = false;
            txtTen.Enabled = false;
            if(Program.mGroup == "USER")
            {
                MessageBox.Show("Bạn không có quyền tạo tài khoản!!","",MessageBoxButtons.OK);
                gbDK.Enabled = false;
                txtHo.Enabled = txtHo.Enabled = txtMAGV.Enabled = txtPassDN.Enabled = txtTen.Enabled = txtTenDN.Enabled = PKeToan.Enabled = KHOA.Enabled = USER.Enabled = PGV.Enabled = false;
            }
            else if(Program.mGroup == "PGV")
            {
                PKeToan.Enabled = false;
            }
            else if(Program.mGroup == "KHOA")
            {
                PGV.Enabled = false;
                PKeToan.Enabled = false;
            }
            else if(Program.mGroup == "PKeToan")
            {
                PKeToan.Enabled = false;
                KHOA.Enabled = false;
                USER.Enabled = false;
            }
            
        }


        private string role()
        {
            string str = "";
            if (PGV.Checked == true) str = "PGV";
            if (KHOA.Checked == true) str = "KHOA";
            if (USER.Checked == true) str = "USER";
            if (PKeToan.Checked == true) str = "PKeToan";
            return str;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Click(object sender, EventArgs e)
        {
            if (Program.username.Equals(PGV))
            {
                MessageBox.Show("Bạn không thể tạo đăng nhập cho chính bạn!");
                return;
            }
            if (txtTenDN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tên đăng nhập không được thiếu !", "", MessageBoxButtons.OK);
                txtTenDN.Focus();
                return;
            }
            if (txtTenDN.Text.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được có khoảng trống !", "", MessageBoxButtons.OK);
                txtTenDN.Focus();
                return;
            }
            if (txtPassDN.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password không được thiếu !", "", MessageBoxButtons.OK);
                txtPassDN.Focus();
                return;
            }
            if ((PGV.Checked || KHOA.Checked || USER.Checked || PKeToan.Checked ) == false)
            {
                MessageBox.Show("Role không được thiếu !", "", MessageBoxButtons.OK);
                return;
            }

            string strLenh = "DECLARE @result int " +
                            "EXEC @result = SP_TAOTAIKHOAN N'" + txtTenDN.Text + "', N'" + txtPassDN.Text.Trim() + "', N'" +
                            txtMAGV.Text + "', N'" + role() + "'" +
                            " SELECT 'result' = @result";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (result == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
