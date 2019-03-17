using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("UserTask")]
    public class UserTask
    {
        [Key]
        public Guid Id { get; set; }
        public Guid  UserId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
