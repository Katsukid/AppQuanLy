using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLy.DAO;

namespace AppQuanLy.GUI
{
     public partial class AuthorUC : UserControl
     {
          public AuthorUC()
          {
               InitializeComponent();
          }
          public void AuthorUC_Load(object sender, EventArgs e)
          {
               var data = AuthorDao.TakeAllView(null);
               this.gridControl1.DataSource = data;
          }
     }
}
