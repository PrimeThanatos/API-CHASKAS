namespace API_CHASKAS.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
        public string? Description { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public bool Available { get; set; }
    }
}