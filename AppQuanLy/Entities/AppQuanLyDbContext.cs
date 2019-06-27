namespace AppQuanLy.Entities
{
     using System.Collections.Generic;
     using AppQuanLy.Helper;
     class AppQuanLyDbContext
     {
          public List<Author> Authors
          {
               get { return JSONHelper.SendGetRequest<List<Author>>("tac-gia?number"); }
          }
          public List<Book> Books
          {
               get { return JSONHelper.SendGetRequest<List<Book>>("sach?number"); }
          }
          public List<BookCategory> BookCategories
          {
               get { return JSONHelper.SendGetRequest<List<BookCategory>>("loai-sach?number"); }
          }
          public List<CartItem> CartItems
          {
               get { return JSONHelper.SendGetRequest<List<CartItem>>("chi-tiet-gio-hang?number"); }
          }
          public List<Category> Categories
          {
               get { return JSONHelper.SendGetRequest<List<Category>>("the-loai?number"); }
          }
          public List<Feedback> Feedbacks
          {
               get { return JSONHelper.SendGetRequest<List<Feedback>>("binh-luan?number"); }
          }
          public List<News> News
          {
               get { return JSONHelper.SendGetRequest<List<News>>("tin-tuc?number"); }
          }
          public List<NewsType> NewsTypes
          {
               get { return JSONHelper.SendGetRequest<List<NewsType>>("loai-tin-tuc?number"); }
          }
          public List<Order> Orders
          {
               get { return JSONHelper.SendGetRequest<List<Order>>("don-hang?number"); }
          }
          public List<Order_Detail> Order_Detail
          {
               get { return JSONHelper.SendGetRequest<List<Order_Detail>>("chi-tiet-don-hang?number"); }
          }
          public List<Publisher> Publishers
          {
               get { return JSONHelper.SendGetRequest<List<Publisher>>("nha-xuat-ban?number"); }
          }
          public List<ShippingType> ShippingTypes
          {
               get { return JSONHelper.SendGetRequest<List<ShippingType>>("loai-giao-hang?number"); }
          }
          public List<Slide> Slides
          {
               get { return JSONHelper.SendGetRequest<List<Slide>>("slide?number"); }
          }
          public List<User> Users
          {
               get { return JSONHelper.SendGetRequest<List<User>>("nguoi-dung?number"); }
          }
     }

}
