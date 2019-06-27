using AppQuanLy.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLy.Models
{
    public class SlideModel
    {
        public Slide slide { get; set; }
        public String NameBook { get; set; }

        internal IEnumerable<object> Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
