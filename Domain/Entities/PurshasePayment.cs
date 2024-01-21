namespace API_CHASKAS.Domain.Entities
{
    public class PurshasePayment
    {
        public int PK { get; set; }
        public int FKPurshaseInvoice { get; set; }
        public int Total { get; set; }
    }
}