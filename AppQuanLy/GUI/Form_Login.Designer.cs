namespace AppQuanLy.GUI
{
     partial class Form_Login
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
               this.lbWarning = new System.Windows.Forms.Label();
               this.simbtnCancel = new DevExpress.XtraEditors.SimpleButton();
               this.simbtnLogin = new DevExpress.XtraEditors.SimpleButton();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.txtboxPassword = new System.Windows.Forms.TextBox();
               this.txtboxUsername = new System.Windows.Forms.TextBox();
               this.lbPassword = new System.Windows.Forms.Label();
               this.lbUsername = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // lbWarning
               // 
               this.lbWarning.AutoSize = true;
               this.lbWarning.ForeColor = System.Drawing.Color.Maroon;
               this.lbWarning.Location = new System.Drawing.Point(372, 47);
               this.lbWarning.Name = "lbWarning";
               this.lbWarning.Size = new System.Drawing.Size(193, 17);
               this.lbWarning.TabIndex = 15;
               this.lbWarning.Text = "Wrong Userame or Password";
               this.lbWarning.Visible = false;
               // 
               // simbtnCancel
               // 
               this.simbtnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
               this.simbtnCancel.Location = new System.Drawing.Point(505, 185);
               this.simbtnCancel.Name = "simbtnCancel";
               this.simbtnCancel.Size = new System.Drawing.Size(75, 23);
               this.simbtnCancel.TabIndex = 13;
               this.simbtnCancel.Text = "Cancel";
               this.simbtnCancel.Click += new System.EventHandler(this.simbtnCancel_Click);
               // 
               // simbtnLogin
               // 
               this.simbtnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
               this.simbtnLogin.Location = new System.Drawing.Point(342, 185);
               this.simbtnLogin.Name = "simbtnLogin";
               this.simbtnLogin.Size = new System.Drawing.Size(75, 23);
               this.simbtnLogin.TabIndex = 11;
               this.simbtnLogin.Text = "Login";
               this.simbtnLogin.Click += new System.EventHandler(this.simbtnLogin_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(12, 12);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(233, 224);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 14;
               this.pictureBox1.TabStop = false;
               // 
               // txtboxPassword
               // 
               this.txtboxPassword.Location = new System.Drawing.Point(342, 122);
               this.txtboxPassword.Name = "txtboxPassword";
               this.txtboxPassword.Size = new System.Drawing.Size(252, 22);
               this.txtboxPassword.TabIndex = 9;
               // 
               // txtboxUsername
               // 
               this.txtboxUsername.Location = new System.Drawing.Point(342, 82);
               this.txtboxUsername.Name = "txtboxUsername";
               this.txtboxUsername.Size = new System.Drawing.Size(252, 22);
               this.txtboxUsername.TabIndex = 8;
               // 
               // lbPassword
               // 
               this.lbPassword.AutoSize = true;
               this.lbPassword.Location = new System.Drawing.Point(260, 128);
               this.lbPassword.Name = "lbPassword";
               this.lbPassword.Size = new System.Drawing.Size(69, 17);
               this.lbPassword.TabIndex = 12;
               this.lbPassword.Text = "Password";
               // 
               // lbUsername
               // 
               this.lbUsername.AutoSize = true;
               this.lbUsername.Location = new System.Drawing.Point(257, 86);
               this.lbUsername.Name = "lbUsername";
               this.lbUsername.Size = new System.Drawing.Size(73, 17);
               this.lbUsername.TabIndex = 10;
               this.lbUsername.Text = "Username";
               // 
               // Form_Login
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(669, 269);
               this.Controls.Add(this.lbWarning);
               this.Controls.Add(this.simbtnCancel);
               this.Controls.Add(this.simbtnLogin);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.txtboxPassword);
               this.Controls.Add(this.txtboxUsername);
               this.Controls.Add(this.lbPassword);
               this.Controls.Add(this.lbUsername);
               this.Name = "Form_Login";
               this.Text = "Welcome to Manager Application";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label lbWarning;
          private DevExpress.XtraEditors.SimpleButton simbtnCancel;
          private DevExpress.XtraEditors.SimpleButton simbtnLogin;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.TextBox txtboxPassword;
          private System.Windows.Forms.TextBox txtboxUsername;
          private System.Windows.Forms.Label lbPassword;
          private System.Windows.Forms.Label lbUsername;
     }
}