namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGOREV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLPERSONELLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersIl = new DevExpress.XtraEditors.LookUpEdit();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersAdres = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersGorev = new DevExpress.XtraEditors.TextEdit();
            this.txtPersIlce = new DevExpress.XtraEditors.LookUpEdit();
            this.ilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPersMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtPersTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPersTc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersTc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAD,
            this.colSOYAD,
            this.colTELEFON,
            this.colTC,
            this.colMAIL,
            this.colIL,
            this.colILCE,
            this.colADRES,
            this.colGOREV});
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
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            // 
            // colSOYAD
            // 
            this.colSOYAD.FieldName = "SOYAD";
            this.colSOYAD.Name = "colSOYAD";
            this.colSOYAD.Visible = true;
            this.colSOYAD.VisibleIndex = 2;
            // 
            // colTELEFON
            // 
            this.colTELEFON.FieldName = "TELEFON";
            this.colTELEFON.Name = "colTELEFON";
            this.colTELEFON.Visible = true;
            this.colTELEFON.VisibleIndex = 3;
            // 
            // colTC
            // 
            this.colTC.FieldName = "TC";
            this.colTC.Name = "colTC";
            this.colTC.Visible = true;
            this.colTC.VisibleIndex = 4;
            // 
            // colMAIL
            // 
            this.colMAIL.FieldName = "MAIL";
            this.colMAIL.Name = "colMAIL";
            this.colMAIL.Visible = true;
            this.colMAIL.VisibleIndex = 5;
            // 
            // colIL
            // 
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.Visible = true;
            this.colIL.VisibleIndex = 6;
            // 
            // colILCE
            // 
            this.colILCE.FieldName = "ILCE";
            this.colILCE.Name = "colILCE";
            this.colILCE.Visible = true;
            this.colILCE.VisibleIndex = 7;
            // 
            // colADRES
            // 
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.Visible = true;
            this.colADRES.VisibleIndex = 8;
            // 
            // colGOREV
            // 
            this.colGOREV.FieldName = "GOREV";
            this.colGOREV.Name = "colGOREV";
            this.colGOREV.Visible = true;
            this.colGOREV.VisibleIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLPERSONELLERBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 164);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 354);
            this.gridControl1.TabIndex = 71;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 87);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(874, 77);
            this.groupControl1.TabIndex = 72;
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
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(292, 6);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 82;
            this.labelControl8.Text = "PERS IL :";
            // 
            // txtPersIl
            // 
            this.txtPersIl.Location = new System.Drawing.Point(339, 3);
            this.txtPersIl.Name = "txtPersIl";
            this.txtPersIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersIl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sehir", "Şehir")});
            this.txtPersIl.Properties.DataSource = this.illerBindingSource;
            this.txtPersIl.Properties.DisplayMember = "sehir";
            this.txtPersIl.Properties.NullText = "";
            this.txtPersIl.Properties.ValueMember = "id";
            this.txtPersIl.Size = new System.Drawing.Size(140, 20);
            this.txtPersIl.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(499, 7);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(69, 13);
            this.labelControl10.TabIndex = 87;
            this.labelControl10.Text = "PERS GOREV :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(497, 33);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 86;
            this.labelControl9.Text = "PERS ADRES  :";
            // 
            // txtPersAdres
            // 
            this.txtPersAdres.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtPersAdres.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtPersAdres.Location = new System.Drawing.Point(571, 30);
            this.txtPersAdres.Name = "txtPersAdres";
            this.txtPersAdres.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtPersAdres.Size = new System.Drawing.Size(298, 46);
            this.txtPersAdres.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(276, 32);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 13);
            this.labelControl7.TabIndex = 84;
            this.labelControl7.Text = "PERS ILCE  :";
            // 
            // txtPersGorev
            // 
            this.txtPersGorev.Location = new System.Drawing.Point(571, 4);
            this.txtPersGorev.Name = "txtPersGorev";
            this.txtPersGorev.Size = new System.Drawing.Size(298, 20);
            this.txtPersGorev.TabIndex = 6;
            // 
            // txtPersIlce
            // 
            this.txtPersIlce.Location = new System.Drawing.Point(339, 29);
            this.txtPersIlce.Name = "txtPersIlce";
            this.txtPersIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersIlce.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ilce", "İlçe")});
            this.txtPersIlce.Properties.DataSource = this.ilcelerBindingSource;
            this.txtPersIlce.Properties.DisplayMember = "ilce";
            this.txtPersIlce.Properties.NullText = "";
            this.txtPersIlce.Properties.ValueMember = "id";
            this.txtPersIlce.Size = new System.Drawing.Size(140, 20);
            this.txtPersIlce.TabIndex = 5;
            // 
            // txtPersMail
            // 
            this.txtPersMail.Location = new System.Drawing.Point(106, 56);
            this.txtPersMail.Name = "txtPersMail";
            this.txtPersMail.Size = new System.Drawing.Size(141, 20);
            this.txtPersMail.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 75;
            this.labelControl2.Text = "PERS MAIL :";
            // 
            // txtPersAd
            // 
            this.txtPersAd.Location = new System.Drawing.Point(106, 4);
            this.txtPersAd.Name = "txtPersAd";
            this.txtPersAd.Size = new System.Drawing.Size(70, 20);
            this.txtPersAd.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "PERS AD SOYAD :";
            // 
            // txtPersSoyad
            // 
            this.txtPersSoyad.Location = new System.Drawing.Point(177, 4);
            this.txtPersSoyad.Name = "txtPersSoyad";
            this.txtPersSoyad.Size = new System.Drawing.Size(70, 20);
            this.txtPersSoyad.TabIndex = 1;
            // 
            // txtPersTel
            // 
            this.txtPersTel.Location = new System.Drawing.Point(106, 30);
            this.txtPersTel.Name = "txtPersTel";
            this.txtPersTel.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtPersTel.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtPersTel.Properties.MaskSettings.Set("mask", "(\\d\\d\\d) \\d\\d\\d-\\d\\d\\d\\d");
            this.txtPersTel.Size = new System.Drawing.Size(141, 20);
            this.txtPersTel.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(52, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 13);
            this.labelControl6.TabIndex = 97;
            this.labelControl6.Text = "PERS TEL :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(288, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 99;
            this.labelControl3.Text = "PERS TC :";
            // 
            // txtPersTc
            // 
            this.txtPersTc.Location = new System.Drawing.Point(339, 55);
            this.txtPersTc.Name = "txtPersTc";
            this.txtPersTc.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtPersTc.Properties.MaskSettings.Set("mask", "00000000000");
            this.txtPersTc.Size = new System.Drawing.Size(140, 20);
            this.txtPersTc.TabIndex = 98;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 518);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtPersTc);
            this.Controls.Add(this.txtPersTel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPersSoyad);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtPersIl);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtPersAdres);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtPersGorev);
            this.Controls.Add(this.txtPersIlce);
            this.Controls.Add(this.txtPersMail);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPersAd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 550);
            this.MinimumSize = new System.Drawing.Size(876, 550);
            this.Name = "FrmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPersIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersTc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
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
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit txtPersIl;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraRichEdit.RichEditControl txtPersAdres;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPersGorev;
        private DevExpress.XtraEditors.LookUpEdit txtPersIlce;
        private System.Windows.Forms.BindingSource ilcelerBindingSource;
        private DevExpress.XtraEditors.TextEdit txtPersMail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPersAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPersSoyad;
        private DevExpress.XtraEditors.TextEdit txtPersTel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn colILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colGOREV;
        private System.Windows.Forms.BindingSource tBLPERSONELLERBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPersTc;
    }
}