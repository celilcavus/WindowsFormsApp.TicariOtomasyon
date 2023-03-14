namespace WindowsFormsApp.TicariOtomasyon.Views
{
    partial class FrmRehber
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLFIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILISTATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILIADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFIRMALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(841, 491);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(839, 466);
            this.xtraTabPage1.Text = "Firmalar";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLFIRMALARBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(839, 466);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tBLFIRMALARBindingSource
            // 
            this.tBLFIRMALARBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLFIRMALAR);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAD,
            this.colYETKILISTATUS,
            this.colYETKILIADSOYAD,
            this.colTELEFON1,
            this.colTELEFON2,
            this.colMAIL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
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
            // colYETKILISTATUS
            // 
            this.colYETKILISTATUS.FieldName = "YETKILISTATUS";
            this.colYETKILISTATUS.Name = "colYETKILISTATUS";
            this.colYETKILISTATUS.Visible = true;
            this.colYETKILISTATUS.VisibleIndex = 2;
            // 
            // colYETKILIADSOYAD
            // 
            this.colYETKILIADSOYAD.FieldName = "YETKILIADSOYAD";
            this.colYETKILIADSOYAD.Name = "colYETKILIADSOYAD";
            this.colYETKILIADSOYAD.Visible = true;
            this.colYETKILIADSOYAD.VisibleIndex = 3;
            // 
            // colTELEFON1
            // 
            this.colTELEFON1.FieldName = "TELEFON1";
            this.colTELEFON1.Name = "colTELEFON1";
            this.colTELEFON1.Visible = true;
            this.colTELEFON1.VisibleIndex = 4;
            // 
            // colTELEFON2
            // 
            this.colTELEFON2.FieldName = "TELEFON2";
            this.colTELEFON2.Name = "colTELEFON2";
            this.colTELEFON2.Visible = true;
            this.colTELEFON2.VisibleIndex = 5;
            // 
            // colMAIL
            // 
            this.colMAIL.FieldName = "MAIL";
            this.colMAIL.Name = "colMAIL";
            this.colMAIL.Visible = true;
            this.colMAIL.VisibleIndex = 6;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(839, 466);
            this.xtraTabPage2.Text = "Müşteriler";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.tBLMUSTERILERBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(839, 466);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tBLMUSTERILERBindingSource
            // 
            this.tBLMUSTERILERBindingSource.DataSource = typeof(WindowsFormsApp.TicariOtomasyon.Model.TBLMUSTERILER);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colAD1,
            this.colSOYAD,
            this.colTELEFON,
            this.colTELEFON21,
            this.colMAIL1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colAD1
            // 
            this.colAD1.FieldName = "AD";
            this.colAD1.Name = "colAD1";
            this.colAD1.Visible = true;
            this.colAD1.VisibleIndex = 1;
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
            // colTELEFON21
            // 
            this.colTELEFON21.FieldName = "TELEFON2";
            this.colTELEFON21.Name = "colTELEFON21";
            this.colTELEFON21.Visible = true;
            this.colTELEFON21.VisibleIndex = 4;
            // 
            // colMAIL1
            // 
            this.colMAIL1.FieldName = "MAIL";
            this.colMAIL1.Name = "colMAIL1";
            this.colMAIL1.Visible = true;
            this.colMAIL1.VisibleIndex = 5;
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 491);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRehber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.FrmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFIRMALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource tBLFIRMALARBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILISTATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILIADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON1;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON2;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colAD1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON21;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL1;
    }
}