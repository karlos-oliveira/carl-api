using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsCard { get; set; }
        public int DueDay { get; set; }
        public int CloseDay { get; set; }
        public Guid UserId { get; set; }
    }
}
