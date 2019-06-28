using AppQuanLy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLy.GUI
{
     public partial class ListImageWF : Form
     {
          AppQuanLyDbContext db;
          public ListImageWF()
          {
               InitializeComponent();
               db = new AppQuanLyDbContext();
          }

          private void ListImageWF_Load(object sender, EventArgs e)
          {
               var temp = db.Images;
               foreach (var i in temp)
               {
                    i.Link = "http://localhost:10744" + i.Link.Replace("\\", "/");
               }
               DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
               imgCol.HeaderText = "Image";
               imgCol.Name = "colImage";
               dtGrdView.Columns.Add(imgCol);
               
               foreach
          }
     }
}
