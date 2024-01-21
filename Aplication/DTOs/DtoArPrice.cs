namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoArPrice
    {
        public int PK { get; set; }
        public int FKProduct { get; set; }
        public decimal PriceValue { get; set; }
        public decimal? Currency { get; set; }
        public decimal? ExchangeRate { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
