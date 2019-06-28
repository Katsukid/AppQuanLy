using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLy.Entities;
namespace AppQuanLy.Models
{
     class ImageViewModel
     {
          public Image image { get; set; }
          public ImageViewModel() { }
          public ImageViewModel(Image image)
          {
               this.image = image;
          }
     }
}
