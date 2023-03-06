using System.Collections.Generic;
using System.Threading.Tasks;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Services.Interfaces
{
    public interface IRidersService
    {
        Task<ICollection<RidersModel>> FindAll();
    }
}
