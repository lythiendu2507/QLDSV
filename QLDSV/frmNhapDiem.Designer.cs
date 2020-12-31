namespace QLDSV
{
    partial class frmNhapDiem
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
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label tENMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
            this.dS = new QLDSV.DS();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QLDSV.DSTableAdapters.DIEMTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancer = new System.Windows.Forms.Button();
            this.txtTL = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            this.txtTMH = new DevExpress.XtraEditors.TextEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKhoaND = new System.Windows.Forms.ComboBox();
            this.btnBD = new System.Windows.Forms.Button();
            this.lANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.gbNhapDiem = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsNhapDiem = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.cT_DONGHOCPHITableAdapter1 = new QLDSV.DSTableAdapters.CT_DONGHOCPHITableAdapter();
            this.sP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter = new QLDSV.DSTableAdapters.SP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mALOPToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mALOPToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mAMHToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mAMHToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.lANToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lANToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cT_DONGHOCPHITableAdapter2 = new QLDSV.DSTableAdapters.CT_DONGHOCPHITableAdapter();
            lANLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).BeginInit();
            this.gbNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(12, 169);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(42, 17);
            lANLabel.TabIndex = 2;
            lANLabel.Text = "LAN:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(12, 125);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(88, 17);
            mAMHLabel.TabIndex = 12;
            mAMHLabel.Text = "Ma Mon Hoc";
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(436, 125);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(90, 17);
            tENMHLabel.TabIndex = 13;
            tENMHLabel.Text = "Ten Mon Hoc";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(12, 76);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(55, 17);
            mALOPLabel.TabIndex = 14;
            mALOPLabel.Text = "Ma Lop";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(436, 81);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(57, 17);
            tENLOPLabel.TabIndex = 15;
            tENLOPLabel.Text = "Ten Lop";
            // 
            // colNGHIHOC
            // 
            colNGHIHOC.FieldName = "NGHIHOC";
            colNGHIHOC.Name = "colNGHIHOC";
            colNGHIHOC.Visible = true;
            colNGHIHOC.VisibleIndex = 2;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.dS;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(tENLOPLabel);
            this.groupBox1.Controls.Add(this.btnCancer);
            this.groupBox1.Controls.Add(this.txtTL);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.cmbMaLop);
            this.groupBox1.Controls.Add(tENMHLabel);
            this.groupBox1.Controls.Add(this.txtTMH);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.cmbMaMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbKhoaND);
            this.groupBox1.Controls.Add(this.btnBD);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Controls.Add(this.lANSpinEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancer
            // 
            this.btnCancer.Location = new System.Drawing.Point(1055, 194);
            this.btnCancer.Name = "btnCancer";
            this.btnCancer.Size = new System.Drawing.Size(75, 23);
            this.btnCancer.TabIndex = 10;
            this.btnCancer.Text = "Cancer";
            this.btnCancer.UseVisualStyleBackColor = true;
            this.btnCancer.Click += new System.EventHandler(this.btnCancer_Click);
            // 
            // txtTL
            // 
            this.txtTL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "TENLOP", true));
            this.txtTL.Location = new System.Drawing.Point(546, 75);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(285, 20);
            this.txtTL.TabIndex = 16;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(946, 194);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cap Nhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.DataSource = this.lOPBindingSource;
            this.cmbMaLop.DisplayMember = "MALOP";
            this.cmbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(134, 73);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(268, 25);
            this.cmbMaLop.TabIndex = 15;
            this.cmbMaLop.ValueMember = "MALOP";
            this.cmbMaLop.SelectedIndexChanged += new System.EventHandler(this.mALOPComboBox_SelectedIndexChanged);
            // 
            // txtTMH
            // 
            this.txtTMH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "TENMH", true));
            this.txtTMH.Location = new System.Drawing.Point(546, 124);
            this.txtTMH.Name = "txtTMH";
            this.txtTMH.Size = new System.Drawing.Size(285, 20);
            this.txtTMH.TabIndex = 14;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataSource = this.mONHOCBindingSource;
            this.cmbMaMH.DisplayMember = "MAMH";
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(134, 117);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(270, 25);
            this.cmbMaMH.TabIndex = 13;
            this.cmbMaMH.ValueMember = "MAMH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ten Khoa";
            // 
            // cmbKhoaND
            // 
            this.cmbKhoaND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoaND.FormattingEnabled = true;
            this.cmbKhoaND.Location = new System.Drawing.Point(134, 24);
            this.cmbKhoaND.Name = "cmbKhoaND";
            this.cmbKhoaND.Size = new System.Drawing.Size(268, 25);
            this.cmbKhoaND.TabIndex = 11;
            // 
            // btnBD
            // 
            this.btnBD.Image = global::QLDSV.Properties.Resources.download;
            this.btnBD.Location = new System.Drawing.Point(134, 194);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 8;
            this.btnBD.Text = "Bat dau";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // lANSpinEdit
            // 
            this.lANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dIEMBindingSource, "LAN", true));
            this.lANSpinEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Location = new System.Drawing.Point(134, 168);
            this.lANSpinEdit.Name = "lANSpinEdit";
            this.lANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lANSpinEdit.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lANSpinEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lANSpinEdit.Size = new System.Drawing.Size(56, 20);
            this.lANSpinEdit.TabIndex = 3;
            // 
            // gbNhapDiem
            // 
            this.gbNhapDiem.Controls.Add(this.label2);
            this.gbNhapDiem.Controls.Add(this.gridControl1);
            this.gbNhapDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNhapDiem.Location = new System.Drawing.Point(0, 223);
            this.gbNhapDiem.Name = "gbNhapDiem";
            this.gbNhapDiem.Size = new System.Drawing.Size(1159, 309);
            this.gbNhapDiem.TabIndex = 4;
            this.gbNhapDiem.TabStop = false;
            this.gbNhapDiem.Enter += new System.EventHandler(this.gbNhapDiem_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập Điểm Sinh Viên";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsNhapDiem;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1153, 285);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsNhapDiem
            // 
            this.bdsNhapDiem.DataMember = "SP_SELECT_DIEM_THEO_MALOP_MAMH_LAN";
            this.bdsNhapDiem.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            colNGHIHOC,
            this.colDIEM,
            this.colLAN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 4;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cT_DONGHOCPHITableAdapter1
            // 
            this.cT_DONGHOCPHITableAdapter1.ClearBeforeFill = true;
            // 
            // sP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter
            // 
            this.sP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mALOPToolStripLabel,
            this.mALOPToolStripTextBox,
            this.mAMHToolStripLabel,
            this.mAMHToolStripTextBox,
            this.lANToolStripLabel,
            this.lANToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 532);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1159, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mALOPToolStripLabel
            // 
            this.mALOPToolStripLabel.Name = "mALOPToolStripLabel";
            this.mALOPToolStripLabel.Size = new System.Drawing.Size(51, 22);
            this.mALOPToolStripLabel.Text = "MALOP:";
            // 
            // mALOPToolStripTextBox
            // 
            this.mALOPToolStripTextBox.Name = "mALOPToolStripTextBox";
            this.mALOPToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // mAMHToolStripLabel
            // 
            this.mAMHToolStripLabel.Name = "mAMHToolStripLabel";
            this.mAMHToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.mAMHToolStripLabel.Text = "MAMH:";
            // 
            // mAMHToolStripTextBox
            // 
            this.mAMHToolStripTextBox.Name = "mAMHToolStripTextBox";
            this.mAMHToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // lANToolStripLabel
            // 
            this.lANToolStripLabel.Name = "lANToolStripLabel";
            this.lANToolStripLabel.Size = new System.Drawing.Size(33, 22);
            this.lANToolStripLabel.Text = "LAN:";
            // 
            // lANToolStripTextBox
            // 
            this.lANToolStripTextBox.Name = "lANToolStripTextBox";
            this.lANToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // cT_DONGHOCPHITableAdapter2
            // 
            this.cT_DONGHOCPHITableAdapter2.ClearBeforeFill = true;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 653);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.gbNhapDiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lANSpinEdit.Properties)).EndInit();
            this.gbNhapDiem.ResumeLayout(false);
            this.gbNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhapDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit lANSpinEdit;
        private System.Windows.Forms.GroupBox gbNhapDiem;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.Button btnCancer;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKhoaND;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtTL;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private DevExpress.XtraEditors.TextEdit txtTMH;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSTableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter1;
        private System.Windows.Forms.BindingSource bdsNhapDiem;
        private DSTableAdapters.SP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter sP_SELECT_DIEM_THEO_MALOP_MAMH_LANTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mALOPToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mALOPToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel mAMHToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mAMHToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel lANToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lANToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DSTableAdapters.CT_DONGHOCPHITableAdapter cT_DONGHOCPHITableAdapter2;
        private System.Windows.Forms.Label label2;
    }
}