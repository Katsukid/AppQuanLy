namespace AppQuanLy.GUI
{
     partial class AuthorTypeUC
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
               this.label1 = new System.Windows.Forms.Label();
               this.txtAuthorTypeName = new System.Windows.Forms.TextBox();
               this.sbtnAuthorType = new DevExpress.XtraEditors.SimpleButton();
               this.grCtrlAuthorType = new DevExpress.XtraGrid.GridControl();
               this.authorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.sbtnEdit = new DevExpress.XtraEditors.SimpleButton();
               this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
               this.sbtnDelete = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.grCtrlAuthorType)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorTypeBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(436, 185);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(45, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "Name";
               // 
               // txtAuthorTypeName
               // 
               this.txtAuthorTypeName.Location = new System.Drawing.Point(499, 179);
               this.txtAuthorTypeName.Name = "txtAuthorTypeName";
               this.txtAuthorTypeName.Size = new System.Drawing.Size(167, 22);
               this.txtAuthorTypeName.TabIndex = 1;
               // 
               // sbtnAuthorType
               // 
               this.sbtnAuthorType.Location = new System.Drawing.Point(354, 228);
               this.sbtnAuthorType.Name = "sbtnAuthorType";
               this.sbtnAuthorType.Size = new System.Drawing.Size(100, 33);
               this.sbtnAuthorType.TabIndex = 2;
               this.sbtnAuthorType.Text = "Add";
               this.sbtnAuthorType.Click += new System.EventHandler(this.sbtnAuthorType_Click);
               // 
               // grCtrlAuthorType
               // 
               this.grCtrlAuthorType.DataSource = this.authorTypeBindingSource;
               this.grCtrlAuthorType.Location = new System.Drawing.Point(243, 316);
               this.grCtrlAuthorType.MainView = this.gridView1;
               this.grCtrlAuthorType.Name = "grCtrlAuthorType";
               this.grCtrlAuthorType.Size = new System.Drawing.Size(710, 331);
               this.grCtrlAuthorType.TabIndex = 3;
               this.grCtrlAuthorType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
               this.grCtrlAuthorType.Load += new System.EventHandler(this.AuthorTypeUC_Load);
               // 
               // authorTypeBindingSource
               // 
               this.authorTypeBindingSource.DataSource = typeof(AppQuanLy.Entities.AuthorType);
               // 
               // gridView1
               // 
               this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
               this.gridView1.GridControl = this.grCtrlAuthorType;
               this.gridView1.Name = "gridView1";
               // 
               // colID
               // 
               this.colID.FieldName = "ID";
               this.colID.Name = "colID";
               this.colID.Visible = true;
               this.colID.VisibleIndex = 0;
               // 
               // colName
               // 
               this.colName.FieldName = "Name";
               this.colName.Name = "colName";
               this.colName.Visible = true;
               this.colName.VisibleIndex = 1;
               // 
               // textBox1
               // 
               this.textBox1.Enabled = false;
               this.textBox1.Location = new System.Drawing.Point(499, 151);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(167, 22);
               this.textBox1.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(436, 156);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(21, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "ID";
               // 
               // sbtnEdit
               // 
               this.sbtnEdit.Location = new System.Drawing.Point(472, 228);
               this.sbtnEdit.Name = "sbtnEdit";
               this.sbtnEdit.Size = new System.Drawing.Size(100, 33);
               this.sbtnEdit.TabIndex = 2;
               this.sbtnEdit.Text = "Edit";
               this.sbtnEdit.Click += new System.EventHandler(this.sbtnAuthorType_Click);
               // 
               // sbtnSave
               // 
               this.sbtnSave.Location = new System.Drawing.Point(590, 228);
               this.sbtnSave.Name = "sbtnSave";
               this.sbtnSave.Size = new System.Drawing.Size(100, 33);
               this.sbtnSave.TabIndex = 2;
               this.sbtnSave.Text = "Save";
               this.sbtnSave.Click += new System.EventHandler(this.sbtnAuthorType_Click);
               // 
               // sbtnDelete
               // 
               this.sbtnDelete.Location = new System.Drawing.Point(712, 228);
               this.sbtnDelete.Name = "sbtnDelete";
               this.sbtnDelete.Size = new System.Drawing.Size(100, 33);
               this.sbtnDelete.TabIndex = 2;
               this.sbtnDelete.Text = "Delete";
               this.sbtnDelete.Click += new System.EventHandler(this.sbtnAuthorType_Click);
               // 
               // label3
               // 
               this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(429, 29);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(300, 75);
               this.label3.TabIndex = 4;
               this.label3.Text = "Loại tác giả";
               this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // AuthorTypeUC
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.label3);
               this.Controls.Add(this.grCtrlAuthorType);
               this.Controls.Add(this.sbtnDelete);
               this.Controls.Add(this.sbtnSave);
               this.Controls.Add(this.sbtnEdit);
               this.Controls.Add(this.sbtnAuthorType);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.txtAuthorTypeName);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Name = "AuthorTypeUC";
               this.Size = new System.Drawing.Size(1185, 721);
               ((System.ComponentModel.ISupportInitialize)(this.grCtrlAuthorType)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.authorTypeBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox txtAuthorTypeName;
          private DevExpress.XtraEditors.SimpleButton sbtnAuthorType;
          private DevExpress.XtraGrid.GridControl grCtrlAuthorType;
          private System.Windows.Forms.BindingSource authorTypeBindingSource;
          private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
          private DevExpress.XtraGrid.Columns.GridColumn colID;
          private DevExpress.XtraGrid.Columns.GridColumn colName;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Label label2;
          private DevExpress.XtraEditors.SimpleButton sbtnEdit;
          private DevExpress.XtraEditors.SimpleButton sbtnSave;
          private DevExpress.XtraEditors.SimpleButton sbtnDelete;
          private System.Windows.Forms.Label label3;
     }
}
