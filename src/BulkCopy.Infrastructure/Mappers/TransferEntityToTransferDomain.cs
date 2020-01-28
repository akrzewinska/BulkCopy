using System;
using System.Collections.Generic;
using System.Text;
using BulkCopy.Infrastructure.EF.Entities;

namespace BulkCopy.Infrastructure.Mappers
{
    public static class TransferEntityToTransferDomain
    {
        public static Domain.Models.Transfer ToTransfer(this Transfer transfer)
        {
            return new Domain.Models.Transfer()
            {
                FromAccount = transfer.FromAccount,
                ToAccount = transfer.ToAccount,
                TransferAmount = transfer.TransferAmount
            };
        }


    }
}
