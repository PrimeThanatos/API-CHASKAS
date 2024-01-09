using API_CHASKAS.Aplication.DTOs;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPruebaDeInterface
    {
         Task<List<DtoPrueba>> GetUsers();
    }
}