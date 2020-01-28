using System.Collections;
using System.Collections.Generic;
using BulkCopy.Domain.Repository;
using BulkCopy.Infrastructure.EF;
using BulkCopy.Infrastructure.EF.Entities;
using DomainModels = BulkCopy.Domain.Models;

namespace BulkCopy.Infrastructure.Repository
{
    public class SomeRepository : ISomeRepository
    {
        private SampleDbContext _ctx;

        public SomeRepository(SampleDbContext ctx)
        {
            _ctx = ctx;
        }

        

        public IEnumerable<DomainModels.Transfer> GetTransfers()
        {
           return _ctx.Transfers;
       
        }
    }
}