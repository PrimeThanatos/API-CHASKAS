namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoPurchase
    {
        public int Id { get; set; }
        public int FKPurchaseInvoce { get; set; }
        public int FKProduct { get; set; }
        public string? Measure  { get; set; }
        public decimal Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }
    }
}