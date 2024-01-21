namespace API_CHASKAS.Domain.Entities
{
    public class Supplier
    {
        public int PK { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string?  RFC { get; set; }
        public string? CP { get; set; }
        public string? Adress { get; set; }
        public int CreditDays { get; set; }
        public bool Available { get; set; }

    }
}