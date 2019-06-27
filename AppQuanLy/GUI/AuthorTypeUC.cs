using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLy.Helper;
using AppQuanLy.Entities;
using AppQuanLy.DAO;
namespace AppQuanLy.GUI
{
     public partial class AuthorTypeUC : UserControl
     {
          public AuthorTypeUC()
          {
               InitializeComponent();
          }
          public void AuthorTypeUC_Load(object sender, EventArgs e)
          {
               var data = AuthorTypeDao.TakeAll();
               this.grCtrlAuthorType.DataSource = data;
          }
          private void sbtnAuthorType_Click(object sender, EventArgs e)
          {
               var x = txtAuthorTypeName.Text;
               var temp = new AuthorType() { Name = x };
               var temp2 = JSONHelper.SendPostRequest<AuthorType>("authortype", temp);
               txtAuthorTypeName.Text = "";
          }
     }
}
