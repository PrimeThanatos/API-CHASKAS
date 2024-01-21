namespace API_CHASKAS.Domain.Entities
{
    public class ArPrice
    {
        public int PK { get; set; }
        public int FKProduct { get; set; }
        public decimal PriceValue { get; set; }
        public decimal? Currency { get; set; }
        public decimal? ExchangeRate { get; set; }     
        public DateTime PurchaseDate { get; set; }
    }
}