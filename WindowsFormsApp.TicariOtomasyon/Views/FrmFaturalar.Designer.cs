namespace WindowsFormsApp.TicariOtomasyon.Controller
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
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
            this.tBLFATURALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGIDAIRESI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESLIMEDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESLIMALAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFatSeri = new DevExpress.XtraEditors.TextEdit();
            this.txtFatSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatTeslimAlan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatTeslimEden = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatAlici = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFatTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTeslimAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTeslimEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTarih.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 86);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 77);
            this.groupControl1.TabIndex = 109;
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
            this.labelControl1.Location = new System.Drawing.Point(32, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 110;
            this.labelControl1.Text = "FATURA SERI :";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLFATURALARBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 163);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 354);
            this.gridControl1.TabIndex = 108;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLFATURALARBindingSource
            // 
            this.tBLFATURALARBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLFATURALAR);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSERI,
            this.colSIRANO,
            this.colVERGIDAIRESI,
            this.colALICI,
            this.colTESLIMEDEN,
            this.colTESLIMALAN,
            this.colTARIH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSERI
            // 
            this.colSERI.FieldName = "SERI";
            this.colSERI.Name = "colSERI";
            this.colSERI.Visible = true;
            this.colSERI.VisibleIndex = 1;
            // 
            // colSIRANO
            // 
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.Visible = true;
            this.colSIRANO.VisibleIndex = 2;
            // 
            // colVERGIDAIRESI
            // 
            this.colVERGIDAIRESI.FieldName = "VERGIDAIRESI";
            this.colVERGIDAIRESI.Name = "colVERGIDAIRESI";
            this.colVERGIDAIRESI.Visible = true;
            this.colVERGIDAIRESI.VisibleIndex = 3;
            // 
            // colALICI
            // 
            this.colALICI.FieldName = "ALICI";
            this.colALICI.Name = "colALICI";
            this.colALICI.Visible = true;
            this.colALICI.VisibleIndex = 4;
            // 
            // colTESLIMEDEN
            // 
            this.colTESLIMEDEN.FieldName = "TESLIMEDEN";
            this.colTESLIMEDEN.Name = "colTESLIMEDEN";
            this.colTESLIMEDEN.Visible = true;
            this.colTESLIMEDEN.VisibleIndex = 5;
            // 
            // colTESLIMALAN
            // 
            this.colTESLIMALAN.FieldName = "TESLIMALAN";
            this.colTESLIMALAN.Name = "colTESLIMALAN";
            this.colTESLIMALAN.Visible = true;
            this.colTESLIMALAN.VisibleIndex = 6;
            // 
            // colTARIH
            // 
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 7;
            // 
            // txtFatSeri
            // 
            this.txtFatSeri.Location = new System.Drawing.Point(111, 3);
            this.txtFatSeri.Name = "txtFatSeri";
            this.txtFatSeri.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtFatSeri.Properties.MaskSettings.Set("mask", "\\p{Lu}+");
            this.txtFatSeri.Size = new System.Drawing.Size(137, 20);
            this.txtFatSeri.TabIndex = 100;
            // 
            // txtFatSeriNo
            // 
            this.txtFatSeriNo.Location = new System.Drawing.Point(111, 29);
            this.txtFatSeriNo.Name = "txtFatSeriNo";
            this.txtFatSeriNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtFatSeriNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtFatSeriNo.Properties.MaskSettings.Set("mask", "0000000000");
            this.txtFatSeriNo.Size = new System.Drawing.Size(137, 20);
            this.txtFatSeriNo.TabIndex = 111;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "FATURA SERI NO :";
            // 
            // txtFatVergiDairesi
            // 
            this.txtFatVergiDairesi.Location = new System.Drawing.Point(111, 55);
            this.txtFatVergiDairesi.Name = "txtFatVergiDairesi";
            this.txtFatVergiDairesi.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtFatVergiDairesi.Properties.MaskSettings.Set("mask", "\\p{Lu}+");
            this.txtFatVergiDairesi.Size = new System.Drawing.Size(137, 20);
            this.txtFatVergiDairesi.TabIndex = 113;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 114;
            this.labelControl3.Text = "VERGI DAIRESI :";
            // 
            // txtFatTeslimAlan
            // 
            this.txtFatTeslimAlan.Location = new System.Drawing.Point(368, 55);
            this.txtFatTeslimAlan.Name = "txtFatTeslimAlan";
            this.txtFatTeslimAlan.Size = new System.Drawing.Size(137, 20);
            this.txtFatTeslimAlan.TabIndex = 119;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(265, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 13);
            this.labelControl4.TabIndex = 120;
            this.labelControl4.Text = "FAT. TESLIM ALAN :";
            // 
            // txtFatTeslimEden
            // 
            this.txtFatTeslimEden.Location = new System.Drawing.Point(368, 29);
            this.txtFatTeslimEden.Name = "txtFatTeslimEden";
            this.txtFatTeslimEden.Size = new System.Drawing.Size(137, 20);
            this.txtFatTeslimEden.TabIndex = 117;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(265, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 13);
            this.labelControl5.TabIndex = 118;
            this.labelControl5.Text = "FAT. TESLIM EDEN :";
            // 
            // txtFatAlici
            // 
            this.txtFatAlici.Location = new System.Drawing.Point(368, 3);
            this.txtFatAlici.Name = "txtFatAlici";
            this.txtFatAlici.Size = new System.Drawing.Size(137, 20);
            this.txtFatAlici.TabIndex = 115;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(285, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(77, 13);
            this.labelControl6.TabIndex = 116;
            this.labelControl6.Text = "FATURA ALICI :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(519, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(38, 13);
            this.labelControl7.TabIndex = 122;
            this.labelControl7.Text = "TARIH :";
            // 
            // txtFatTarih
            // 
            this.txtFatTarih.EditValue = new System.DateTime(2023, 3, 14, 21, 6, 20, 0);
            this.txtFatTarih.Location = new System.Drawing.Point(563, 3);
            this.txtFatTarih.Name = "txtFatTarih";
            this.txtFatTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFatTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFatTarih.Properties.DisplayFormat.FormatString = "";
            this.txtFatTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtFatTarih.Properties.EditFormat.FormatString = "";
            this.txtFatTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtFatTarih.Properties.MaskSettings.Set("mask", "");
            this.txtFatTarih.Size = new System.Drawing.Size(177, 20);
            this.txtFatTarih.TabIndex = 121;
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 517);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtFatTeslimAlan);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtFatTeslimEden);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtFatAlici);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtFatVergiDairesi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtFatSeriNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtFatSeri);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtFatTarih);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 549);
            this.MinimumSize = new System.Drawing.Size(876, 549);
            this.Name = "FrmFaturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTeslimAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTeslimEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFatTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private DevExpress.XtraEditors.TextEdit txtFatSeri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tBLFATURALARBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSERI;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGIDAIRESI;
        private DevExpress.XtraGrid.Columns.GridColumn colALICI;
        private DevExpress.XtraGrid.Columns.GridColumn colTESLIMEDEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTESLIMALAN;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraEditors.TextEdit txtFatSeriNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFatVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFatTeslimAlan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFatTeslimEden;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtFatAlici;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit txtFatTarih;
    }
}