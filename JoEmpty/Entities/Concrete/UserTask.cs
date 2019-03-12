using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserTask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
