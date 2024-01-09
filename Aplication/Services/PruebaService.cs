using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class PruebaService: IPruebaDeInterface
    {
        private readonly IPruebaRepository _pruebaRepository;
        public PruebaService(IPruebaRepository pruebaRepository)
        {
            _pruebaRepository = pruebaRepository;
        }

        public async Task<List<DtoPrueba>> GetUsers()
        {
            var users =  await _pruebaRepository.GetUsersByRole();
            return users.Select(x=> new DtoPrueba{
                PK = x.PKUser,               
                Name = x.Name,
                Email = x.Email,
                Available = x.Available,
            }).ToList();
        }
        
    }
}