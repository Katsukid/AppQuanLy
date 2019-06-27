namespace AppQuanLy.GUI
{
     partial class ImageUC
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
               this.grCtrlImage = new DevExpress.XtraGrid.GridControl();
               this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
               ((System.ComponentModel.ISupportInitialize)(this.grCtrlImage)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // grCtrlImage
               // 
               this.grCtrlImage.Location = new System.Drawing.Point(4, 218);
               this.grCtrlImage.MainView = this.gridView1;
               this.grCtrlImage.Name = "grCtrlImage";
               this.grCtrlImage.Size = new System.Drawing.Size(1073, 318);
               this.grCtrlImage.TabIndex = 0;
               this.grCtrlImage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
               // 
               // gridView1
               // 
               this.gridView1.GridControl = this.grCtrlImage;
               this.gridView1.Name = "gridView1";
               // 
               // ImageUC
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.grCtrlImage);
               this.Name = "ImageUC";
               this.Size = new System.Drawing.Size(1077, 536);
               this.Load += new System.EventHandler(this.ImageUC_Load);
               ((System.ComponentModel.ISupportInitialize)(this.grCtrlImage)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevExpress.XtraGrid.GridControl grCtrlImage;
          private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
     }
}
