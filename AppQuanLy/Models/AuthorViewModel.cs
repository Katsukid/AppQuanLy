using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppQuanLy.Entities;
namespace AppQuanLy.Models
{
     public class AuthorViewModel : Author
     {
          public string Type { get; set; }
          public int numberBooks { get; set; }
          public AuthorViewModel() { }
          public AuthorViewModel(Author a) {
               this.ID = a.ID;
               this.Name = a.Name;
               this.Image = a.Image;
               this.AuthorType = a.AuthorType;
               this.DateOfBirth = a.DateOfBirth;
               this.Description = a.Description;
          }
          // Ep kieu sang Model
          public Author toEntity()
          {
               return new Author()
               {
                    ID = this.ID,
                    Name = this.Name,
                    DateOfBirth = this.DateOfBirth,
                    Description = this.Description,
                    Image = this.Image,
                    AuthorType = this.AuthorType
               };
          }
     }
}