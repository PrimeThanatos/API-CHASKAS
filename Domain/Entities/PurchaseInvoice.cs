namespace API_CHASKAS.Domain.Entities
{
    public class PurchaseInvoice
    {
        public int PK { get; set; }
        public int FKSupplier { get; set; }
        public DateTime Date { get; set; }
        public int FKPaymentMethod { get; set; }
        public bool IsCredit { get; set; }
        public int Total { get; set; }
        public bool Cancel { get; set; }
        public int Available { get; set; }
    }
}