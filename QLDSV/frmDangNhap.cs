using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLDSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;

        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = tENCNComboBox.SelectedValue.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tENCNLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim () == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống!!!", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = tENCNComboBox.SelectedIndex;
            Program.bds_dspm = bdsDSPM;
            MessageBox.Show("Đăng nhập thành công!!!","Thông báo", MessageBoxButtons.OK);
            SqlDataReader myReader;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            
            String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login cua ban khong co quyen truy cap du lieu!!", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();

            Program.frmChinh = new frmMain();
            Program.frmChinh.Activate();
            Program.frmChinh.Show();
            Program.frmDN.Visible = false;


           // MessageBox.Show(Program.servername);
           
            Program.frmChinh.MAGV.Text = "Mã giáo viên: " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm: " + Program.mGroup;
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
