namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoRecipe
    {
        public int Id { get; set; }
        public int FKProduct { get; set; }
        public string? Recipe {get;set;}     
        public int PreparationTimeMinuts { get; set; } 
        public string? PKackage { get; set; }  
    }
}