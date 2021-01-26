using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LibManage.Models 
{
    public class Book
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Title is not null")]
        [MaxLength(60, ErrorMessage = "Title is too long")]
        public string Title {get; set;}

        [ForeignKey ("Authors"), Required(ErrorMessage = "Required")]
        public int Author {get; set;}

        [ForeignKey("BookTypes"), Required(ErrorMessage = "Required")]
        public int BookTpye {get; set;}

        [ForeignKey("Publishers"), Required(ErrorMessage = "Required")]
        public int Publisher {get; set;}

        [Required(ErrorMessage = "Required")]
        public int YearPublished {get; set;} 

        public string Image {get; set;}

        public string PDFfile {get; set;}

        public string Description {get; set;}

        public int Quantity {get;set;}

        public float Rate {get;set;}

        public DateTime CreatedTime {get;set;}
        public DateTime UpdatedTime {get;set;}
        
        public Author Authors {get; set;}

        public BookType BookTypes { get; set; }

        public Publisher Publishers {get; set;}
   
        public ICollection<BookTag> BookTags { get; set; }
         public ICollection<OrderDetail> OrderDetails { get; set; }

    }

    public class BookType
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name {get; set;}

        [MaxLength(255, ErrorMessage = "Name is toso long")]
        public string Description {get; set;}

        public ICollection<Book> Books { get; set; }
    }

    public class Publisher
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name {get; set;}

        [MaxLength(150, ErrorMessage = "Name is too long")]
        public string Description {get; set;}

        public ICollection<Book> Books { get; set; }
    }

    public class Author
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name {get; set;}

        [MaxLength(150, ErrorMessage = "Name is too long")]
        public string Description {get; set;}

        public ICollection<Book> Books { get; set; }
    }
}