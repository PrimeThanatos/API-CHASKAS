namespace API_CHASKAS.Domain.Entities
{
    public class Recipe
    {
        public int PK { get; set; }
        public int FKProduct { get; set; }
        public string? Name {get;set;}     
        public int PreparationTimeMinuts { get; set; } 
        public string? PKackage { get; set; }  
    }
}