namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class FrmFaturaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaDetay));
            this.txtFatDetayTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatDetayMiktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatDetayFiyat = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnXls = new DevExpress.XtraEditors.SimpleButton();
            this.btnMht = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLFATURADETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFatDetayTutar
            // 
            this.txtFatDetayTutar.Location = new System.Drawing.Point(70, 55);
            this.txtFatDetayTutar.Name = "txtFatDetayTutar";
            this.txtFatDetayTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtFatDetayTutar.Properties.MaskSettings.Set("mask", "d");
            this.txtFatDetayTutar.Size = new System.Drawing.Size(232, 20);
            this.txtFatDetayTutar.TabIndex = 129;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 128;
            this.labelControl2.Text = "FIYAT :";
            // 
            // txtFatDetayMiktar
            // 
            this.txtFatDetayMiktar.Location = new System.Drawing.Point(71, 3);
            this.txtFatDetayMiktar.Name = "txtFatDetayMiktar";
            this.txtFatDetayMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtFatDetayMiktar.Properties.MaskSettings.Set("mask", "d");
            this.txtFatDetayMiktar.Size = new System.Drawing.Size(232, 20);
            this.txtFatDetayMiktar.TabIndex = 123;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 130;
            this.labelControl3.Text = "TUTAR :";
            // 
            // txtFatDetayFiyat
            // 
            this.txtFatDetayFiyat.Location = new System.Drawing.Point(70, 29);
            this.txtFatDetayFiyat.Name = "txtFatDetayFiyat";
            this.txtFatDetayFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtFatDetayFiyat.Properties.MaskSettings.Set("mask", "f");
            this.txtFatDetayFiyat.Size = new System.Drawing.Size(232, 20);
            this.txtFatDetayFiyat.TabIndex = 127;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 85);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 77);
            this.groupControl1.TabIndex = 125;
            this.groupControl1.Text = "Kontroller";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnKaydet);
            this.flowLayoutPanel1.Controls.Add(this.btnSil);
            this.flowLayoutPanel1.Controls.Add(this.btnGuncelle);
            this.flowLayoutPanel1.Controls.Add(this.btnYenile);
            this.flowLayoutPanel1.Controls.Add(this.btnPdf);
            this.flowLayoutPanel1.Controls.Add(this.btnXls);
            this.flowLayoutPanel1.Controls.Add(this.btnMht);
            this.flowLayoutPanel1.Controls.Add(this.btnCikis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = global::WindowsFormsApp.TicariOtomasyon.Properties.Resources.save_32x32;
            this.btnKaydet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnKaydet.Location = new System.Drawing.Point(3, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 45);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSil.Location = new System.Drawing.Point(110, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 45);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(217, 3);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(101, 45);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnYenile.Location = new System.Drawing.Point(324, 3);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(115, 45);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "LİSTEYİ YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdf.ImageOptions.Image")));
            this.btnPdf.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPdf.Location = new System.Drawing.Point(445, 3);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(101, 45);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnXls
            // 
            this.btnXls.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXls.ImageOptions.Image")));
            this.btnXls.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXls.Location = new System.Drawing.Point(552, 3);
            this.btnXls.Name = "btnXls";
            this.btnXls.Size = new System.Drawing.Size(101, 45);
            this.btnXls.TabIndex = 7;
            this.btnXls.Text = "XLS";
            this.btnXls.Click += new System.EventHandler(this.btnXls_Click);
            // 
            // btnMht
            // 
            this.btnMht.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMht.ImageOptions.Image")));
            this.btnMht.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMht.Location = new System.Drawing.Point(659, 3);
            this.btnMht.Name = "btnMht";
            this.btnMht.Size = new System.Drawing.Size(101, 45);
            this.btnMht.TabIndex = 8;
            this.btnMht.Text = "MHT";
            this.btnMht.Click += new System.EventHandler(this.btnMht_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCikis.Location = new System.Drawing.Point(766, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(101, 45);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "MIKTAR : ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLFATURADETAYBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 162);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 354);
            this.gridControl1.TabIndex = 124;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLFATURADETAYBindingSource
            // 
            this.tBLFATURADETAYBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLFATURADETAY);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFATURAID,
            this.colMIKTAR,
            this.colFIYAT,
            this.colTUTAR});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFATURAID
            // 
            this.colFATURAID.FieldName = "FATURAID";
            this.colFATURAID.Name = "colFATURAID";
            this.colFATURAID.Visible = true;
            this.colFATURAID.VisibleIndex = 1;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 2;
            // 
            // colFIYAT
            // 
            this.colFIYAT.FieldName = "FIYAT";
            this.colFIYAT.Name = "colFIYAT";
            this.colFIYAT.Visible = true;
            this.colFIYAT.VisibleIndex = 3;
            // 
            // colTUTAR
            // 
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 4;
            // 
            // FrmFaturaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 516);
            this.Controls.Add(this.txtFatDetayTutar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFatDetayMiktar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtFatDetayFiyat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 548);
            this.MinimumSize = new System.Drawing.Size(876, 548);
            this.Name = "FrmFaturaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturaDetay";
            this.Load += new System.EventHandler(this.FrmFaturaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatDetayFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFatDetayTutar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFatDetayMiktar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFatDetayFiyat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnPdf;
        private DevExpress.XtraEditors.SimpleButton btnXls;
        private DevExpress.XtraEditors.SimpleButton btnMht;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tBLFATURADETAYBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAID;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
    }
}