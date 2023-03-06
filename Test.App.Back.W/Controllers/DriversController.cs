using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using Test.App.Back.W.Data.Interfaces;
using Test.App.Back.W.Models;
using Test.App.Back.W.Services.Interfaces;

namespace Test.App.Back.W.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriversService _driversService;
        private readonly IUnitOfWork _unitOfWork;

        public DriversController(IDriversService driversService, IUnitOfWork unitOfWork)
        {
            _driversService = driversService;
            _unitOfWork = unitOfWork;
        }

        [HttpPut]
        [Route("UpdateDriver")]
        public async Task<IActionResult> UpdateDriver(DriversModel driversModel)
        {
            try
            {
                await _driversService.Update(driversModel);
                await _unitOfWork.SaveChangesAsync();
                return Ok(driversModel);
            }
            catch (System.Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetDrivers")]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                return Ok(await _driversService.FindAll());
            }
            catch (System.Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
