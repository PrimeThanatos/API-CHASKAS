namespace API_CHASKAS.Domain.Entities
{
    public class Step
    {
        public int PK { get; set; }
        public int FkRecipe { get; set; }
        public int Number { get; set; }
        public string? Name { get; set; }
    }
}