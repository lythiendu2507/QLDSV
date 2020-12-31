using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangNhap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
           
        }

        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmNhapDiem f = new frmNhapDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Form frm = this.CheckExists(typeof(frmHocPhi));
                if (frm != null) frm.Activate();
                else
                {
                    frmHocPhi f = new frmHocPhi();
                    f.MdiParent = this;
                    f.Show();
                }
            
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            btnLop.Enabled = true;
            btnSinhVien.Enabled = true;
            btnMonHoc.Enabled = true; // Lop Hoc
            btnNhapDiem.Enabled = true;
            btnHocPhi.Enabled = true;
            btn_rp_dssv.Enabled = true;
            btn_rp_dsHP.Enabled = true;
            btn_rp_PhieuDiem.Enabled = true;
            btnDSTHM.Enabled = true;
            btnBDMN.Enabled = true;
            
            btnBDTK.Enabled = true;

            if (Program.mGroup == "PKeToan")
            {
                btnLop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnMonHoc.Enabled = false; // Lop Hoc
                btnNhapDiem.Enabled = false;
                btn_rp_dssv.Enabled = false;
                btnBDTK.Enabled = false;
                
                btn_rp_PhieuDiem.Enabled = false;
                btnDSTHM.Enabled = false;
                btnBDMN.Enabled = false;
                btnBDMN.Enabled = false;
            }
            else if (Program.mGroup == "KHOA")
            {
                btnHocPhi.Enabled = false;
                btn_rp_dsHP.Enabled = false;
            }
            else if (Program.mGroup == "USER")
            {
                btnHocPhi.Enabled = false;
                btnDangKyy.Enabled = false;
                btn_rp_dsHP.Enabled = false;
            }
            else if (Program.mGroup == "PGV")
            {
                btnHocPhi.Enabled = false;
                btn_rp_dsHP.Enabled = false;
            }

        }

        private void btnLopHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_dssv));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_dssv f = new frm_rp_dssv();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_dsthm));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_dsthm f = new frm_rp_dsthm();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_bdMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_bdMonHoc f = new frm_rp_bdMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_3(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_PhieuDiem));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_PhieuDiem f = new frm_rp_PhieuDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_HocPhi));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_HocPhi f = new frm_rp_HocPhi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_rp_BangDiemTongKet));
            if (frm != null) frm.Activate();
            else
            {
                frm_rp_BangDiemTongKet f = new frm_rp_BangDiemTongKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmDN = new frmDangNhap();
            Program.frmDN.Activate();
            Program.frmDN.Show();
            Program.frmChinh.Close();
        }
    }
}
