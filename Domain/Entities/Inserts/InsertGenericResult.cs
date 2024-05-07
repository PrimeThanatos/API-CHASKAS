namespace API_CHASKAS.Domain.Entities.Inserts
{
    public class InsertGenericResult
    {
        public string Message { get; set; } // Mensaje de la operación
        public int Id { get; set; } // Clave principal del departamento (en caso de éxito)

        public InsertGenericResult()
        {
            Message = string.Empty;
            Id = 0;
        }
    }
}