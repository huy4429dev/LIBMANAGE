using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LibManage.Models
{
    public class RuleFee
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được bỏ trống")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Giá trị không được bỏ trống")]
        [Range(0, 9999999, ErrorMessage = "Giá trị không hợp lệ")]
        public int Value { get; set; }
        public virtual ICollection<OrderRuleFee> OrderRuleFees { get; set; }
    }

     public class OrderRuleFee
    {

        public int RoleFeeId { get; set; }
        public int OrderId { get; set; }

        [Display(Name="Số lượng")]
        public int Total {get;set;}

        [Display(Name="Phí phạt")]
        public int TotalFee {get;set;}

        [ForeignKey("RoleFeeId")]
        public virtual RuleFee RuleFee { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

    }
}