namespace API_CHASKAS.Domain.Entities
{
    public class PurchasePayment
    {
        public int PK { get; set; }
        public int FKPurchaseInvoice { get; set; }
        public int Total { get; set; }
    }
}