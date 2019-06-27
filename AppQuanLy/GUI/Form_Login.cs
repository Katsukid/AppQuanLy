using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLy.DAO;
using AppQuanLy;

namespace AppQuanLy.GUI
{
     public partial class Form_Login : Form
     {
          string Username = "";
          string Password = "";
          public Form_Login()
          {
               InitializeComponent();
               txtboxPassword.PasswordChar = '*';
          }
          // Login click
          private void simbtnLogin_Click(object sender, EventArgs e)
          {
               string username = this.txtboxUsername.Text;
               string password = this.txtboxPassword.Text;
               if (username.Equals("") || password.Equals(""))
               {
                    MessageBox.Show("You must enter Username and Password");
                    return;
               }
               // Gui thong tin dang nhap de kiem tra
               var result = LoginDAO.LoginRequest("user/login", username, password);
               if (result)
               {
                    this.Username = username;
                    this.Password = password;
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Show();
                    resetLoginForm();
               }
               else
               {
                    this.lbWarning.Show();
               }
          }
          private void resetLoginForm()
          {
               txtboxUsername.Text = "";
               txtboxPassword.Text = "";
          }
          // Cancel click
          private void simbtnCancel_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
     }
}
