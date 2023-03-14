namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class FrmGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.txtGiderSu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdf = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderEkstraAciklama = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtGiderDogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderElektrik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXls = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colELEKTIRIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOGALGAZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINTERNET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAASLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEKSTRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEKSTRADETAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLGIDERLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMht = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiderMaaslar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderEkstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderInternet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiderTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderDogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderElektrik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGIDERLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderMaaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderEkstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarih.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiderSu
            // 
            this.txtGiderSu.EditValue = "0";
            this.txtGiderSu.Location = new System.Drawing.Point(72, 29);
            this.txtGiderSu.Name = "txtGiderSu";
            this.txtGiderSu.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderSu.Properties.MaskSettings.Set("mask", "n");
            this.txtGiderSu.Size = new System.Drawing.Size(141, 20);
            this.txtGiderSu.TabIndex = 102;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(50, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(20, 13);
            this.labelControl6.TabIndex = 116;
            this.labelControl6.Text = "SU :";
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
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(530, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 13);
            this.labelControl10.TabIndex = 115;
            this.labelControl10.Text = "TARIH :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(469, 32);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(99, 13);
            this.labelControl9.TabIndex = 114;
            this.labelControl9.Text = "EKSTRA AÇIKLAMA :";
            // 
            // txtGiderEkstraAciklama
            // 
            this.txtGiderEkstraAciklama.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtGiderEkstraAciklama.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtGiderEkstraAciklama.Location = new System.Drawing.Point(571, 29);
            this.txtGiderEkstraAciklama.Name = "txtGiderEkstraAciklama";
            this.txtGiderEkstraAciklama.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtGiderEkstraAciklama.Size = new System.Drawing.Size(298, 46);
            this.txtGiderEkstraAciklama.TabIndex = 107;
            // 
            // txtGiderDogalgaz
            // 
            this.txtGiderDogalgaz.EditValue = "0";
            this.txtGiderDogalgaz.Location = new System.Drawing.Point(72, 55);
            this.txtGiderDogalgaz.Name = "txtGiderDogalgaz";
            this.txtGiderDogalgaz.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderDogalgaz.Properties.MaskSettings.Set("mask", "n");
            this.txtGiderDogalgaz.Size = new System.Drawing.Size(141, 20);
            this.txtGiderDogalgaz.TabIndex = 103;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 111;
            this.labelControl2.Text = "DOĞALGAZ :";
            // 
            // txtGiderElektrik
            // 
            this.txtGiderElektrik.EditValue = "0";
            this.txtGiderElektrik.Location = new System.Drawing.Point(72, 3);
            this.txtGiderElektrik.Name = "txtGiderElektrik";
            this.txtGiderElektrik.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderElektrik.Properties.MaskSettings.Set("mask", "f");
            this.txtGiderElektrik.Size = new System.Drawing.Size(141, 20);
            this.txtGiderElektrik.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 110;
            this.labelControl1.Text = "ELEKTRIK :";
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colELEKTIRIK,
            this.colSU,
            this.colDOGALGAZ,
            this.colINTERNET,
            this.colMAASLAR,
            this.colEKSTRA,
            this.colEKSTRADETAY,
            this.colTARIH});
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
            // colELEKTIRIK
            // 
            this.colELEKTIRIK.FieldName = "ELEKTIRIK";
            this.colELEKTIRIK.Name = "colELEKTIRIK";
            this.colELEKTIRIK.Visible = true;
            this.colELEKTIRIK.VisibleIndex = 1;
            // 
            // colSU
            // 
            this.colSU.FieldName = "SU";
            this.colSU.Name = "colSU";
            this.colSU.Visible = true;
            this.colSU.VisibleIndex = 2;
            // 
            // colDOGALGAZ
            // 
            this.colDOGALGAZ.FieldName = "DOGALGAZ";
            this.colDOGALGAZ.Name = "colDOGALGAZ";
            this.colDOGALGAZ.Visible = true;
            this.colDOGALGAZ.VisibleIndex = 3;
            // 
            // colINTERNET
            // 
            this.colINTERNET.FieldName = "INTERNET";
            this.colINTERNET.Name = "colINTERNET";
            this.colINTERNET.Visible = true;
            this.colINTERNET.VisibleIndex = 4;
            // 
            // colMAASLAR
            // 
            this.colMAASLAR.FieldName = "MAASLAR";
            this.colMAASLAR.Name = "colMAASLAR";
            this.colMAASLAR.Visible = true;
            this.colMAASLAR.VisibleIndex = 5;
            // 
            // colEKSTRA
            // 
            this.colEKSTRA.FieldName = "EKSTRA";
            this.colEKSTRA.Name = "colEKSTRA";
            this.colEKSTRA.Visible = true;
            this.colEKSTRA.VisibleIndex = 6;
            // 
            // colEKSTRADETAY
            // 
            this.colEKSTRADETAY.FieldName = "EKSTRADETAY";
            this.colEKSTRADETAY.Name = "colEKSTRADETAY";
            this.colEKSTRADETAY.Visible = true;
            this.colEKSTRADETAY.VisibleIndex = 7;
            // 
            // colTARIH
            // 
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLGIDERLERBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 158);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(876, 354);
            this.gridControl1.TabIndex = 108;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLGIDERLERBindingSource
            // 
            this.tBLGIDERLERBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLGIDERLER);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 81);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(876, 77);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(872, 52);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // txtGiderMaaslar
            // 
            this.txtGiderMaaslar.EditValue = "0";
            this.txtGiderMaaslar.Location = new System.Drawing.Point(300, 29);
            this.txtGiderMaaslar.Name = "txtGiderMaaslar";
            this.txtGiderMaaslar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderMaaslar.Properties.MaskSettings.Set("mask", "n");
            this.txtGiderMaaslar.Size = new System.Drawing.Size(141, 20);
            this.txtGiderMaaslar.TabIndex = 118;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(244, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 122;
            this.labelControl3.Text = "MAAŞLAR :";
            // 
            // txtGiderEkstra
            // 
            this.txtGiderEkstra.EditValue = "0";
            this.txtGiderEkstra.Location = new System.Drawing.Point(300, 55);
            this.txtGiderEkstra.Name = "txtGiderEkstra";
            this.txtGiderEkstra.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderEkstra.Properties.MaskSettings.Set("mask", "n");
            this.txtGiderEkstra.Size = new System.Drawing.Size(141, 20);
            this.txtGiderEkstra.TabIndex = 119;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(253, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 121;
            this.labelControl4.Text = "EKSTRA :";
            // 
            // txtGiderInternet
            // 
            this.txtGiderInternet.EditValue = "0";
            this.txtGiderInternet.Location = new System.Drawing.Point(300, 3);
            this.txtGiderInternet.Name = "txtGiderInternet";
            this.txtGiderInternet.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtGiderInternet.Properties.MaskSettings.Set("mask", "n");
            this.txtGiderInternet.Size = new System.Drawing.Size(141, 20);
            this.txtGiderInternet.TabIndex = 117;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(242, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 13);
            this.labelControl5.TabIndex = 120;
            this.labelControl5.Text = "INTERNET :";
            // 
            // txtGiderTarih
            // 
            this.txtGiderTarih.EditValue = new System.DateTime(2023, 3, 14, 13, 0, 1, 0);
            this.txtGiderTarih.Location = new System.Drawing.Point(571, 3);
            this.txtGiderTarih.Name = "txtGiderTarih";
            this.txtGiderTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiderTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiderTarih.Properties.DisplayFormat.FormatString = "";
            this.txtGiderTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGiderTarih.Properties.EditFormat.FormatString = "";
            this.txtGiderTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtGiderTarih.Properties.MaskSettings.Set("mask", "f");
            this.txtGiderTarih.Size = new System.Drawing.Size(298, 20);
            this.txtGiderTarih.TabIndex = 106;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 512);
            this.Controls.Add(this.txtGiderMaaslar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGiderEkstra);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtGiderInternet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtGiderSu);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtGiderEkstraAciklama);
            this.Controls.Add(this.txtGiderDogalgaz);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtGiderElektrik);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtGiderTarih);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(878, 544);
            this.MinimumSize = new System.Drawing.Size(878, 544);
            this.Name = "FrmGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderDogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderElektrik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGIDERLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderMaaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderEkstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiderTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtGiderSu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnPdf;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraRichEdit.RichEditControl txtGiderEkstraAciklama;
        private DevExpress.XtraEditors.TextEdit txtGiderDogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGiderElektrik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnMht;
        private DevExpress.XtraEditors.TextEdit txtGiderMaaslar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtGiderEkstra;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGiderInternet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit txtGiderTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colELEKTIRIK;
        private DevExpress.XtraGrid.Columns.GridColumn colSU;
        private DevExpress.XtraGrid.Columns.GridColumn colDOGALGAZ;
        private DevExpress.XtraGrid.Columns.GridColumn colINTERNET;
        private DevExpress.XtraGrid.Columns.GridColumn colMAASLAR;
        private DevExpress.XtraGrid.Columns.GridColumn colEKSTRA;
        private DevExpress.XtraGrid.Columns.GridColumn colEKSTRADETAY;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private System.Windows.Forms.BindingSource tBLGIDERLERBindingSource;
    }
}