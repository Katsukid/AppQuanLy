using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppQuanLy.GUI;
namespace AppQuanLy
{
     public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
     {
          public Home()
          {
               InitializeComponent();
          }

          private void barBtnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
          }

          private void barBtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               
          }

          private void barBtnBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               BooksUC bUC = new BooksUC();
               bUC.Dock = DockStyle.Fill;
               layctrlHome.Controls.Clear();
               layctrlHome.Controls.Add(bUC);
          }

          private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               AuthorTypeUC atUC = new AuthorTypeUC();
               atUC.Dock = DockStyle.Fill;
               layctrlHome.Controls.Clear();
               layctrlHome.Controls.Add(atUC);
          }

          private void barBtnAuthor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               AuthorUC aUC = new AuthorUC();
               aUC.Dock = DockStyle.Fill;
               layctrlHome.Controls.Clear();
               layctrlHome.Controls.Add(aUC);
          }

          private void barBtnImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               ImageUC aUC = new ImageUC();
               aUC.Dock = DockStyle.Fill;
               layctrlHome.Controls.Clear();
               layctrlHome.Controls.Add(aUC);
          }
     }
}
