using System;
using System.ComponentModel.DataAnnotations;

namespace LibManage.Models
{
    public class  Post
    {
        public int Id{get;set;}
        [Required(ErrorMessage = "Tiêu đề không được bỏ trống")]
        public string Title{get;set;}
        public string Thumbnail{get;set;}

        [Required(ErrorMessage = "Mô tả không được bỏ trống")]
        public string Description{get;set;}

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        public string Content{get;set;}
        public int UserId{get;set;}

        public int ViewCount {get;set;}
        public virtual User User{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
        

    }
}

