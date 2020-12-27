using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibManage.Models
{
    public class Test
    {
        [Key]
        public int Id {get;set;}
        public string Name {get;set;}
    }
}