namespace AppQuanLy.GUI
{
     partial class AuthorUC
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               this.gridControl1 = new DevExpress.XtraGrid.GridControl();
               this.authorViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colnumberBooks = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colAuthorType = new DevExpress.XtraGrid.Columns.GridColumn();
               this.authorViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // gridControl1
               // 
               this.gridControl1.DataSource = this.authorViewModelBindingSource1;
               this.gridControl1.Location = new System.Drawing.Point(0, 225);
               this.gridControl1.MainView = this.gridView1;
               this.gridControl1.Name = "gridControl1";
               this.gridControl1.Size = new System.Drawing.Size(1612, 529);
               this.gridControl1.TabIndex = 0;
               this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
               // 
               // authorViewModelBindingSource1
               // 
               this.authorViewModelBindingSource1.DataSource = typeof(AppQuanLy.Models.AuthorViewModel);
               // 
               // gridView1
               // 
               this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colType,
            this.colnumberBooks,
            this.colID,
            this.colName,
            this.colDateOfBirth,
            this.colDescription,
            this.colImage,
            this.colAuthorType});
               this.gridView1.GridControl = this.gridControl1;
               this.gridView1.Name = "gridView1";
               // 
               // colType
               // 
               this.colType.FieldName = "Type";
               this.colType.Name = "colType";
               this.colType.Visible = true;
               this.colType.VisibleIndex = 2;
               this.colType.Width = 165;
               // 
               // colnumberBooks
               // 
               this.colnumberBooks.FieldName = "Số sách";
               this.colnumberBooks.Name = "colnumberBooks";
               this.colnumberBooks.Visible = true;
               this.colnumberBooks.VisibleIndex = 6;
               this.colnumberBooks.Width = 118;
               // 
               // colID
               // 
               this.colID.FieldName = "ID";
               this.colID.Name = "colID";
               this.colID.Visible = true;
               this.colID.VisibleIndex = 0;
               this.colID.Width = 64;
               // 
               // colName
               // 
               this.colName.FieldName = "Name";
               this.colName.Name = "colName";
               this.colName.Visible = true;
               this.colName.VisibleIndex = 1;
               this.colName.Width = 254;
               // 
               // colDateOfBirth
               // 
               this.colDateOfBirth.FieldName = "DateOfBirth";
               this.colDateOfBirth.Name = "colDateOfBirth";
               this.colDateOfBirth.Visible = true;
               this.colDateOfBirth.VisibleIndex = 3;
               this.colDateOfBirth.Width = 128;
               // 
               // colDescription
               // 
               this.colDescription.FieldName = "Description";
               this.colDescription.Name = "colDescription";
               this.colDescription.Visible = true;
               this.colDescription.VisibleIndex = 4;
               this.colDescription.Width = 597;
               // 
               // colImage
               // 
               this.colImage.FieldName = "Hình ảnh";
               this.colImage.Name = "colImage";
               this.colImage.Visible = true;
               this.colImage.VisibleIndex = 5;
               this.colImage.Width = 266;
               // 
               // colAuthorType
               // 
               this.colAuthorType.FieldName = "AuthorType";
               this.colAuthorType.Name = "colAuthorType";
               // 
               // authorViewModelBindingSource
               // 
               this.authorViewModelBindingSource.DataSource = typeof(AppQuanLy.Models.AuthorViewModel);
               // 
               // AuthorUC
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.gridControl1);
               this.Name = "AuthorUC";
               this.Size = new System.Drawing.Size(1635, 734);
               this.Load += new System.EventHandler(this.AuthorUC_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorViewModelBindingSource)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevExpress.XtraGrid.GridControl gridControl1;
          private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
          private System.Windows.Forms.BindingSource authorViewModelBindingSource;
          private System.Windows.Forms.BindingSource authorViewModelBindingSource1;
          private DevExpress.XtraGrid.Columns.GridColumn colType;
          private DevExpress.XtraGrid.Columns.GridColumn colnumberBooks;
          private DevExpress.XtraGrid.Columns.GridColumn colID;
          private DevExpress.XtraGrid.Columns.GridColumn colName;
          private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
          private DevExpress.XtraGrid.Columns.GridColumn colDescription;
          private DevExpress.XtraGrid.Columns.GridColumn colImage;
          private DevExpress.XtraGrid.Columns.GridColumn colAuthorType;
     }
}
