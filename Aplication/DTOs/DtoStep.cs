namespace API_CHASKAS.Aplication.DTOs
{
    public class DtoStep
    {
          public int PK { get; set; }
        public int FkRecipe { get; set; }
        public int Number { get; set; }
        public string? Step { get; set; }
    }
}