namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.urunBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDETAY = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunYili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunDetay = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunSatisFiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.urunBinding;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 172);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 329);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // urunBinding
            // 
            this.urunBinding.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLURUNLER);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colURUNAD,
            this.colMARKA,
            this.colMODEL,
            this.colYIL,
            this.colADET,
            this.colALISFIYAT,
            this.colSATISFIYAT,
            this.colDETAY});
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
            // colURUNAD
            // 
            this.colURUNAD.FieldName = "URUNAD";
            this.colURUNAD.Name = "colURUNAD";
            this.colURUNAD.Visible = true;
            this.colURUNAD.VisibleIndex = 1;
            // 
            // colMARKA
            // 
            this.colMARKA.FieldName = "MARKA";
            this.colMARKA.Name = "colMARKA";
            this.colMARKA.Visible = true;
            this.colMARKA.VisibleIndex = 2;
            // 
            // colMODEL
            // 
            this.colMODEL.FieldName = "MODEL";
            this.colMODEL.Name = "colMODEL";
            this.colMODEL.Visible = true;
            this.colMODEL.VisibleIndex = 3;
            // 
            // colYIL
            // 
            this.colYIL.FieldName = "YIL";
            this.colYIL.Name = "colYIL";
            this.colYIL.Visible = true;
            this.colYIL.VisibleIndex = 4;
            // 
            // colADET
            // 
            this.colADET.FieldName = "ADET";
            this.colADET.Name = "colADET";
            this.colADET.Visible = true;
            this.colADET.VisibleIndex = 5;
            // 
            // colALISFIYAT
            // 
            this.colALISFIYAT.FieldName = "ALISFIYAT";
            this.colALISFIYAT.Name = "colALISFIYAT";
            this.colALISFIYAT.Visible = true;
            this.colALISFIYAT.VisibleIndex = 6;
            // 
            // colSATISFIYAT
            // 
            this.colSATISFIYAT.FieldName = "SATISFIYAT";
            this.colSATISFIYAT.Name = "colSATISFIYAT";
            this.colSATISFIYAT.Visible = true;
            this.colSATISFIYAT.VisibleIndex = 7;
            // 
            // colDETAY
            // 
            this.colDETAY.FieldName = "DETAY";
            this.colDETAY.Name = "colDETAY";
            this.colDETAY.Visible = true;
            this.colDETAY.VisibleIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 74);
            this.groupControl1.TabIndex = 1;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 49);
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
            this.labelControl1.Location = new System.Drawing.Point(25, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ÜRÜN AD :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(81, 1);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(141, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // txtUrunMarka
            // 
            this.txtUrunMarka.Location = new System.Drawing.Point(81, 27);
            this.txtUrunMarka.Name = "txtUrunMarka";
            this.txtUrunMarka.Size = new System.Drawing.Size(141, 20);
            this.txtUrunMarka.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ÜRÜN MARKA :";
            // 
            // txtUrunModel
            // 
            this.txtUrunModel.Location = new System.Drawing.Point(81, 53);
            this.txtUrunModel.Name = "txtUrunModel";
            this.txtUrunModel.Size = new System.Drawing.Size(141, 20);
            this.txtUrunModel.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "ÜRÜN MODEL :";
            // 
            // txtUrunAlisFiyat
            // 
            this.txtUrunAlisFiyat.Location = new System.Drawing.Point(325, 53);
            this.txtUrunAlisFiyat.Name = "txtUrunAlisFiyat";
            this.txtUrunAlisFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtUrunAlisFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtUrunAlisFiyat.Properties.MaskSettings.Set("mask", "f");
            this.txtUrunAlisFiyat.Size = new System.Drawing.Size(141, 20);
            this.txtUrunAlisFiyat.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(227, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "ÜRÜN ALIŞ FİYAT :";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(325, 27);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtUrunAdet.Properties.MaskSettings.Set("mask", "00000");
            this.txtUrunAdet.Size = new System.Drawing.Size(141, 20);
            this.txtUrunAdet.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(248, 30);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "ÜRÜN ADET :";
            // 
            // txtUrunYili
            // 
            this.txtUrunYili.Location = new System.Drawing.Point(325, 1);
            this.txtUrunYili.Name = "txtUrunYili";
            this.txtUrunYili.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtUrunYili.Properties.MaskSettings.Set("mask", "d");
            this.txtUrunYili.Size = new System.Drawing.Size(141, 20);
            this.txtUrunYili.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(262, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "ÜRÜN YILI :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(501, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "ÜRÜN DETAY :";
            // 
            // txtUrunSatisFiyat
            // 
            this.txtUrunSatisFiyat.Location = new System.Drawing.Point(577, 1);
            this.txtUrunSatisFiyat.Name = "txtUrunSatisFiyat";
            this.txtUrunSatisFiyat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtUrunSatisFiyat.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtUrunSatisFiyat.Properties.MaskSettings.Set("mask", "f");
            this.txtUrunSatisFiyat.Size = new System.Drawing.Size(285, 20);
            this.txtUrunSatisFiyat.TabIndex = 15;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(472, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(99, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "ÜRÜN SATIŞ FİYAT :";
            // 
            // txtUrunDetay
            // 
            this.txtUrunDetay.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtUrunDetay.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtUrunDetay.Location = new System.Drawing.Point(577, 27);
            this.txtUrunDetay.Name = "txtUrunDetay";
            this.txtUrunDetay.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtUrunDetay.Size = new System.Drawing.Size(285, 65);
            this.txtUrunDetay.TabIndex = 19;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 501);
            this.Controls.Add(this.txtUrunDetay);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtUrunSatisFiyat);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtUrunAlisFiyat);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtUrunAdet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtUrunYili);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtUrunModel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUrunMarka);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 533);
            this.MinimumSize = new System.Drawing.Size(876, 533);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunSatisFiyat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtUrunMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUrunModel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUrunAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUrunAdet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUrunYili;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtUrunSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraRichEdit.RichEditControl txtUrunDetay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnPdf;
        private DevExpress.XtraEditors.SimpleButton btnXls;
        private DevExpress.XtraEditors.SimpleButton btnMht;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private System.Windows.Forms.BindingSource urunBinding;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMARKA;
        private DevExpress.XtraGrid.Columns.GridColumn colMODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colYIL;
        private DevExpress.XtraGrid.Columns.GridColumn colADET;
        private DevExpress.XtraGrid.Columns.GridColumn colALISFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colDETAY;
    }
}