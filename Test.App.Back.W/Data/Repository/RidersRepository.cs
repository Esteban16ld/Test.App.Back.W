using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;
using Test.App.Back.W.Models;

namespace Test.App.Back.W.Data.Repository
{
    public class RidersRepository : GenericRepository<RidersModel>, IRidersRepository
    {
        private readonly DataContext _context;

        public RidersRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        public async Task DeleteByIdentification(string identification)
        {
            RidersModel rider = await _context.Riders
                .Where(s => s.Identification.Equals(identification))
                .SingleOrDefaultAsync();
            if (rider != null)
                _context.Riders.Remove(rider);
        }

        public async Task<ICollection<RidersModel>> FindAll()
        {
            ICollection<RidersModel> riders = await _context.Riders
                .ToListAsync();
            return riders;
        }

        public async Task<RidersModel> FindByIdentification(string identification)
        {
            RidersModel rider = await _context.Riders
                .Where(s => s.Identification.Equals(identification))
                .SingleOrDefaultAsync();
            return rider;
        }
    }
}