using System.ComponentModel.DataAnnotations;
using System;

namespace LibManage.Models
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Chủ đề không được bỏ trống")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Nội dung không được bỏ trống")]
        public string Content { get; set; }
        
        [Required(ErrorMessage = "Email không được bỏ trống")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email không đúng định dạng")]
        [MaxLength(100, ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}