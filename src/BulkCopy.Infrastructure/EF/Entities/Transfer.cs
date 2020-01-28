namespace BulkCopy.Infrastructure.EF.Entities
{
    public class Transfer
    {
        public int FromAccount {get;set;}
        public int ToAccount {get;set;}
        public decimal TransferAmount {get;set;}
    }
}