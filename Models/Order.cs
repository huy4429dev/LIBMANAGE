using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace LibManage.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
        public double PenaltyFee { get; set; }
        public DateTime TimeEnd { get; set; }

        [MaxLength(500)]
        public string Note { get; set; }
        public OrderStatus Status {get;set;}
        public DateTime FromDate {get;set;}
        public DateTime ToDate {get;set;}
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User {get;set;}
         
        public virtual ICollection<OrderDetail> OrderDetails {get;set;}
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }

    public enum OrderStatus : byte{
        Success = 1,
        Dispose = 2,
        Borrowed  = 3,
        NoProcess = 4,
        Overdue = 5

    }
}