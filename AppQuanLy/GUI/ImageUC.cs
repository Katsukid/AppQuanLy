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
     public partial class ImageUC : UserControl
     {
          public ImageUC()
          {
               InitializeComponent();
          }
          public void ImageUC_Load(object sender, EventArgs e)
          {
               var data = ImageDao.TakeAll();
               this.grCtrlImage.DataSource = data;
          }
     }
}
