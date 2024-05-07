namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoSaleInvoice
    {
        public int Id { get; set; }
        public int FKCustomer { get; set; }
        public int FKPaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public bool Cancel { get; set; }
        public int Available { get; set; }
    }
}