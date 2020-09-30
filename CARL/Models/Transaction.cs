using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PlannedDate { get; set; }
        public Guid AccountId { get; set; }
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid TransactionTypeId { get; set; }

    }
}
