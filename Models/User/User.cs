using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LibManage.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tài khoản không được bỏ trống")]
        [MaxLength(30, ErrorMessage = "Tài khoản quá dài")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống ")]
        [MaxLength(255, ErrorMessage = "Mật khẩu không đúng định dạng")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email không được bỏ trống")]
        [MaxLength(100, ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Họ tên không được bỏ trống")]
        [MaxLength(255, ErrorMessage = "Họ tên không đúng định dạng")]
        public string FullName { get; set; }
        public Gender Gender { get; set; }

        [MaxLength(200, ErrorMessage = "Địa chỉ không hợp lệ")]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }
        public bool Status { get; set; }
        public DateTime CreatTime { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }

    }

    public enum Gender : byte
    {
        Male,
        FMale,
        BD
    }

    public class Role
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Role is not null")]

        [MaxLength(100, ErrorMessage = "The role name is too long")]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

    }

    public class UserRole
    {

        public int UserId { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

    }
    public class Claim
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Claim is not null")]

        [MaxLength(100, ErrorMessage = "The claim is too long")]
        public string Name { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }

    }

    public class RoleClaim
    {


        public int RoleId { get; set; }
        public int ClaimId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("ClaimId")]
        public virtual Claim Claim { get; set; }

    }
}