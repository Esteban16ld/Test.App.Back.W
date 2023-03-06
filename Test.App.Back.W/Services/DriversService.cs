using System.Collections.Generic;
using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;
using Test.App.Back.W.Models;
using Test.App.Back.W.Services.Interfaces;

namespace Test.App.Back.W.Services
{
    public class DriversService : IDriversService
    {
        private readonly IDriversRepository _driversRepository;

        public DriversService(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public async Task<List<DriversModel>> FindAll()
        {
            List<DriversModel> result = new List<DriversModel>();
            var drivers = await _driversRepository.FindAll();
            foreach (var driver in drivers)
            {
                if(driver.IsOccupied == false)
                    result.Add(driver);
            }
            return result; 
        }

        public async Task<DriversModel> Update(DriversModel driverModel)
        {
            DriversModel driver = await _driversRepository.FindByIdentification(driverModel.Identification);

            if (driver is null)
                throw new System.Exception("Conductor no registrado");

            driver.IsOccupied = driverModel.IsOccupied;

            _driversRepository.Update(driver);
            return driverModel;
        }
    }
}
