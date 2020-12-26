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

        [Required(ErrorMessage = "Username is not null")]
        [MaxLength(30, ErrorMessage = "Username is too long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is not null ")]
        [MaxLength(255, ErrorMessage = "The password is not too long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is not null")]
        [MaxLength(100, ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is not null")]
        [MaxLength(255, ErrorMessage = "Username is too long")]
        public string FullName { get; set; }
        public Gender Gender { get; set; }

        [MaxLength(200, ErrorMessage = "The address is not in the correct format")]
        public string Address { get; set; }

        [MaxLength(10, ErrorMessage = "Phone number incorrect format")]
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