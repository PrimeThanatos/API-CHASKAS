using API_CHASKAS.Domain.Entities;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPruebaRepository
    {
          Task<List<Prueba>> GetUsersByRole();
    }
}