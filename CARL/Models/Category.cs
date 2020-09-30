using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public string Level { get; set; }
        public Guid TransactionTypeId { get; set; }
        public Guid UserId { get; set; }
    }
}
