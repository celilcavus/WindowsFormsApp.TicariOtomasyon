﻿namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnPdf = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnXls = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMht = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNotDetay = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtNotOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNotTarih = new DevExpress.XtraEditors.DateEdit();
            this.tBLNOTLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTBASLIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTDETAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTOLUSTURAN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNOTLARBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // txtNotBaslik
            // 
            this.txtNotBaslik.Location = new System.Drawing.Point(83, 3);
            this.txtNotBaslik.Name = "txtNotBaslik";
            this.txtNotBaslik.Size = new System.Drawing.Size(214, 20);
            this.txtNotBaslik.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 110;
            this.labelControl1.Text = "NOT BASLIK :";
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
            this.colNOTTARIH,
            this.colNOTBASLIK,
            this.colNOTDETAY,
            this.colNOTOLUSTURAN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLNOTLARBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 187);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 329);
            this.gridControl1.TabIndex = 108;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.flowLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 110);
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
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "NOT DETAY :";
            // 
            // txtNotDetay
            // 
            this.txtNotDetay.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtNotDetay.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtNotDetay.Location = new System.Drawing.Point(83, 29);
            this.txtNotDetay.Name = "txtNotDetay";
            this.txtNotDetay.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.txtNotDetay.Size = new System.Drawing.Size(786, 75);
            this.txtNotDetay.TabIndex = 113;
            // 
            // txtNotOlusturan
            // 
            this.txtNotOlusturan.Location = new System.Drawing.Point(401, 3);
            this.txtNotOlusturan.Name = "txtNotOlusturan";
            this.txtNotOlusturan.Size = new System.Drawing.Size(214, 20);
            this.txtNotOlusturan.TabIndex = 114;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(304, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 13);
            this.labelControl3.TabIndex = 115;
            this.labelControl3.Text = "NOT OLUSTURAN :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(621, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 117;
            this.labelControl4.Text = "NOT TARIH :";
            // 
            // txtNotTarih
            // 
            this.txtNotTarih.EditValue = new System.DateTime(2023, 3, 14, 19, 56, 7, 0);
            this.txtNotTarih.Location = new System.Drawing.Point(689, 3);
            this.txtNotTarih.Name = "txtNotTarih";
            this.txtNotTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNotTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNotTarih.Properties.DisplayFormat.FormatString = "";
            this.txtNotTarih.Properties.EditFormat.FormatString = "";
            this.txtNotTarih.Properties.MaskSettings.Set("mask", "");
            this.txtNotTarih.Size = new System.Drawing.Size(180, 20);
            this.txtNotTarih.TabIndex = 116;
            // 
            // tBLNOTLARBindingSource
            // 
            this.tBLNOTLARBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLNOTLAR);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colNOTTARIH
            // 
            this.colNOTTARIH.FieldName = "NOTTARIH";
            this.colNOTTARIH.Name = "colNOTTARIH";
            this.colNOTTARIH.Visible = true;
            this.colNOTTARIH.VisibleIndex = 1;
            // 
            // colNOTBASLIK
            // 
            this.colNOTBASLIK.FieldName = "NOTBASLIK";
            this.colNOTBASLIK.Name = "colNOTBASLIK";
            this.colNOTBASLIK.Visible = true;
            this.colNOTBASLIK.VisibleIndex = 3;
            // 
            // colNOTDETAY
            // 
            this.colNOTDETAY.FieldName = "NOTDETAY";
            this.colNOTDETAY.Name = "colNOTDETAY";
            this.colNOTDETAY.Visible = true;
            this.colNOTDETAY.VisibleIndex = 4;
            // 
            // colNOTOLUSTURAN
            // 
            this.colNOTOLUSTURAN.FieldName = "NOTOLUSTURAN";
            this.colNOTOLUSTURAN.Name = "colNOTOLUSTURAN";
            this.colNOTOLUSTURAN.Visible = true;
            this.colNOTOLUSTURAN.VisibleIndex = 5;
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 516);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNotOlusturan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNotDetay);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNotBaslik);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtNotTarih);
            this.Name = "FrmNotlar";
            this.Text = "FrmNotlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNOTLARBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnPdf;
        private DevExpress.XtraEditors.TextEdit txtNotBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnMht;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraRichEdit.RichEditControl txtNotDetay;
        private DevExpress.XtraEditors.TextEdit txtNotOlusturan;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit txtNotTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTBASLIK;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTDETAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTOLUSTURAN;
        private System.Windows.Forms.BindingSource tBLNOTLARBindingSource;
    }
}