using AppQuanLy.Entities;
using AppQuanLy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLy.DAO
{
     public class BookDao
     {
          private AppQuanLyDbContext db;
          public BookDao()
          {
               db = new AppQuanLyDbContext();
          }
          public BookViewModel toViewModel(Book b)
          {
               var pub = db.Publishers;
               return new BookViewModel()
               {
                    ID = b.ID,
                    Code = b.Code,
                    Name = b.Name,
                    Author = db.Authors.Where(a => a.ID == b.Author).SingleOrDefault().Name,
                    AuthorID = b.Author,
                    Publisher = pub.Where(a => a.ID == b.Publisher).SingleOrDefault().Name,
                    PublisherID = b.Publisher,
                    Released = pub.Where(a => a.ID == b.Released).SingleOrDefault().Name,
                    ReleasedID = b.Released,
                    NumberPage = b.NumberPage,
                    Weight = b.Weight,
                    Form = b.Form,
                    PublishDate = b.PublishDate,
                    Buys = b.Buys,
                    Price = b.Price,
                    PromotionPrice = b.PromotionPrice,
                    Category = db.BookCategories.Where(bc => bc.ID == b.CategoryID).SingleOrDefault().Name,
                    CategoryID = b.CategoryID,
                    ViewCount = b.ViewCount,
                    Inventory = b.Inventory,
                    Image = b.Image,
                    Status = b.Status,
                    Description = b.Description,
                    ModifiedBy =b.ModifiedBy,
                    ModifiedDate = b.ModifiedDate
               };
               
          }
     }
}
