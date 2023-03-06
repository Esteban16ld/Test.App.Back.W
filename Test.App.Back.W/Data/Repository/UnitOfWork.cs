using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;

namespace Test.App.Back.W.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DataContext _context { get; private set; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
