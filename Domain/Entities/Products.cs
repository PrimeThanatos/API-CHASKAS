namespace API_CHASKAS.Domain.Entities
{
    public class Products
    {
        public int PK { get; set; }
        public int? FKProduct { get; set; }
        public int? FKCategory { get; set; }
        public string? Name { get; set; }
        public decimal? Size { get; set; }
        public decimal? Weight { get; set; }
       // public decimal? ingredients { get; set; }
        public int? PreparationTime { get; set; }
        public decimal? Cost {get;set;}
        public decimal? SellingPrice { get; set; }        
        public decimal? Currency { get; set; }
        public decimal? ExchangeRate { get; set; }                
        public DateTime? CreatedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}