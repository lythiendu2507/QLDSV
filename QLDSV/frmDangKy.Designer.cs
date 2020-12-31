namespace QLDSV
{
    partial class frmDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gIANGVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gIANGVIENTableAdapter = new QLDSV.DSTableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.PGV = new System.Windows.Forms.RadioButton();
            this.KHOA = new System.Windows.Forms.RadioButton();
            this.USER = new System.Windows.Forms.RadioButton();
            this.PKeToan = new System.Windows.Forms.RadioButton();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassDN = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.gbDK.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(177, 248);
            mAGVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(100, 17);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "Mã Giảng Viên:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(177, 299);
            hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(98, 17);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "Họ Giảng Viên:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(177, 345);
            tENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(103, 17);
            tENLabel.TabIndex = 7;
            tENLabel.Text = "Tên Giảng Viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gIANGVIENGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1060, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gIANGVIENGridControl
            // 
            this.gIANGVIENGridControl.DataSource = this.bdsGV;
            this.gIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIANGVIENGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gIANGVIENGridControl.Location = new System.Drawing.Point(4, 22);
            this.gIANGVIENGridControl.MainView = this.gridView1;
            this.gIANGVIENGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.gIANGVIENGridControl.Name = "gIANGVIENGridControl";
            this.gIANGVIENGridControl.Size = new System.Drawing.Size(1052, 219);
            this.gIANGVIENGridControl.TabIndex = 0;
            this.gIANGVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colMAKH,
            this.colrowguid});
            this.gridView1.DetailHeight = 458;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gIANGVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 27;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 100;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 27;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 100;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 27;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 100;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 27;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 3;
            this.colMAKH.Width = 100;
            // 
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.MinWidth = 27;
            this.colrowguid.Name = "colrowguid";
            this.colrowguid.Visible = true;
            this.colrowguid.VisibleIndex = 4;
            this.colrowguid.Width = 100;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(300, 249);
            this.txtMAGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(211, 20);
            this.txtMAGV.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(300, 300);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(211, 20);
            this.txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(300, 346);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(211, 20);
            this.txtTen.TabIndex = 8;
            // 
            // PGV
            // 
            this.PGV.AutoSize = true;
            this.PGV.Location = new System.Drawing.Point(317, 387);
            this.PGV.Margin = new System.Windows.Forms.Padding(4);
            this.PGV.Name = "PGV";
            this.PGV.Size = new System.Drawing.Size(116, 21);
            this.PGV.TabIndex = 9;
            this.PGV.TabStop = true;
            this.PGV.Text = "Phòng Giáo Vụ";
            this.PGV.UseVisualStyleBackColor = true;
            this.PGV.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // KHOA
            // 
            this.KHOA.AutoSize = true;
            this.KHOA.Location = new System.Drawing.Point(317, 417);
            this.KHOA.Margin = new System.Windows.Forms.Padding(4);
            this.KHOA.Name = "KHOA";
            this.KHOA.Size = new System.Drawing.Size(58, 21);
            this.KHOA.TabIndex = 10;
            this.KHOA.TabStop = true;
            this.KHOA.Text = "Khoa";
            this.KHOA.UseVisualStyleBackColor = true;
            // 
            // USER
            // 
            this.USER.AutoSize = true;
            this.USER.Location = new System.Drawing.Point(504, 387);
            this.USER.Margin = new System.Windows.Forms.Padding(4);
            this.USER.Name = "USER";
            this.USER.Size = new System.Drawing.Size(64, 21);
            this.USER.TabIndex = 11;
            this.USER.TabStop = true;
            this.USER.Text = "USER";
            this.USER.UseVisualStyleBackColor = true;
            // 
            // PKeToan
            // 
            this.PKeToan.AutoSize = true;
            this.PKeToan.Location = new System.Drawing.Point(504, 417);
            this.PKeToan.Margin = new System.Windows.Forms.Padding(4);
            this.PKeToan.Name = "PKeToan";
            this.PKeToan.Size = new System.Drawing.Size(122, 21);
            this.PKeToan.TabIndex = 12;
            this.PKeToan.Text = "Phòng Khảo Thí";
            this.PKeToan.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(385, 447);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(143, 42);
            this.btnDangKy.TabIndex = 13;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.DangKy_Click);
            // 
            // gbDK
            // 
            this.gbDK.Controls.Add(this.txtTen);
            this.gbDK.Controls.Add(this.btnDangKy);
            this.gbDK.Controls.Add(this.txtHo);
            this.gbDK.Controls.Add(this.label3);
            this.gbDK.Controls.Add(this.txtMAGV);
            this.gbDK.Controls.Add(this.label2);
            this.gbDK.Controls.Add(this.label1);
            this.gbDK.Controls.Add(this.txtPassDN);
            this.gbDK.Controls.Add(this.txtTenDN);
            this.gbDK.Controls.Add(tENLabel);
            this.gbDK.Controls.Add(this.PGV);
            this.gbDK.Controls.Add(this.KHOA);
            this.gbDK.Controls.Add(this.USER);
            this.gbDK.Controls.Add(this.PKeToan);
            this.gbDK.Controls.Add(hOLabel);
            this.gbDK.Controls.Add(mAGVLabel);
            this.gbDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDK.Location = new System.Drawing.Point(0, 0);
            this.gbDK.Margin = new System.Windows.Forms.Padding(4);
            this.gbDK.Name = "gbDK";
            this.gbDK.Padding = new System.Windows.Forms.Padding(4);
            this.gbDK.Size = new System.Drawing.Size(1060, 624);
            this.gbDK.TabIndex = 14;
            this.gbDK.TabStop = false;
            this.gbDK.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // txtPassDN
            // 
            this.txtPassDN.Location = new System.Drawing.Point(685, 295);
            this.txtPassDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassDN.Name = "txtPassDN";
            this.txtPassDN.Size = new System.Drawing.Size(189, 25);
            this.txtPassDN.TabIndex = 14;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(685, 244);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(189, 25);
            this.txtTenDN.TabIndex = 13;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDK);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIANGVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.gbDK.ResumeLayout(false);
            this.gbDK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsGV;
        private DSTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gIANGVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.RadioButton PGV;
        private System.Windows.Forms.RadioButton KHOA;
        private System.Windows.Forms.RadioButton USER;
        private System.Windows.Forms.RadioButton PKeToan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.GroupBox gbDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassDN;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
    }
}