using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
