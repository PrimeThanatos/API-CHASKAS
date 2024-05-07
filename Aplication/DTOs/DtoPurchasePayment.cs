namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoPurchasePayment
    {
        public int Id { get; set; }
        public int FKPurchaseInvoice { get; set; }
        public int Total { get; set; }
    }
}