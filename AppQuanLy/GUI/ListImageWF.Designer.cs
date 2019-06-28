namespace AppQuanLy.GUI
{
     partial class ListImageWF
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
               this.spBtnChoise = new DevExpress.XtraEditors.SimpleButton();
               this.dtGrdView = new System.Windows.Forms.DataGridView();
               this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dtGrdView)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // spBtnChoise
               // 
               this.spBtnChoise.Location = new System.Drawing.Point(1166, 12);
               this.spBtnChoise.Name = "spBtnChoise";
               this.spBtnChoise.Size = new System.Drawing.Size(157, 36);
               this.spBtnChoise.TabIndex = 1;
               this.spBtnChoise.Text = "Choise";
               // 
               // dtGrdView
               // 
               this.dtGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dtGrdView.Location = new System.Drawing.Point(12, 12);
               this.dtGrdView.Name = "dtGrdView";
               this.dtGrdView.RowTemplate.Height = 24;
               this.dtGrdView.Size = new System.Drawing.Size(945, 675);
               this.dtGrdView.TabIndex = 2;
               // 
               // imageBindingSource
               // 
               this.imageBindingSource.DataSource = typeof(AppQuanLy.Entities.Image);
               // 
               // ListImageWF
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1380, 711);
               this.Controls.Add(this.dtGrdView);
               this.Controls.Add(this.spBtnChoise);
               this.Name = "ListImageWF";
               this.Text = "ListImageWF";
               this.Load += new System.EventHandler(this.ListImageWF_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dtGrdView)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private System.Windows.Forms.BindingSource imageBindingSource;
          private DevExpress.XtraEditors.SimpleButton spBtnChoise;
          private System.Windows.Forms.DataGridView dtGrdView;
     }
}