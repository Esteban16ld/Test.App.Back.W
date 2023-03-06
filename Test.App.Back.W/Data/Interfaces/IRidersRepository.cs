using System.Collections.Generic;
using System.Threading.Tasks;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data.Interfaces
{
    public interface IRidersRepository
    {
        Task DeleteByIdentification(string identification);
        Task<ICollection<RidersModel>> FindAll();
        Task<RidersModel> FindByIdentification(string identification);
    }
}
