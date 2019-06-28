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
using AppQuanLy.Entities;
using FastMember;
using AppQuanLy.DAO;
using System.IO;
using CKEditorBrowserControls;
using DevExpress.XtraBars.Navigation;

namespace AppQuanLy.GUI
{
     public partial class BooksUC : UserControl
     {
          private AppQuanLyDbContext db;
          private List<Author> authors;
          private List<BookCategory> bookcate;
          private List<Publisher> pub;
          private List<Publisher> pub2;

          static String curDir = Directory.GetCurrentDirectory().Replace("\\bin\\Debug","");
          static Uri ckEditorUri = new Uri(String.Format("file:///{0}/Resources/Ckeditor/index.html", curDir));
          CKEditorControl ckEditorCtrl = new CKEditorControl(ckEditorUri)
          {
               Dock = DockStyle.Fill
          };
          public BooksUC()
          {
               db = new AppQuanLyDbContext();
               authors = db.Authors;
               bookcate = db.BookCategories;
               pub = db.Publishers;
               pub2 = db.Publishers;
               InitializeComponent();
          }
          public void BooksUC_Load(object sender, EventArgs e)
          {
               var dao = new BookDao();
               var data = db.Books.Select(x => dao.toViewModel(x));
               this.gridctrlBook.DataSource = data;
               cmbboxAuthor.DataSource = authors;
               cmbboxCategory.DataSource = bookcate;
               cmbboxPublisher.DataSource = pub;
               cmbboxRealeased.DataSource = pub2;
               EstablishBtn(true);
               EstablishInputBox(true);
               tabPg.Controls.Add(ckEditorCtrl);
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
               cmbboxAuthor.SelectedValue = row.AuthorID;
               cmbboxCategory.SelectedValue = row.CategoryID;
               cmbboxPublisher.SelectedValue = row.PublisherID;
               cmbboxRealeased.SelectedValue = row.ReleasedID;
               txtbImage.Text = row.Image;
               pckbxImg.ImageLocation = "http://localhost:10744" + row.Image.Replace("\\","/");
               //cmbboxAuthor.SelectedText = row.Author;
               //cmbboxCategory.SelectedText = row.Category;
               //cmbboxPublisher.SelectedText = row.Publisher;
               //cmbboxRealeased.SelectedText = row.Released;
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

          private void label8_Click(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               var listImgWF = new ListImageWF();
               listImgWF.Show();
          }
     }
}
