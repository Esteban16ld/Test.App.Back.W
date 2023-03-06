using System.Threading.Tasks;

namespace Test.App.Back.W.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
