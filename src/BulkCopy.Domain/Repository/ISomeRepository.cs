using System.Collections.Generic;
using BulkCopy.Domain.Models;

namespace BulkCopy.Domain.Repository
{
    public interface ISomeRepository
    {
        IEnumerable<Transfer> GetTransfers();
    }
}