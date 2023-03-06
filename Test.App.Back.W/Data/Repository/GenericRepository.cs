using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;

namespace Test.App.Back.W.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
