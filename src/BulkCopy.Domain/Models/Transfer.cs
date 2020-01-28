using System;
using System.Collections.Generic;
using System.Text;

namespace BulkCopy.Domain.Models
{
    public class Transfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
        
    }
}
