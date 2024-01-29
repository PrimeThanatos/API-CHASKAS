namespace API_CHASKAS.Domain.Entities
{
    public class Purchase
    {
        public int PK { get; set; }
        public int FKPurchaseInvoce { get; set; }
        public int FKProduct { get; set; }
        public string? Measure  { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}