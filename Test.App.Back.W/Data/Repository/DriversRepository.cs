using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data.Repository
{
    public class DriversRepository : GenericRepository<DriversModel>, IDriversRepository
    {
        private readonly DataContext _context;

        public DriversRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteByIdentification(string identification)
        {
            DriversModel driver = await _context.Drivers
                .Where(s => s.Identification.Equals(identification))
                .SingleOrDefaultAsync();
            if (driver != null)
                _context.Drivers.Remove(driver);
        }

        public async Task<ICollection<DriversModel>> FindAll()
        {
            ICollection<DriversModel> drivers = await _context.Drivers
                .ToListAsync();
            return drivers;
        }

        public async Task<DriversModel> FindByIdentification(string identification)
        {
            DriversModel driver = await _context.Drivers
                .Where(s => s.Identification.Equals(identification))
                .SingleOrDefaultAsync();
            return driver;
        }
    }
}
