using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLy.Models;
using AppQuanLy.Helper;
using FastMember;
namespace AppQuanLy.GUI
{
     public partial class BooksUC : UserControl
     {
          public BooksUC()
          {
               InitializeComponent();
          }
          public void BooksUC_Load(object sender, EventArgs e)
          {
               var data = JSONHelper.SendGetRequest<List<BookViewModel>>("sach?number");
               this.gridctrlBook.DataSource = data;
               EstablishBtn(true);
               EstablishInputBox(true);
          }
          public void EstablishBtn(bool flag)
          {
               btnAdd.Enabled = flag;
               btnEdit.Enabled = flag;
               btnDelete.Enabled = flag;
               btnSave.Enabled = flag;
          }
          public void EstablishInputBox(bool flag)
          {
               txtbCode.Enabled = flag;
               txtbImage.Enabled = flag;
               txtbPrice.Enabled = flag;
               txtbWeight.Enabled = flag;
               txtboxName.Enabled = flag;
               txtbNumberPage.Enabled = flag;
               txtbDescription.Enabled = flag;
               cmbboxAuthor.Enabled = flag;
               cmbboxCategory.Enabled = flag;
               cmbboxPublisher.Enabled = flag;
               cmbboxRealeased.Enabled = flag;
          }
          public void ResetInputBox()
          {
               txtbCode.Text = null;
               txtbImage.Text = null;
               txtbPrice.Text = null;
               txtbWeight.Text = null;
               txtboxName.Text = null;
               txtbNumberPage.Text = null;
               txtbDescription.Text = null;
               cmbboxAuthor.Text = null;
               cmbboxCategory.Text = null;
               cmbboxPublisher.Text = null;
               cmbboxRealeased.Text = null;
          }
          private void gridviewBook_ForcusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
          {
               var row = (BookViewModel)gridviewBook.GetRow(gridviewBook.GetSelectedRows()[0]);
               txtbCode.Text = row.Code;
               txtbImage.Text = row.Image;
               txtbPrice.Text = row.Price.ToString();
               txtbWeight.Text = row.Weight.ToString();
               txtboxName.Text = row.Name;
               txtbNumberPage.Text = row.NumberPage.ToString();
               txtbDescription.Text = row.Description;
               cmbboxAuthor.Text = row.Author;
               cmbboxCategory.Text = row.CategoryID.ToString();
               cmbboxPublisher.Text = row.Publisher;
               cmbboxRealeased.Text = row.Released;
          }

          private void btnAdd_Click(object sender, EventArgs e)
          {
               ResetInputBox();
               btnDelete.Enabled = false;
               btnAdd.Click -= btnAdd_Click;
               btnAdd.Click += BtnAdd_Click;
          }

          private void BtnAdd_Click(object sender, EventArgs e)
          {
               var bk = new BookViewModel();
               JSONHelper.SendPostRequest<BookViewModel>("book",bk);
          }
     }
}
