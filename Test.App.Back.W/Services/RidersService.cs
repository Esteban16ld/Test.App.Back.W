using System.Collections.Generic;
using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;
using Test.App.Back.W.Models;
using Test.App.Back.W.Services.Interfaces;

namespace Test.App.Back.W.Services
{
    public class RidersService : IRidersService
    {
        private readonly IRidersRepository _ridersRepository;

        public RidersService(IRidersRepository driversRepository)
        {
            _ridersRepository = driversRepository;
        }

        public async Task<ICollection<RidersModel>> FindAll()
        {
            return await _ridersRepository.FindAll();
        }
    }
}
