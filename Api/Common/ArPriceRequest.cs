namespace API_CHASKAS.Api.Common
{
    public class ArPriceRequest
    {
        public int Id { get; set; }
        public int FKProduct { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
